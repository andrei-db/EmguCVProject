using Emgu.CV;
using Emgu.CV.Structure;
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
    }
}
