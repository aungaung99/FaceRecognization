using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Face;
using Emgu.CV.Structure;
using Emgu.CV.Util;

using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace FaceRecognization4._0
{
    public partial class Form1 : Form
    {
        private VideoCapture _catpure = null;
        private Image<Bgr, byte> currentFrame = null;
        private Image<Gray, byte> detectFace = null;
        private readonly List<FaceData> faceList = new();
        private readonly VectorOfMat imageList = new();
        private readonly VectorOfInt labelList = new();
        private readonly List<string> nameList = new();
        private CascadeClassifier haarCascade = new(@"C:\haarcascades\haarcascade_frontalface_alt_tree.xml");
        private bool EnabledDetectFace = false;
        private bool EnabledRecognizeFace = false;
        private readonly Mat imageEmgu = new();
        private EigenFaceRecognizer recognizer;
        private bool IsFileUpload = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCapture_Click(object sender, EventArgs e)
        {
            if (_catpure != null)
            {
                _catpure.Dispose();
            }

            _catpure = new VideoCapture();
            Application.Idle += ProcessFrame;
            _catpure.Start();
        }

        private void ProcessFrame(object sender, EventArgs e)
        {
            if (_catpure != null && _catpure.Ptr != IntPtr.Zero)
            {
                System.Diagnostics.Stopwatch watch = System.Diagnostics.Stopwatch.StartNew();

                _catpure.Retrieve(imageEmgu, 0);
                currentFrame = _catpure.QueryFrame().ToImage<Bgr, byte>().Resize(picCapture.Width, picCapture.Height, Inter.Cubic);
                //currentFrame = imageEmgu.ToImage<Bgr, byte>().Resize(pictureBox1.Width, pictureBox1.Height, Inter.Cubic);
                if (currentFrame != null)
                {
                    if (EnabledDetectFace)
                    {
                        try
                        {
                            Image<Gray, byte> grayFrame = currentFrame.Convert<Gray, byte>();
                            Rectangle[] faces = haarCascade.DetectMultiScale(grayFrame, 1.3, 10, Size.Empty, Size.Empty);

                            // detect face
                            foreach (Rectangle face in faces)
                            {
                                currentFrame.Draw(face, new Bgr(225, 225, 0), 2);
                                detectFace = currentFrame.Copy(face).Convert<Gray, byte>();
                                if (EnabledRecognizeFace)
                                {
                                    FaceRecognition();
                                }

                                break;
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }

                    picCapture.Image = currentFrame.ToBitmap();
                }

                watch.Stop();
                totalTime.Text = "Total time: " + watch.ElapsedMilliseconds.ToString() + " ms";
            }
        }

        private void BtnDetectFace_Click(object sender, EventArgs e)
        {
            EnabledDetectFace = true;
        }

        private void BtnAddFace_Click(object sender, EventArgs e)
        {
            if (detectFace == null)
            {
                MessageBox.Show("No Face detected");
                return;
            }

            // save detected face
            detectFace = detectFace.Resize(100, 100, Inter.Cubic);
            //We will create a directory if does not exists!
            string path = Directory.GetCurrentDirectory() + @"\TrainedImages";
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            if (string.IsNullOrEmpty(TxtName.Text))
            {
                MessageBox.Show("Please type Name");
                return;
            }

            //resultImage.Resize(200, 200, Inter.Cubic).Save(path + @"\" + TxtName.Text + "_" + DateTime.Now.ToString("dd-mm-yyyy-hh-mm-ss") + ".jpg");
            //detectFace.Save(path + @"\" + TxtName.Text + "_" + DateTime.Now.ToString("dd-mm-yyyy-hh-mm-ss") + ".jpg");
            detectFace.Save(Config.FacePhotosPath + @"\" + "face" + (faceList.Count + 1) + Config.ImageFileExtension);
            StreamWriter writer = new StreamWriter(Config.FaceListTextFile, true);
            writer.WriteLine(string.Format("face{0}:{1}", (faceList.Count + 1), TxtName.Text));
            writer.Close();

            GetFacesList();
        }

        public void GetFacesList()
        {
            //haar cascade classifier
            if (!File.Exists(Config.HaarCascadePath))
            {
                string text = "Cannot find Haar cascade data file:\n\n";
                text += Config.HaarCascadePath;
                MessageBox.Show(text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            haarCascade = new CascadeClassifier(Config.HaarCascadePath);
            faceList.Clear();
            string line;

            // Create empty directory / file for face data if it doesn't exist
            if (!Directory.Exists(Config.FacePhotosPath))
            {
                Directory.CreateDirectory(Config.FacePhotosPath);
            }

            if (!File.Exists(Config.FaceListTextFile))
            {
                string text = "Cannot find face data file:\n\n";
                text += Config.FaceListTextFile + "\n\n";
                text += "If this is your first time running the app, an empty file will be created for you.";
                DialogResult result = MessageBox.Show(text, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                switch (result)
                {
                    case DialogResult.OK:
                        string dirName = Path.GetDirectoryName(Config.FaceListTextFile);
                        Directory.CreateDirectory(dirName);
                        File.Create(Config.FaceListTextFile).Close();
                        break;
                }
            }

            StreamReader reader = new(Config.FaceListTextFile);
            int i = 0;
            while ((line = reader.ReadLine()) != null)
            {
                string[] lineParts = line.Split(':');
                FaceData faceInstance = new()
                {
                    FaceImage = new Image<Gray, byte>(Config.FacePhotosPath + @"\" + lineParts[0] + Config.ImageFileExtension),
                    PersonName = lineParts[1]
                };
                faceList.Add(faceInstance);
            }
            foreach (FaceData face in faceList)
            {
                imageList.Push(face.FaceImage.Mat);
                nameList.Add(face.PersonName);
                labelList.Push(new[] { i++ });
            }
            reader.Close();

            // Train recogniser
            if (imageList.Size > 0)
            {
                recognizer = new EigenFaceRecognizer(imageList.Size);
                recognizer.Train(imageList, labelList);
            }

        }

        private void FaceRecognition()
        {
            if (imageList.Size != 0)
            {
                //Eigen Face Algorithm
                FaceRecognizer.PredictionResult result = recognizer.Predict(detectFace.Resize(100, 100, Inter.Cubic));
                //if (result.Label != 0)
                //{

                //}
                //else
                //{
                //    lblName.Text = "Face not found";
                //}

                lblName.Text = nameList[result.Label];
                picRecognizeFace.Image = detectFace.ToBitmap();
            }
            else
            {
                lblName.Text = "Please Add Face";
            }
        }

        private void BtnRecoginze_Click(object sender, EventArgs e)
        {
            EnabledRecognizeFace = true;
            if (IsFileUpload)
                FaceRecognition();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GetFacesList();
        }

        private void BtnUpload_Click(object sender, EventArgs e)
        {
            IsFileUpload = true;
            using OpenFileDialog dialog = new() { Multiselect = false, Filter = "JPEG|*.jpg" };
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                picCapture.Image = Image.FromFile(dialog.FileName);
                Bitmap bitmap = new(picCapture.Image);
                Image<Bgr, byte> currentImg = bitmap.ToImage<Bgr, byte>().Convert<Bgr, byte>();
                Rectangle[] faces = haarCascade.DetectMultiScale(currentImg, 1.3, 10, Size.Empty, Size.Empty);
                foreach (Rectangle face in faces)
                {
                    using (Graphics graphics = Graphics.FromImage(bitmap))
                    {
                        using Pen pen = new(Color.Red, 1);
                        graphics.DrawRectangle(pen, face);
                    }

                    detectFace = currentImg.Copy(face).Convert<Gray, byte>();

                    picCapture.Image = bitmap;//currentImg.Resize(picCapture.Width, picCapture.Height, Inter.Cubic).ToBitmap();
                    picCapture.SizeMode = PictureBoxSizeMode.CenterImage;
                    picRecognizeFace.Image = detectFace.ToBitmap();
                }
            }
        }
    }
}
