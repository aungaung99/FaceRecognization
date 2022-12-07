using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Emgu.CV.Face;
using Emgu.Util;
using System;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System.Collections.Generic;

namespace FaceRecognization4._0
{
    public partial class Form1 : Form
    {
        VideoCapture _catpure = null;
        private Image<Bgr, Byte> currentFrame = null;
        private Image<Gray, Byte> detectFace = null;
        private List<FaceData> faceList = new();
        private readonly CascadeClassifier haarCascade = new(@"C:\haarcascades\haarcascade_frontalface_alt_tree.xml");
        private bool EnabledDetectFace = false;
        private readonly Mat imageEmgu = new Mat();
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
                _catpure.Retrieve(imageEmgu, 0);
                currentFrame = _catpure.QueryFrame().ToImage<Bgr, Byte>();
                //currentFrame = imageEmgu.ToImage<Bgr, byte>().Resize(pictureBox1.Width, pictureBox1.Height, Inter.Cubic);
                if (currentFrame != null)
                {
                    if (EnabledDetectFace)
                    {
                        try
                        {
                            Image<Gray, Byte> grayFrame = currentFrame.Convert<Gray, Byte>();
                            Rectangle[] faces = haarCascade.DetectMultiScale(grayFrame, 1.2, 10, Size.Empty, Size.Empty);

                            // detect face
                            foreach (var face in faces)
                            {
                                currentFrame.Draw(face, new Bgr(225, 225, 0), 2);
                                detectFace = currentFrame.Copy(face).Convert<Gray, Byte>();
                                break;
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }

                    pictureBox1.Image = currentFrame.ToBitmap();
                }

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
            detectFace.Save(path + @"\" + TxtName.Text + "_" + DateTime.Now.ToString("dd-mm-yyyy-hh-mm-ss") + ".jpg");
            StreamWriter writer = new StreamWriter(Config.FaceListTextFile, true);
            writer.WriteLine(String.Format("face{0}:{1}", (faceList.Count + 1), TxtName.Text));
            writer.Close();
        }

        private void GetFacesList()
        {
            if (!File.Exists(@"C:\haarcascades\haarcascade_frontalface_alt_tree.xml"))
            {
                //string text="Con"
            }
        }
    }
}
