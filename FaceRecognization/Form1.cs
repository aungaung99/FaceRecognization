using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Face;
using Emgu.CV.Structure;

using System;
using System.IO;
using System.Windows.Forms;

namespace FaceRecognization
{
    public partial class Form1 : Form
    {
        #region Varaiables

        private VideoCapture videoCapture = null;
        private Image<Bgr, Byte> currentFrame = null;
        private readonly Mat frame = new Mat();

        #endregion
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCapture_Click(object sender, EventArgs e)
        {
            videoCapture = new VideoCapture();
            videoCapture.ImageGrabbed += ProcessFrame;
            videoCapture.Start();

        }

        private void ProcessFrame(object sender, EventArgs e)
        {
            // Step 1 : Capture
            videoCapture.Retrieve(frame, 0);
            currentFrame = frame.ToImage<Bgr, Byte>().Resize(pictureBox1.Width, pictureBox1.Height, Inter.Cubic);

            // Render the video capture into the Picutre Box
            System.Drawing.Bitmap bmp;
            using (var ms = new MemoryStream(currentFrame.Bytes))
            {
                bmp = new System.Drawing.Bitmap(ms);
            }
            pictureBox1.Image = bmp;
        }
    }
}
