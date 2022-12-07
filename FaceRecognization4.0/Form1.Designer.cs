
namespace FaceRecognization4._0
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnAddFace = new System.Windows.Forms.Button();
            this.BtnDetectFace = new System.Windows.Forms.Button();
            this.BtnCapture = new System.Windows.Forms.Button();
            this.TxtName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Cursor = System.Windows.Forms.Cursors.VSplit;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.TxtName);
            this.splitContainer1.Panel2.Controls.Add(this.BtnAddFace);
            this.splitContainer1.Panel2.Controls.Add(this.BtnDetectFace);
            this.splitContainer1.Panel2.Controls.Add(this.BtnCapture);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 555;
            this.splitContainer1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(555, 450);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // BtnAddFace
            // 
            this.BtnAddFace.Location = new System.Drawing.Point(15, 99);
            this.BtnAddFace.Name = "BtnAddFace";
            this.BtnAddFace.Size = new System.Drawing.Size(102, 23);
            this.BtnAddFace.TabIndex = 2;
            this.BtnAddFace.Text = "Add Face";
            this.BtnAddFace.UseVisualStyleBackColor = true;
            this.BtnAddFace.Click += new System.EventHandler(this.BtnAddFace_Click);
            // 
            // BtnDetectFace
            // 
            this.BtnDetectFace.Location = new System.Drawing.Point(15, 41);
            this.BtnDetectFace.Name = "BtnDetectFace";
            this.BtnDetectFace.Size = new System.Drawing.Size(102, 23);
            this.BtnDetectFace.TabIndex = 1;
            this.BtnDetectFace.Text = "Detect Face";
            this.BtnDetectFace.UseVisualStyleBackColor = true;
            this.BtnDetectFace.Click += new System.EventHandler(this.BtnDetectFace_Click);
            // 
            // BtnCapture
            // 
            this.BtnCapture.Location = new System.Drawing.Point(15, 12);
            this.BtnCapture.Name = "BtnCapture";
            this.BtnCapture.Size = new System.Drawing.Size(102, 23);
            this.BtnCapture.TabIndex = 0;
            this.BtnCapture.Text = "Capture";
            this.BtnCapture.UseVisualStyleBackColor = true;
            this.BtnCapture.Click += new System.EventHandler(this.BtnCapture_Click);
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(15, 70);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(100, 23);
            this.TxtName.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnCapture;
        private System.Windows.Forms.Button BtnDetectFace;
        private System.Windows.Forms.Button BtnAddFace;
        private System.Windows.Forms.TextBox TxtName;
    }
}

