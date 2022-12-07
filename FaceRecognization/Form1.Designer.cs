
namespace FaceRecognization
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
            this.picCapture = new System.Windows.Forms.PictureBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.picFace = new System.Windows.Forms.PictureBox();
            this.BtnReset = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.neighbors = new System.Windows.Forms.NumericUpDown();
            this.scaleFactor = new System.Windows.Forms.NumericUpDown();
            this.BtnRecognizePersons = new System.Windows.Forms.Button();
            this.BtnTrainImages = new System.Windows.Forms.Button();
            this.BtnAddPerson = new System.Windows.Forms.Button();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.BtnDetectFaces = new System.Windows.Forms.Button();
            this.BtnCapture = new System.Windows.Forms.Button();
            this.totalTime = new System.Windows.Forms.Label();
            this.drawingTime = new System.Windows.Forms.Label();
            this.detectionTime = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picCapture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.neighbors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scaleFactor)).BeginInit();
            this.SuspendLayout();
            // 
            // picCapture
            // 
            this.picCapture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picCapture.Location = new System.Drawing.Point(0, 0);
            this.picCapture.Name = "picCapture";
            this.picCapture.Size = new System.Drawing.Size(937, 727);
            this.picCapture.TabIndex = 0;
            this.picCapture.TabStop = false;
            // 
            // splitContainer1
            // 
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
            this.splitContainer1.Panel2.Controls.Add(this.picFace);
            this.splitContainer1.Panel2.Controls.Add(this.BtnReset);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.neighbors);
            this.splitContainer1.Panel2.Controls.Add(this.scaleFactor);
            this.splitContainer1.Panel2.Controls.Add(this.BtnRecognizePersons);
            this.splitContainer1.Panel2.Controls.Add(this.BtnTrainImages);
            this.splitContainer1.Panel2.Controls.Add(this.BtnAddPerson);
            this.splitContainer1.Panel2.Controls.Add(this.TxtName);
            this.splitContainer1.Panel2.Controls.Add(this.BtnDetectFaces);
            this.splitContainer1.Panel2.Controls.Add(this.BtnCapture);
            this.splitContainer1.Panel2.Controls.Add(this.totalTime);
            this.splitContainer1.Panel2.Controls.Add(this.drawingTime);
            this.splitContainer1.Panel2.Controls.Add(this.detectionTime);
            this.splitContainer1.Size = new System.Drawing.Size(1152, 727);
            this.splitContainer1.SplitterDistance = 937;
            this.splitContainer1.TabIndex = 12;
            // 
            // picFace
            // 
            this.picFace.Location = new System.Drawing.Point(22, 328);
            this.picFace.Name = "picFace";
            this.picFace.Size = new System.Drawing.Size(177, 142);
            this.picFace.TabIndex = 26;
            this.picFace.TabStop = false;
            // 
            // BtnReset
            // 
            this.BtnReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnReset.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.BtnReset.Location = new System.Drawing.Point(22, 686);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(176, 30);
            this.BtnReset.TabIndex = 22;
            this.BtnReset.Text = "Reset";
            this.BtnReset.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(23, 653);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "Neighbors";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(23, 621);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "Scale";
            // 
            // neighbors
            // 
            this.neighbors.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.neighbors.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.neighbors.Location = new System.Drawing.Point(135, 650);
            this.neighbors.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.neighbors.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.neighbors.Name = "neighbors";
            this.neighbors.Size = new System.Drawing.Size(63, 26);
            this.neighbors.TabIndex = 19;
            this.neighbors.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.neighbors.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // scaleFactor
            // 
            this.scaleFactor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.scaleFactor.DecimalPlaces = 1;
            this.scaleFactor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.scaleFactor.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.scaleFactor.Location = new System.Drawing.Point(135, 618);
            this.scaleFactor.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            65536});
            this.scaleFactor.Minimum = new decimal(new int[] {
            11,
            0,
            0,
            65536});
            this.scaleFactor.Name = "scaleFactor";
            this.scaleFactor.Size = new System.Drawing.Size(63, 26);
            this.scaleFactor.TabIndex = 18;
            this.scaleFactor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.scaleFactor.Value = new decimal(new int[] {
            11,
            0,
            0,
            65536});
            // 
            // BtnRecognizePersons
            // 
            this.BtnRecognizePersons.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.BtnRecognizePersons.Location = new System.Drawing.Point(22, 196);
            this.BtnRecognizePersons.Name = "BtnRecognizePersons";
            this.BtnRecognizePersons.Size = new System.Drawing.Size(177, 30);
            this.BtnRecognizePersons.TabIndex = 17;
            this.BtnRecognizePersons.Text = "Recongize";
            this.BtnRecognizePersons.UseVisualStyleBackColor = true;
            // 
            // BtnTrainImages
            // 
            this.BtnTrainImages.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.BtnTrainImages.Location = new System.Drawing.Point(22, 159);
            this.BtnTrainImages.Name = "BtnTrainImages";
            this.BtnTrainImages.Size = new System.Drawing.Size(177, 30);
            this.BtnTrainImages.TabIndex = 16;
            this.BtnTrainImages.Text = "Train Images";
            this.BtnTrainImages.UseVisualStyleBackColor = true;
            this.BtnTrainImages.Click += new System.EventHandler(this.BtnTrainImages_Click);
            // 
            // BtnAddPerson
            // 
            this.BtnAddPerson.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.BtnAddPerson.Location = new System.Drawing.Point(22, 122);
            this.BtnAddPerson.Name = "BtnAddPerson";
            this.BtnAddPerson.Size = new System.Drawing.Size(177, 30);
            this.BtnAddPerson.TabIndex = 15;
            this.BtnAddPerson.Text = "Add Person";
            this.BtnAddPerson.UseVisualStyleBackColor = true;
            this.BtnAddPerson.Click += new System.EventHandler(this.BtnAddPerson_Click);
            // 
            // TxtName
            // 
            this.TxtName.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.TxtName.Location = new System.Drawing.Point(22, 86);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(177, 29);
            this.TxtName.TabIndex = 14;
            // 
            // BtnDetectFaces
            // 
            this.BtnDetectFaces.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.BtnDetectFaces.Location = new System.Drawing.Point(22, 49);
            this.BtnDetectFaces.Name = "BtnDetectFaces";
            this.BtnDetectFaces.Size = new System.Drawing.Size(177, 30);
            this.BtnDetectFaces.TabIndex = 13;
            this.BtnDetectFaces.Text = "Detect Faces";
            this.BtnDetectFaces.UseVisualStyleBackColor = true;
            this.BtnDetectFaces.Click += new System.EventHandler(this.BtnDetectFaces_Click);
            // 
            // BtnCapture
            // 
            this.BtnCapture.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.BtnCapture.Location = new System.Drawing.Point(22, 12);
            this.BtnCapture.Name = "BtnCapture";
            this.BtnCapture.Size = new System.Drawing.Size(177, 30);
            this.BtnCapture.TabIndex = 12;
            this.BtnCapture.Text = "Capture";
            this.BtnCapture.UseVisualStyleBackColor = true;
            this.BtnCapture.Click += new System.EventHandler(this.BtnCapture_Click);
            // 
            // totalTime
            // 
            this.totalTime.AutoSize = true;
            this.totalTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.totalTime.Location = new System.Drawing.Point(23, 237);
            this.totalTime.Name = "totalTime";
            this.totalTime.Size = new System.Drawing.Size(120, 20);
            this.totalTime.TabIndex = 25;
            this.totalTime.Text = "Total time: 0 ms";
            // 
            // drawingTime
            // 
            this.drawingTime.AutoSize = true;
            this.drawingTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.drawingTime.Location = new System.Drawing.Point(23, 293);
            this.drawingTime.Name = "drawingTime";
            this.drawingTime.Size = new System.Drawing.Size(109, 20);
            this.drawingTime.TabIndex = 24;
            this.drawingTime.Text = "Drawing: 0 ms";
            // 
            // detectionTime
            // 
            this.detectionTime.AutoSize = true;
            this.detectionTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.detectionTime.Location = new System.Drawing.Point(23, 265);
            this.detectionTime.Name = "detectionTime";
            this.detectionTime.Size = new System.Drawing.Size(120, 20);
            this.detectionTime.TabIndex = 23;
            this.detectionTime.Text = "Detection: 0 ms";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1152, 727);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Faec Recognization";
            ((System.ComponentModel.ISupportInitialize)(this.picCapture)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picFace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.neighbors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scaleFactor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picCapture;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button BtnReset;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown neighbors;
        private System.Windows.Forms.NumericUpDown scaleFactor;
        private System.Windows.Forms.Button BtnRecognizePersons;
        private System.Windows.Forms.Button BtnTrainImages;
        private System.Windows.Forms.Button BtnAddPerson;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Button BtnDetectFaces;
        private System.Windows.Forms.Button BtnCapture;
        private System.Windows.Forms.Label totalTime;
        private System.Windows.Forms.Label drawingTime;
        private System.Windows.Forms.Label detectionTime;
        private System.Windows.Forms.PictureBox picFace;
    }
}

