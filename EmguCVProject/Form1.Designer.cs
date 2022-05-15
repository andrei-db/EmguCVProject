
namespace EmguCVProject
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.openImageBtn = new System.Windows.Forms.Button();
            this.imageArea = new System.Windows.Forms.PictureBox();
            this.grayImageBtn = new System.Windows.Forms.Button();
            this.grayImageArea = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imageArea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grayImageArea)).BeginInit();
            this.SuspendLayout();
            // 
            // openImageBtn
            // 
            this.openImageBtn.Location = new System.Drawing.Point(192, 471);
            this.openImageBtn.Name = "openImageBtn";
            this.openImageBtn.Size = new System.Drawing.Size(106, 23);
            this.openImageBtn.TabIndex = 0;
            this.openImageBtn.Text = "Choose an image";
            this.openImageBtn.UseVisualStyleBackColor = true;
            this.openImageBtn.Click += new System.EventHandler(this.openImageBtn_Click);
            // 
            // imageArea
            // 
            this.imageArea.Location = new System.Drawing.Point(74, 158);
            this.imageArea.Name = "imageArea";
            this.imageArea.Size = new System.Drawing.Size(353, 291);
            this.imageArea.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageArea.TabIndex = 1;
            this.imageArea.TabStop = false;
            // 
            // grayImageBtn
            // 
            this.grayImageBtn.Location = new System.Drawing.Point(687, 471);
            this.grayImageBtn.Name = "grayImageBtn";
            this.grayImageBtn.Size = new System.Drawing.Size(75, 23);
            this.grayImageBtn.TabIndex = 2;
            this.grayImageBtn.Text = "Make it gray";
            this.grayImageBtn.UseVisualStyleBackColor = true;
            this.grayImageBtn.Click += new System.EventHandler(this.grayImageBtn_Click);
            // 
            // grayImageArea
            // 
            this.grayImageArea.Location = new System.Drawing.Point(541, 158);
            this.grayImageArea.Name = "grayImageArea";
            this.grayImageArea.Size = new System.Drawing.Size(320, 291);
            this.grayImageArea.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.grayImageArea.TabIndex = 3;
            this.grayImageArea.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 651);
            this.Controls.Add(this.grayImageArea);
            this.Controls.Add(this.grayImageBtn);
            this.Controls.Add(this.imageArea);
            this.Controls.Add(this.openImageBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.imageArea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grayImageArea)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button openImageBtn;
        private System.Windows.Forms.PictureBox imageArea;
        private System.Windows.Forms.Button grayImageBtn;
        private System.Windows.Forms.PictureBox grayImageArea;
    }
}

