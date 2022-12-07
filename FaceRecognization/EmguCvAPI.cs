using System;
using System.Drawing;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Emgu.CV.Face;
using System.IO;
using System.Threading.Tasks;
using System.Threading;

namespace FaceRecognization
{
    public class EmguCvAPI
    {
        #region Variables
        private static CascadeClassifier faceCasacdeClassifier = new CascadeClassifier(@"C:\haarcascades\haarcascade_frontalface_alt_tree.xml");
        private static Image<Bgr, Byte> currentFrame = null;
        #endregion

        #region Getters/Setters
        public static Image<Bgr, Byte> resultImage { get; set; }
        #endregion

        public EmguCvAPI()
        {

        }

        public static Image<Bgr, Byte> DetectFaces(
            Mat frame,
            int width,
            int height,
            double scaleFactor,
            int neighbors,
            Label detectionTimeLabel,
            Label drawingTimeLabel,
            bool EnableSaveImage,
            Button btnAddPerson,
            TextBox txtPersonName)
        {
            // Start watch to mesure time to detect
            var watch = System.Diagnostics.Stopwatch.StartNew();

            currentFrame = frame.ToImage<Bgr, Byte>().Resize(width, height, Inter.Cubic);

            Mat grayImage = new Mat();
            CvInvoke.CvtColor(currentFrame, grayImage, ColorConversion.Bgr2Gray);
            CvInvoke.EqualizeHist(grayImage, grayImage);

            Rectangle[] faces = faceCasacdeClassifier.DetectMultiScale(grayImage, scaleFactor, neighbors, Size.Empty, Size.Empty);

            watch.Stop();
            detectionTimeLabel.Text = "Detection time: " + watch.ElapsedMilliseconds.ToString() + " ms";

            // Restart watch to mesure time to draw
            watch.Restart();

            if (faces.Length > 0)
            {
                foreach (var face in faces)
                {
                    resultImage = currentFrame.Convert<Bgr, Byte>();
                    resultImage.ROI = face;

                    CvInvoke.Rectangle(currentFrame, face, new Bgr(Color.Red).MCvScalar, 2);
                 
                    resultImage.ROI = face;

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
                            for (int i = 0; i < 10; i++)
                            {
                                //resize the image then saving it
                                resultImage.Resize(200, 200, Inter.Cubic).Save(path + @"\" + txtPersonName.Text + "_" + DateTime.Now.ToString("dd-mm-yyyy-hh-mm-ss") + ".jpg");
                                Thread.Sleep(1000);
                            }
                        });

                    }
                    EnableSaveImage = false;
                    if (btnAddPerson.InvokeRequired)
                    {
                        btnAddPerson.Invoke(new ThreadStart(delegate
                        {
                            btnAddPerson.Enabled = true;
                        }));
                    }
                }
            }

            watch.Stop();
            drawingTimeLabel.Text = "Drawing time: " + watch.ElapsedMilliseconds.ToString() + " ms";

            return currentFrame;
        }

    }
}
