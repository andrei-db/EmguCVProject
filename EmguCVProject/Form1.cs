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
        EmguBL emguBL=new EmguBL();
        public Form1()
        {
            InitializeComponent();

        }
        
        private void openImageBtn_Click(object sender, EventArgs e)
        {
            emguBL.OpenImage(imageArea,pictureBoxROI);   
        }

        private void grayImageBtn_Click(object sender, EventArgs e)
        {
            emguBL.ConvertToGrayScale(grayImageArea);

        }
        private void contrastBtn_Click(object sender, EventArgs e)
        {
            emguBL.Contrast(contrastArea,alphaTB,betaTB);
        }


        private void histogramBtn_Click(object sender, EventArgs e)
        {
            emguBL.Histograma();
            
        }

        private void redBtn_Click(object sender, EventArgs e)
        {
            emguBL.RedScale(redArea);

        }

        private void gammaBtn_Click(object sender, EventArgs e)
        {
            emguBL.GammaCorection(gammaArea,gammaTB);
        }

        private void scaleBtn_Click(object sender, EventArgs e)
        {
            emguBL.ScaleImage(scaleArea);
        }

        private void rotateBtn_Click(object sender, EventArgs e)
        {
            emguBL.ScaleImage(scaleArea);
            
        }          

        private void pictureBoxROI_MouseMove(object sender, MouseEventArgs e)
        {
            emguBL.MouseMoveROI(pictureBoxROI,e);
            Refresh();
        }

        private void pictureBoxROI_MouseDown(object sender, MouseEventArgs e)
        {
            emguBL.MouseDownROI(e);
        }

        private void pictureBoxROI_Paint(object sender, PaintEventArgs e)
        {
            emguBL.PaintROI(e);

        }

        private void pictureBoxROI_MouseUp(object sender, MouseEventArgs e)
        {
            emguBL.MouseUpROI(pictureBoxROI,e);
        }

        

        private void loadEvent_Click(object sender, EventArgs e)
        {
            emguBL.LoadEvent(videoArea,trackBar);

        }

        private void playEvent_Click(object sender, EventArgs e)
        {
            emguBL.PlayEvent(videoArea,fpsLabel);
        }

    }
}
