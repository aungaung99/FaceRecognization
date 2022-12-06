
using System;
using System.IO;
using System.Windows.Forms;

namespace FaceRecognization
{
    public partial class Form1 : Form
    {
        #region Varaiables

        //private VideoCapture videoCapture = null;
        //private Image<Bgr, byte> currentFrame = null;
        //private readonly Mat frame = new();

        #endregion
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCapture_Click(object sender, EventArgs e)
        {
          

        }

        private void ProcessFrame(object sender, EventArgs e)
        {
            //try
            //{

            //    // Step 1 : Capture
            //    videoCapture.Retrieve(frame, 0);
            //    currentFrame = frame.ToImage<Bgr, byte>().Resize(pictureBox1.Width, pictureBox1.Height, Inter.Cubic);

            //    // Render the video capture into the Picutre Box
            //    System.Drawing.Bitmap bmp;
            //    using (MemoryStream ms = new(currentFrame.Bytes))
            //    {
            //        bmp = new System.Drawing.Bitmap(ms);
            //    }
            //    pictureBox1.Image = bmp;
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}

        }
    }
}
