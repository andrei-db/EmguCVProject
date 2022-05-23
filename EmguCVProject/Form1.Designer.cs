
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
            this.contrastArea = new System.Windows.Forms.PictureBox();
            this.contrastBtn = new System.Windows.Forms.Button();
            this.alphaTB = new System.Windows.Forms.TextBox();
            this.betaTB = new System.Windows.Forms.TextBox();
            this.histogramBtn = new System.Windows.Forms.Button();
            this.redBtn = new System.Windows.Forms.Button();
            this.redArea = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imageArea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grayImageArea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contrastArea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redArea)).BeginInit();
            this.SuspendLayout();
            // 
            // openImageBtn
            // 
            this.openImageBtn.Location = new System.Drawing.Point(116, 311);
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
            this.imageArea.Size = new System.Drawing.Size(201, 129);
            this.imageArea.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageArea.TabIndex = 1;
            this.imageArea.TabStop = false;
            // 
            // grayImageBtn
            // 
            this.grayImageBtn.Location = new System.Drawing.Point(402, 311);
            this.grayImageBtn.Name = "grayImageBtn";
            this.grayImageBtn.Size = new System.Drawing.Size(75, 23);
            this.grayImageBtn.TabIndex = 2;
            this.grayImageBtn.Text = "Make it gray";
            this.grayImageBtn.UseVisualStyleBackColor = true;
            this.grayImageBtn.Click += new System.EventHandler(this.grayImageBtn_Click);
            // 
            // grayImageArea
            // 
            this.grayImageArea.Location = new System.Drawing.Point(360, 158);
            this.grayImageArea.Name = "grayImageArea";
            this.grayImageArea.Size = new System.Drawing.Size(158, 129);
            this.grayImageArea.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.grayImageArea.TabIndex = 3;
            this.grayImageArea.TabStop = false;
            // 
            // contrastArea
            // 
            this.contrastArea.Location = new System.Drawing.Point(641, 158);
            this.contrastArea.Name = "contrastArea";
            this.contrastArea.Size = new System.Drawing.Size(159, 129);
            this.contrastArea.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.contrastArea.TabIndex = 4;
            this.contrastArea.TabStop = false;
            // 
            // contrastBtn
            // 
            this.contrastBtn.Location = new System.Drawing.Point(689, 311);
            this.contrastBtn.Name = "contrastBtn";
            this.contrastBtn.Size = new System.Drawing.Size(75, 23);
            this.contrastBtn.TabIndex = 5;
            this.contrastBtn.Text = "Contrast";
            this.contrastBtn.UseVisualStyleBackColor = true;
            this.contrastBtn.Click += new System.EventHandler(this.contrastBtn_Click);
            // 
            // alphaTB
            // 
            this.alphaTB.Location = new System.Drawing.Point(664, 51);
            this.alphaTB.Name = "alphaTB";
            this.alphaTB.Size = new System.Drawing.Size(100, 20);
            this.alphaTB.TabIndex = 6;
            // 
            // betaTB
            // 
            this.betaTB.Location = new System.Drawing.Point(664, 90);
            this.betaTB.Name = "betaTB";
            this.betaTB.Size = new System.Drawing.Size(100, 20);
            this.betaTB.TabIndex = 7;
            // 
            // histogramBtn
            // 
            this.histogramBtn.Location = new System.Drawing.Point(99, 583);
            this.histogramBtn.Name = "histogramBtn";
            this.histogramBtn.Size = new System.Drawing.Size(75, 23);
            this.histogramBtn.TabIndex = 8;
            this.histogramBtn.Text = "Histogram";
            this.histogramBtn.UseVisualStyleBackColor = true;
            this.histogramBtn.Click += new System.EventHandler(this.histogramBtn_Click);
            // 
            // redBtn
            // 
            this.redBtn.Location = new System.Drawing.Point(360, 583);
            this.redBtn.Name = "redBtn";
            this.redBtn.Size = new System.Drawing.Size(94, 23);
            this.redBtn.TabIndex = 9;
            this.redBtn.Text = "Red channel";
            this.redBtn.UseVisualStyleBackColor = true;
            this.redBtn.Click += new System.EventHandler(this.redBtn_Click);
            // 
            // redArea
            // 
            this.redArea.Location = new System.Drawing.Point(326, 421);
            this.redArea.Name = "redArea";
            this.redArea.Size = new System.Drawing.Size(151, 118);
            this.redArea.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.redArea.TabIndex = 10;
            this.redArea.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 651);
            this.Controls.Add(this.redArea);
            this.Controls.Add(this.redBtn);
            this.Controls.Add(this.histogramBtn);
            this.Controls.Add(this.betaTB);
            this.Controls.Add(this.alphaTB);
            this.Controls.Add(this.contrastBtn);
            this.Controls.Add(this.contrastArea);
            this.Controls.Add(this.grayImageArea);
            this.Controls.Add(this.grayImageBtn);
            this.Controls.Add(this.imageArea);
            this.Controls.Add(this.openImageBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.imageArea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grayImageArea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contrastArea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redArea)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button openImageBtn;
        private System.Windows.Forms.PictureBox imageArea;
        private System.Windows.Forms.Button grayImageBtn;
        private System.Windows.Forms.PictureBox grayImageArea;
        private System.Windows.Forms.PictureBox contrastArea;
        private System.Windows.Forms.Button contrastBtn;
        private System.Windows.Forms.TextBox alphaTB;
        private System.Windows.Forms.TextBox betaTB;
        private System.Windows.Forms.Button histogramBtn;
        private System.Windows.Forms.Button redBtn;
        private System.Windows.Forms.PictureBox redArea;
    }
}

