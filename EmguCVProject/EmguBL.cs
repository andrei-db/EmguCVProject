using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Emgu.CV.UI;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmguCVProject
{
    
    internal class EmguBL
    {
       
        int TotalFrame, FrameNo;
        double Fps;
        bool IsReadingFrame;
        VideoCapture capture;
        Image<Bgr, Byte> My_Image;
        Rectangle rect;
        Point StartROI;
        bool MouseDown;
        public void OpenImage(PictureBox imageArea,PictureBox pictureBoxROI) {
            OpenFileDialog Openfile = new OpenFileDialog();
            if (Openfile.ShowDialog() == DialogResult.OK)
            {
                My_Image = new Image<Bgr, byte>(Openfile.FileName);
                imageArea.Image = My_Image.ToBitmap();

            }
            pictureBoxROI.Image = imageArea.Image;

        }
        public void ConvertToGrayScale(PictureBox grayImageArea) {
            Image<Gray, byte> gray_image = My_Image.Convert<Gray, byte>();
            grayImageArea.Image = gray_image.AsBitmap();
            gray_image[0, 0] = new Gray(200);
        }
        public void Contrast(PictureBox contrastArea,TextBox alphaTB,TextBox betaTB) {
            double alpha = Convert.ToDouble(alphaTB.Text);
            int beta = Convert.ToInt32(betaTB.Text);
            contrastArea.Image = My_Image.Mul(alpha + beta).AsBitmap();
        }
        public void Histograma() {
            HistogramViewer v = new HistogramViewer();
            v.HistogramCtrl.GenerateHistograms(My_Image, 255);
            v.Show();
        }
        public void RedScale(PictureBox redArea) {
            Image<Bgr, Byte> outputImage = new Image<Bgr, byte>(My_Image.Size);
            My_Image.CopyTo(outputImage);
            var data = outputImage.Data;
            for (int i = 0; i < outputImage.Width; i++)
            {
                for (int j = 0; j < outputImage.Height; j++)
                {
                    data[j, i, 0] = 0;
                    data[j, i, 1] = 0;
                }
            }
            redArea.Image = outputImage.AsBitmap();
        }
        public void GammaCorection(PictureBox gammaArea,TextBox gammaTB) {
            My_Image._GammaCorrect(Convert.ToDouble(gammaTB.Text));
            gammaArea.Image = My_Image.AsBitmap();
        }
        public void ScaleImage(PictureBox scaleArea) {
            float timesZoom = 0.7F;
            scaleArea.Image = My_Image.Resize(timesZoom, Emgu.CV.CvEnum.Inter.Cubic).AsBitmap();
        }
        public void RotateImage(PictureBox rotateArea) {
            float angle = 45.0F;
            Bgr sall = new Bgr();
            rotateArea.Image = My_Image.Rotate(angle, sall, true).AsBitmap();

        }
        public void MouseMoveROI(PictureBox pictureBoxROI, MouseEventArgs e)
        {
            if (pictureBoxROI.Image == null)
            {
                return;
            }

            int width = Math.Max(StartROI.X, e.X) - Math.Min(StartROI.X, e.X);
            int height = Math.Max(StartROI.Y, e.Y) - Math.Min(StartROI.Y, e.Y);
            rect = new Rectangle(Math.Min(StartROI.X, e.X),
                Math.Min(StartROI.Y, e.Y),
                width,
                height);

        }
        public void MouseDownROI(MouseEventArgs e)
        {
            MouseDown = true;
            StartROI = e.Location;
        }
        public void PaintROI(PaintEventArgs e)
        {
            if (MouseDown)
            {
                using (Pen pen = new Pen(Color.Red, 1))
                {
                    e.Graphics.DrawRectangle(pen, rect);
                }
            }
        }
        public void MouseUpROI(PictureBox pictureBoxROI, MouseEventArgs e)
        {
            MouseDown = false;
            if (pictureBoxROI.Image == null || rect == Rectangle.Empty)
            { return; }

            var img = new Bitmap(pictureBoxROI.Image).ToImage<Bgr, byte>();
            img.ROI = rect;
            var imgROI = img.Copy();

            pictureBoxROI.Image = imgROI.ToBitmap();
        }
        public void LoadEvent(PictureBox videoArea,TrackBar trackBar) {

            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                capture = new VideoCapture(ofd.FileName);
                Mat m = new Mat();
                capture.Read(m);
                videoArea.Image = m.ToBitmap();

                TotalFrame = (int)capture.Get(CapProp.FrameCount);
                Fps = capture.Get(CapProp.Fps);
                FrameNo = 1;
                trackBar.Value = FrameNo;
                trackBar.Minimum = 0;
                trackBar.Maximum = TotalFrame;

            }
        }
        public void PlayEvent(PictureBox videoArea, Label fpsLabel) {
            if (capture == null)
            {
                return;
            }
            IsReadingFrame = true;
            ReadAllFrames(videoArea,fpsLabel);
        }
        private async void ReadAllFrames(PictureBox videoArea, Label fpsLabel)
        {

            Mat m = new Mat();
            while (IsReadingFrame == true && FrameNo < TotalFrame)
            {
                FrameNo += 1;
                var mat = capture.QueryFrame();
                videoArea.Image = mat.ToBitmap();
                await Task.Delay(1000 / Convert.ToInt16(Fps));
                fpsLabel.Text = FrameNo.ToString() + "/" + TotalFrame.ToString();
            }
        }

    }
}
