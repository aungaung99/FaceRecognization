
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Face;
using Emgu.CV.Structure;

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FaceRecognization
{
    public partial class Form1 : Form
    {
        #region Variables
        private Capture _captureEmgu = null;

        private Image<Bgr, byte> currentFrame = null;
        private bool facesDetectionEnabled = false;
        private readonly CascadeClassifier faceCasacdeClassifier = new CascadeClassifier(@"C:\haarcascades\haarcascade_frontalface_alt_tree.xml");
        private List<int> PersonsLabes = new List<int>();
        private List<Image<Gray, byte>> TrainedFaces = new List<Image<Gray, byte>>();
        private bool EnableSaveImage = false;
        private bool isTrained = false;
        private EigenFaceRecognizer recognizer;
        private readonly List<string> PersonsNames = new List<string>();

        //Mat imageFace;
        private readonly Mat imageEmgu = new Mat();
        #endregion
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCapture_Click(object sender, EventArgs e)
        {
            //Dispose of Capture if it was created before
            if (_captureEmgu != null)
            {
                _captureEmgu.Dispose();
            }
            _captureEmgu = new Capture();

            Application.Idle += ProcessFrame;
            //_captureEmgu.Start();
        }

        private void ProcessFrame(object sender, EventArgs e)
        {
            double scaleFactorValue = decimal.ToDouble(scaleFactor.Value);
            int neighborsValue = decimal.ToInt32(neighbors.Value);

            System.Diagnostics.Stopwatch watch = System.Diagnostics.Stopwatch.StartNew();

            //Step 1: Video Capture
            if (_captureEmgu != null && _captureEmgu.Ptr != IntPtr.Zero)
            {
                _captureEmgu.Retrieve(imageEmgu, 0);
                currentFrame = imageEmgu.ToImage<Bgr, byte>().Resize(picCapture.Width, picCapture.Height, Inter.Cubic);

                //Step 2: Face Detection
                if (facesDetectionEnabled)
                {

                    //Convert from Bgr to Gray Image
                    Mat grayImage = new Mat();
                    CvInvoke.CvtColor(currentFrame, grayImage, ColorConversion.Bgr2Gray);
                    //Enhance the image to get better result
                    CvInvoke.EqualizeHist(grayImage, grayImage);

                    Rectangle[] faces = faceCasacdeClassifier.DetectMultiScale(grayImage, 1.4, 1, Size.Empty, Size.Empty);
                    //If faces detected
                    if (faces.Length > 0)
                    {

                        foreach (Rectangle face in faces)
                        {
                            //Draw square around each face 
                            // CvInvoke.Rectangle(currentFrame, face, new Bgr(Color.Red).MCvScalar, 2);

                            //Step 3: Add Person 
                            //Assign the face to the picture Box face picDetected
                            Image<Bgr, byte> resultImage = currentFrame.Convert<Bgr, byte>();
                            resultImage.ROI = face;
                            picFace.SizeMode = PictureBoxSizeMode.StretchImage;
                            picFace.Image = resultImage.Bitmap;

                            if (EnableSaveImage)
                            {
                                //We will create a directory if does not exists!
                                string path = Directory.GetCurrentDirectory() + @"\TrainedImages";
                                if (!Directory.Exists(path))
                                {
                                    Directory.CreateDirectory(path);
                                }
                                //we will save 10 images with delay a second for each image 
                                //to avoid hang GUI we will create a new task
                                Task.Factory.StartNew(() =>
                                {
                                    for (int i = 0; i < 2; i++)
                                    {
                                        //resize the image then saving it
                                        resultImage.Resize(200, 200, Inter.Cubic).Save(path + @"\" + TxtName.Text + "_" + DateTime.Now.ToString("dd-mm-yyyy-hh-mm-ss") + ".jpg");
                                        Thread.Sleep(1000);
                                    }
                                });

                            }
                            EnableSaveImage = false;

                            if (BtnAddPerson.InvokeRequired)
                            {
                                BtnAddPerson.Invoke(new ThreadStart(delegate
                                {
                                    BtnAddPerson.Enabled = true;
                                }));
                            }

                            // Step 5: Recognize the face 
                            if (isTrained)
                            {
                                Image<Gray, byte> grayFaceResult = resultImage.Convert<Gray, byte>().Resize(200, 200, Inter.Cubic);
                                CvInvoke.EqualizeHist(grayFaceResult, grayFaceResult);
                                FaceRecognizer.PredictionResult result = recognizer.Predict(grayFaceResult);
                                picCapture.Image = grayFaceResult.Bitmap;
                                picFace.Image = TrainedFaces[result.Label].Bitmap;
                                Debug.WriteLine(result.Label + ". " + result.Distance);
                                //Here results found known faces
                                if (result.Label != -1 && result.Distance < 2000)
                                {
                                    CvInvoke.PutText(currentFrame, PersonsNames[result.Label], new Point(face.X - 2, face.Y - 2),
                                        FontFace.HersheyComplex, 1.0, new Bgr(Color.Orange).MCvScalar);
                                    CvInvoke.Rectangle(currentFrame, face, new Bgr(Color.Green).MCvScalar, 2);
                                }
                                //here results did not found any know faces
                                else
                                {
                                    CvInvoke.PutText(currentFrame, "Unknown", new Point(face.X - 2, face.Y - 2),
                                        FontFace.HersheyComplex, 1.0, new Bgr(Color.Orange).MCvScalar);
                                    CvInvoke.Rectangle(currentFrame, face, new Bgr(Color.Red).MCvScalar, 2);

                                }
                            }
                        }
                    }
                }

                //Render the video capture into the Picture Box picCapture
                picCapture.Image = currentFrame.Bitmap;
            }

            //Dispose the Current Frame after processing it to reduce the memory consumption.
            if (currentFrame != null)
            {
                currentFrame.Dispose();
            }

            watch.Stop();
            totalTime.Text = "Total time: " + watch.ElapsedMilliseconds.ToString() + " ms";
        }

        private void BtnAddPerson_Click(object sender, EventArgs e)
        {
            EnableSaveImage = true;
        }

        private void BtnDetectFaces_Click(object sender, EventArgs e)
        {
            facesDetectionEnabled = true;
        }

        private void BtnTrainImages_Click(object sender, EventArgs e)
        {
            TrainImagesFromDir();
        }

        private bool TrainImagesFromDir()
        {
            int ImagesCount = 0;
            double Threshold = 2000;
            TrainedFaces.Clear();
            PersonsLabes.Clear();
            PersonsNames.Clear();
            try
            {
                string path = Directory.GetCurrentDirectory() + @"\TrainedImages";
                string[] files = Directory.GetFiles(path, "*.jpg", SearchOption.AllDirectories);

                foreach (string file in files)
                {
                    Image<Gray, byte> trainedImage = new Image<Gray, byte>(file).Resize(200, 200, Inter.Cubic);
                    CvInvoke.EqualizeHist(trainedImage, trainedImage);
                    TrainedFaces.Add(trainedImage);
                    PersonsLabes.Add(ImagesCount);
                    string name = file.Split('\\').Last().Split('_')[0];
                    PersonsNames.Add(name);
                    ImagesCount++;
                    Debug.WriteLine(ImagesCount + ". " + name);

                }

                if (TrainedFaces.Count() > 0)
                {
                    // recognizer = new EigenFaceRecognizer(ImagesCount,Threshold);
                    recognizer = new EigenFaceRecognizer(ImagesCount, Threshold);
                    recognizer.Train(TrainedFaces.ToArray(), PersonsLabes.ToArray());

                    isTrained = true;
                    //Debug.WriteLine(ImagesCount);
                    //Debug.WriteLine(isTrained);
                    return true;
                }
                else
                {
                    isTrained = false;
                    return false;
                }
            }
            catch (Exception ex)
            {
                isTrained = false;
                MessageBox.Show("Error in Train Images: " + ex.Message);
                return false;
            }

        }
    }
}

