using Emgu.CV;
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

            contrastArea.Image= My_Image.Mul(alpha+beta).AsBitmap();
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
    }
}
