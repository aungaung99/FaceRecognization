
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
            this.picCapture = new System.Windows.Forms.PictureBox();
            this.BtnReset = new System.Windows.Forms.Button();
            this.totalTime = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.picRecognizeFace = new System.Windows.Forms.PictureBox();
            this.BtnRecoginze = new System.Windows.Forms.Button();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.BtnAddFace = new System.Windows.Forms.Button();
            this.BtnDetectFace = new System.Windows.Forms.Button();
            this.BtnCapture = new System.Windows.Forms.Button();
            this.BtnUpload = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCapture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRecognizeFace)).BeginInit();
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
            this.splitContainer1.Panel1.Controls.Add(this.picCapture);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.BtnUpload);
            this.splitContainer1.Panel2.Controls.Add(this.BtnReset);
            this.splitContainer1.Panel2.Controls.Add(this.totalTime);
            this.splitContainer1.Panel2.Controls.Add(this.lblName);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.picRecognizeFace);
            this.splitContainer1.Panel2.Controls.Add(this.BtnRecoginze);
            this.splitContainer1.Panel2.Controls.Add(this.TxtName);
            this.splitContainer1.Panel2.Controls.Add(this.BtnAddFace);
            this.splitContainer1.Panel2.Controls.Add(this.BtnDetectFace);
            this.splitContainer1.Panel2.Controls.Add(this.BtnCapture);
            this.splitContainer1.Size = new System.Drawing.Size(1239, 798);
            this.splitContainer1.SplitterDistance = 956;
            this.splitContainer1.TabIndex = 0;
            // 
            // picCapture
            // 
            this.picCapture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picCapture.Location = new System.Drawing.Point(0, 0);
            this.picCapture.Name = "picCapture";
            this.picCapture.Size = new System.Drawing.Size(956, 798);
            this.picCapture.TabIndex = 0;
            this.picCapture.TabStop = false;
            // 
            // BtnReset
            // 
            this.BtnReset.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnReset.Location = new System.Drawing.Point(18, 751);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(218, 35);
            this.BtnReset.TabIndex = 9;
            this.BtnReset.Text = "Reset";
            this.BtnReset.UseVisualStyleBackColor = true;
            // 
            // totalTime
            // 
            this.totalTime.AutoSize = true;
            this.totalTime.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.totalTime.Location = new System.Drawing.Point(18, 451);
            this.totalTime.Name = "totalTime";
            this.totalTime.Size = new System.Drawing.Size(118, 21);
            this.totalTime.TabIndex = 8;
            this.totalTime.Text = "Total time: 0 ms";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblName.Location = new System.Drawing.Point(76, 418);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(0, 21);
            this.lblName.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(18, 418);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "Name:";
            // 
            // picRecognizeFace
            // 
            this.picRecognizeFace.Location = new System.Drawing.Point(18, 232);
            this.picRecognizeFace.Name = "picRecognizeFace";
            this.picRecognizeFace.Size = new System.Drawing.Size(218, 179);
            this.picRecognizeFace.TabIndex = 5;
            this.picRecognizeFace.TabStop = false;
            // 
            // BtnRecoginze
            // 
            this.BtnRecoginze.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnRecoginze.Location = new System.Drawing.Point(18, 179);
            this.BtnRecoginze.Name = "BtnRecoginze";
            this.BtnRecoginze.Size = new System.Drawing.Size(218, 35);
            this.BtnRecoginze.TabIndex = 4;
            this.BtnRecoginze.Text = "Recognize";
            this.BtnRecoginze.UseVisualStyleBackColor = true;
            this.BtnRecoginze.Click += new System.EventHandler(this.BtnRecoginze_Click);
            // 
            // TxtName
            // 
            this.TxtName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtName.Location = new System.Drawing.Point(18, 100);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(218, 29);
            this.TxtName.TabIndex = 3;
            // 
            // BtnAddFace
            // 
            this.BtnAddFace.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnAddFace.Location = new System.Drawing.Point(18, 138);
            this.BtnAddFace.Name = "BtnAddFace";
            this.BtnAddFace.Size = new System.Drawing.Size(218, 35);
            this.BtnAddFace.TabIndex = 2;
            this.BtnAddFace.Text = "Add Face";
            this.BtnAddFace.UseVisualStyleBackColor = true;
            this.BtnAddFace.Click += new System.EventHandler(this.BtnAddFace_Click);
            // 
            // BtnDetectFace
            // 
            this.BtnDetectFace.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnDetectFace.Location = new System.Drawing.Point(18, 56);
            this.BtnDetectFace.Name = "BtnDetectFace";
            this.BtnDetectFace.Size = new System.Drawing.Size(218, 35);
            this.BtnDetectFace.TabIndex = 1;
            this.BtnDetectFace.Text = "Detect Face";
            this.BtnDetectFace.UseVisualStyleBackColor = true;
            this.BtnDetectFace.Click += new System.EventHandler(this.BtnDetectFace_Click);
            // 
            // BtnCapture
            // 
            this.BtnCapture.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnCapture.Location = new System.Drawing.Point(18, 12);
            this.BtnCapture.Name = "BtnCapture";
            this.BtnCapture.Size = new System.Drawing.Size(218, 35);
            this.BtnCapture.TabIndex = 0;
            this.BtnCapture.Text = "Capture";
            this.BtnCapture.UseVisualStyleBackColor = true;
            this.BtnCapture.Click += new System.EventHandler(this.BtnCapture_Click);
            // 
            // BtnUpload
            // 
            this.BtnUpload.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnUpload.Location = new System.Drawing.Point(18, 489);
            this.BtnUpload.Name = "BtnUpload";
            this.BtnUpload.Size = new System.Drawing.Size(218, 35);
            this.BtnUpload.TabIndex = 10;
            this.BtnUpload.Text = "Upload";
            this.BtnUpload.UseVisualStyleBackColor = true;
            this.BtnUpload.Click += new System.EventHandler(this.BtnUpload_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1239, 798);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picCapture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRecognizeFace)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PictureBox picCapture;
        private System.Windows.Forms.Button BtnCapture;
        private System.Windows.Forms.Button BtnDetectFace;
        private System.Windows.Forms.Button BtnAddFace;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Button BtnRecoginze;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picRecognizeFace;
        private System.Windows.Forms.Label totalTime;
        private System.Windows.Forms.Button BtnReset;
        private System.Windows.Forms.Button BtnUpload;
    }
}

