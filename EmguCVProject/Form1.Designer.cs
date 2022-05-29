
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
            this.gammaBtn = new System.Windows.Forms.Button();
            this.gammaArea = new System.Windows.Forms.PictureBox();
            this.gammaTB = new System.Windows.Forms.TextBox();
            this.scaleArea = new System.Windows.Forms.PictureBox();
            this.scaleBtn = new System.Windows.Forms.Button();
            this.rotateBtn = new System.Windows.Forms.Button();
            this.rotateArea = new System.Windows.Forms.PictureBox();
            this.pictureBoxROI = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imageArea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grayImageArea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contrastArea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redArea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gammaArea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scaleArea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotateArea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxROI)).BeginInit();
            this.SuspendLayout();
            // 
            // openImageBtn
            // 
            this.openImageBtn.Location = new System.Drawing.Point(12, 239);
            this.openImageBtn.Name = "openImageBtn";
            this.openImageBtn.Size = new System.Drawing.Size(106, 23);
            this.openImageBtn.TabIndex = 0;
            this.openImageBtn.Text = "Choose an image";
            this.openImageBtn.UseVisualStyleBackColor = true;
            this.openImageBtn.Click += new System.EventHandler(this.openImageBtn_Click);
            // 
            // imageArea
            // 
            this.imageArea.Location = new System.Drawing.Point(3, 90);
            this.imageArea.Name = "imageArea";
            this.imageArea.Size = new System.Drawing.Size(145, 129);
            this.imageArea.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageArea.TabIndex = 1;
            this.imageArea.TabStop = false;
            // 
            // grayImageBtn
            // 
            this.grayImageBtn.Location = new System.Drawing.Point(219, 239);
            this.grayImageBtn.Name = "grayImageBtn";
            this.grayImageBtn.Size = new System.Drawing.Size(75, 23);
            this.grayImageBtn.TabIndex = 2;
            this.grayImageBtn.Text = "Make it gray";
            this.grayImageBtn.UseVisualStyleBackColor = true;
            this.grayImageBtn.Click += new System.EventHandler(this.grayImageBtn_Click);
            // 
            // grayImageArea
            // 
            this.grayImageArea.Location = new System.Drawing.Point(177, 90);
            this.grayImageArea.Name = "grayImageArea";
            this.grayImageArea.Size = new System.Drawing.Size(158, 129);
            this.grayImageArea.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.grayImageArea.TabIndex = 3;
            this.grayImageArea.TabStop = false;
            // 
            // contrastArea
            // 
            this.contrastArea.Location = new System.Drawing.Point(360, 90);
            this.contrastArea.Name = "contrastArea";
            this.contrastArea.Size = new System.Drawing.Size(159, 129);
            this.contrastArea.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.contrastArea.TabIndex = 4;
            this.contrastArea.TabStop = false;
            // 
            // contrastBtn
            // 
            this.contrastBtn.Location = new System.Drawing.Point(402, 239);
            this.contrastBtn.Name = "contrastBtn";
            this.contrastBtn.Size = new System.Drawing.Size(75, 23);
            this.contrastBtn.TabIndex = 5;
            this.contrastBtn.Text = "Contrast";
            this.contrastBtn.UseVisualStyleBackColor = true;
            this.contrastBtn.Click += new System.EventHandler(this.contrastBtn_Click);
            // 
            // alphaTB
            // 
            this.alphaTB.Location = new System.Drawing.Point(402, 12);
            this.alphaTB.Name = "alphaTB";
            this.alphaTB.Size = new System.Drawing.Size(100, 20);
            this.alphaTB.TabIndex = 6;
            // 
            // betaTB
            // 
            this.betaTB.Location = new System.Drawing.Point(402, 38);
            this.betaTB.Name = "betaTB";
            this.betaTB.Size = new System.Drawing.Size(100, 20);
            this.betaTB.TabIndex = 7;
            // 
            // histogramBtn
            // 
            this.histogramBtn.Location = new System.Drawing.Point(12, 12);
            this.histogramBtn.Name = "histogramBtn";
            this.histogramBtn.Size = new System.Drawing.Size(75, 23);
            this.histogramBtn.TabIndex = 8;
            this.histogramBtn.Text = "Histogram";
            this.histogramBtn.UseVisualStyleBackColor = true;
            this.histogramBtn.Click += new System.EventHandler(this.histogramBtn_Click);
            // 
            // redBtn
            // 
            this.redBtn.Location = new System.Drawing.Point(572, 239);
            this.redBtn.Name = "redBtn";
            this.redBtn.Size = new System.Drawing.Size(94, 23);
            this.redBtn.TabIndex = 9;
            this.redBtn.Text = "Red channel";
            this.redBtn.UseVisualStyleBackColor = true;
            this.redBtn.Click += new System.EventHandler(this.redBtn_Click);
            // 
            // redArea
            // 
            this.redArea.Location = new System.Drawing.Point(543, 101);
            this.redArea.Name = "redArea";
            this.redArea.Size = new System.Drawing.Size(151, 118);
            this.redArea.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.redArea.TabIndex = 10;
            this.redArea.TabStop = false;
            // 
            // gammaBtn
            // 
            this.gammaBtn.Location = new System.Drawing.Point(735, 239);
            this.gammaBtn.Name = "gammaBtn";
            this.gammaBtn.Size = new System.Drawing.Size(75, 23);
            this.gammaBtn.TabIndex = 11;
            this.gammaBtn.Text = "gamma";
            this.gammaBtn.UseVisualStyleBackColor = true;
            this.gammaBtn.Click += new System.EventHandler(this.gammaBtn_Click);
            // 
            // gammaArea
            // 
            this.gammaArea.Location = new System.Drawing.Point(720, 90);
            this.gammaArea.Name = "gammaArea";
            this.gammaArea.Size = new System.Drawing.Size(130, 129);
            this.gammaArea.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gammaArea.TabIndex = 12;
            this.gammaArea.TabStop = false;
            // 
            // gammaTB
            // 
            this.gammaTB.Location = new System.Drawing.Point(735, 64);
            this.gammaTB.Name = "gammaTB";
            this.gammaTB.Size = new System.Drawing.Size(100, 20);
            this.gammaTB.TabIndex = 13;
            // 
            // scaleArea
            // 
            this.scaleArea.Location = new System.Drawing.Point(36, 342);
            this.scaleArea.Name = "scaleArea";
            this.scaleArea.Size = new System.Drawing.Size(157, 110);
            this.scaleArea.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.scaleArea.TabIndex = 14;
            this.scaleArea.TabStop = false;
            // 
            // scaleBtn
            // 
            this.scaleBtn.Location = new System.Drawing.Point(73, 458);
            this.scaleBtn.Name = "scaleBtn";
            this.scaleBtn.Size = new System.Drawing.Size(75, 23);
            this.scaleBtn.TabIndex = 15;
            this.scaleBtn.Text = "Scale";
            this.scaleBtn.UseVisualStyleBackColor = true;
            this.scaleBtn.Click += new System.EventHandler(this.scaleBtn_Click);
            // 
            // rotateBtn
            // 
            this.rotateBtn.Location = new System.Drawing.Point(247, 458);
            this.rotateBtn.Name = "rotateBtn";
            this.rotateBtn.Size = new System.Drawing.Size(75, 23);
            this.rotateBtn.TabIndex = 16;
            this.rotateBtn.Text = "Rotate";
            this.rotateBtn.UseVisualStyleBackColor = true;
            this.rotateBtn.Click += new System.EventHandler(this.rotateBtn_Click);
            // 
            // rotateArea
            // 
            this.rotateArea.Location = new System.Drawing.Point(219, 342);
            this.rotateArea.Name = "rotateArea";
            this.rotateArea.Size = new System.Drawing.Size(130, 110);
            this.rotateArea.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.rotateArea.TabIndex = 17;
            this.rotateArea.TabStop = false;
            // 
            // pictureBoxROI
            // 
            this.pictureBoxROI.Location = new System.Drawing.Point(414, 342);
            this.pictureBoxROI.Name = "pictureBoxROI";
            this.pictureBoxROI.Size = new System.Drawing.Size(258, 224);
            this.pictureBoxROI.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxROI.TabIndex = 18;
            this.pictureBoxROI.TabStop = false;
            this.pictureBoxROI.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBoxROI_Paint);
            this.pictureBoxROI.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBoxROI_MouseDown);
            this.pictureBoxROI.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBoxROI_MouseMove);
            this.pictureBoxROI.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBoxROI_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 651);
            this.Controls.Add(this.pictureBoxROI);
            this.Controls.Add(this.rotateArea);
            this.Controls.Add(this.rotateBtn);
            this.Controls.Add(this.scaleBtn);
            this.Controls.Add(this.scaleArea);
            this.Controls.Add(this.gammaTB);
            this.Controls.Add(this.gammaArea);
            this.Controls.Add(this.gammaBtn);
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
            ((System.ComponentModel.ISupportInitialize)(this.gammaArea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scaleArea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotateArea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxROI)).EndInit();
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
        private System.Windows.Forms.Button gammaBtn;
        private System.Windows.Forms.PictureBox gammaArea;
        private System.Windows.Forms.TextBox gammaTB;
        private System.Windows.Forms.PictureBox scaleArea;
        private System.Windows.Forms.Button scaleBtn;
        private System.Windows.Forms.Button rotateBtn;
        private System.Windows.Forms.PictureBox rotateArea;
        private System.Windows.Forms.PictureBox pictureBoxROI;
    }
}

