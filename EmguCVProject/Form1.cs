using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Emgu.CV.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmguCVProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        Image<Bgr, Byte> My_Image;
        private void openImageBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog Openfile = new OpenFileDialog();
            if (Openfile.ShowDialog() == DialogResult.OK)
            {
                My_Image = new Image<Bgr, byte>(Openfile.FileName);
                imageArea.Image = My_Image.ToBitmap();

            }
            pictureBoxROI.Image = imageArea.Image;
        }

        private void grayImageBtn_Click(object sender, EventArgs e)
        {
            Image<Gray, byte> gray_image = My_Image.Convert<Gray, byte>();
            grayImageArea.Image = gray_image.AsBitmap();
            gray_image[0, 0] = new Gray(200);

        }
        private void contrastBtn_Click(object sender, EventArgs e)
        {
            double alpha = Convert.ToDouble(alphaTB.Text);
            int beta = Convert.ToInt32(betaTB.Text);

            contrastArea.Image = My_Image.Mul(alpha + beta).AsBitmap();
        }


        private void histogramBtn_Click(object sender, EventArgs e)
        {
            HistogramViewer v = new HistogramViewer();
            v.HistogramCtrl.GenerateHistograms(My_Image, 255);
            v.Show();
        }

        private void redBtn_Click(object sender, EventArgs e)
        {
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

        private void gammaBtn_Click(object sender, EventArgs e)
        {
            My_Image._GammaCorrect(Convert.ToDouble(gammaTB.Text));
            gammaArea.Image = My_Image.AsBitmap();
        }

        private void scaleBtn_Click(object sender, EventArgs e)
        {
            float timesZoom = 0.7F;
            scaleArea.Image = My_Image.Resize(timesZoom, Emgu.CV.CvEnum.Inter.Cubic).AsBitmap();
        }

        private void rotateBtn_Click(object sender, EventArgs e)
        {
            float angle = 45.0F;
            Bgr sall = new Bgr();
            rotateArea.Image = My_Image.Rotate(angle, sall, true).AsBitmap();
        }
        Rectangle rect; Point StartROI; bool MouseDown;

        private void pictureBoxROI_MouseMove(object sender, MouseEventArgs e)
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
            Refresh();

        }

        private void pictureBoxROI_MouseDown(object sender, MouseEventArgs e)
        {
            MouseDown = true;
            StartROI = e.Location;
        }

        private void pictureBoxROI_Paint(object sender, PaintEventArgs e)
        {
            if (MouseDown)
            {
                using (Pen pen = new Pen(Color.Red, 1))
                {
                    e.Graphics.DrawRectangle(pen, rect);
                }
            }

        }

        private void pictureBoxROI_MouseUp(object sender, MouseEventArgs e)
        {
            MouseDown = false;
            if (pictureBoxROI.Image == null || rect == Rectangle.Empty)
            { return; }

            var img = new Bitmap(pictureBoxROI.Image).ToImage<Bgr, byte>();
            img.ROI = rect;
            var imgROI = img.Copy();

            pictureBoxROI.Image = imgROI.ToBitmap();
        }

        int TotalFrame, FrameNo;
        double Fps;
        bool IsReadingFrame;
        VideoCapture capture;

        private void loadEvent_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                capture = new VideoCapture(ofd.FileName);
                Mat m = new Mat();
                capture.Read(m);
                pictureBox1.Image = m.ToBitmap();

                TotalFrame = (int)capture.Get(CapProp.FrameCount);
                Fps = capture.Get(CapProp.Fps);
                FrameNo = 1;
                trackBar.Value = FrameNo;
                trackBar.Minimum = 0;
                trackBar.Maximum = TotalFrame;

            }

        }

        private void playEvent_Click(object sender, EventArgs e)
        {
            if (capture == null)
            {
                return;
            }
            IsReadingFrame = true;
            ReadAllFrames();
        }

        private async void ReadAllFrames()
        {

            Mat m = new Mat();
            while (IsReadingFrame == true && FrameNo < TotalFrame)
            {
                FrameNo += 1;
                var mat = capture.QueryFrame();
                pictureBox1.Image = mat.ToBitmap();
                await Task.Delay(1000 / Convert.ToInt16(Fps));
                fpsLabel.Text = FrameNo.ToString() + "/" + TotalFrame.ToString();
            }
        }





    }
}
