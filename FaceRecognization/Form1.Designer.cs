
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnCapture = new System.Windows.Forms.Button();
            this.BtnDetectFaces = new System.Windows.Forms.Button();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.BtnAddPerson = new System.Windows.Forms.Button();
            this.BtnTrainImages = new System.Windows.Forms.Button();
            this.BtnRecognizePersons = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(629, 426);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // BtnCapture
            // 
            this.BtnCapture.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnCapture.Location = new System.Drawing.Point(647, 12);
            this.BtnCapture.Name = "BtnCapture";
            this.BtnCapture.Size = new System.Drawing.Size(141, 35);
            this.BtnCapture.TabIndex = 1;
            this.BtnCapture.Text = "Capture";
            this.BtnCapture.UseVisualStyleBackColor = true;
            // 
            // BtnDetectFaces
            // 
            this.BtnDetectFaces.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnDetectFaces.Location = new System.Drawing.Point(647, 51);
            this.BtnDetectFaces.Name = "BtnDetectFaces";
            this.BtnDetectFaces.Size = new System.Drawing.Size(141, 35);
            this.BtnDetectFaces.TabIndex = 2;
            this.BtnDetectFaces.Text = "Detect Faces";
            this.BtnDetectFaces.UseVisualStyleBackColor = true;
            // 
            // TxtName
            // 
            this.TxtName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtName.Location = new System.Drawing.Point(647, 90);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(141, 29);
            this.TxtName.TabIndex = 3;
            // 
            // BtnAddPerson
            // 
            this.BtnAddPerson.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnAddPerson.Location = new System.Drawing.Point(647, 123);
            this.BtnAddPerson.Name = "BtnAddPerson";
            this.BtnAddPerson.Size = new System.Drawing.Size(141, 35);
            this.BtnAddPerson.TabIndex = 4;
            this.BtnAddPerson.Text = "Add Person";
            this.BtnAddPerson.UseVisualStyleBackColor = true;
            // 
            // BtnTrainImages
            // 
            this.BtnTrainImages.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnTrainImages.Location = new System.Drawing.Point(647, 162);
            this.BtnTrainImages.Name = "BtnTrainImages";
            this.BtnTrainImages.Size = new System.Drawing.Size(141, 35);
            this.BtnTrainImages.TabIndex = 5;
            this.BtnTrainImages.Text = "Train Images";
            this.BtnTrainImages.UseVisualStyleBackColor = true;
            // 
            // BtnRecognizePersons
            // 
            this.BtnRecognizePersons.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnRecognizePersons.Location = new System.Drawing.Point(647, 201);
            this.BtnRecognizePersons.Name = "BtnRecognizePersons";
            this.BtnRecognizePersons.Size = new System.Drawing.Size(141, 35);
            this.BtnRecognizePersons.TabIndex = 6;
            this.BtnRecognizePersons.Text = "Recongize";
            this.BtnRecognizePersons.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnRecognizePersons);
            this.Controls.Add(this.BtnTrainImages);
            this.Controls.Add(this.BtnAddPerson);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.BtnDetectFaces);
            this.Controls.Add(this.BtnCapture);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnCapture;
        private System.Windows.Forms.Button BtnDetectFaces;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Button BtnAddPerson;
        private System.Windows.Forms.Button BtnTrainImages;
        private System.Windows.Forms.Button BtnRecognizePersons;
    }
}

