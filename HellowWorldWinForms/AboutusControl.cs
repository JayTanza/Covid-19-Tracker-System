using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HellowWorldWinForms
{
    public partial class AboutusControl : UserControl
    {
        public AboutusControl()
        {
            InitializeComponent();
        }
         int count = 0;
        //private void LoadNextImage()
        //{
        //    if (imageno == 3)
        //    { 
        //        imageno = 1;
        //    }
        //    pictureBox1.ImageLocation = String.Format(@"Images\{0}.jpg", imageno);
        //    imageno++;
        //}
        private void AboutusControl_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ////LoadNextImage();
            //if (count < 5)
            //{
            //    pictureBox1.Image = imageList1.Images[count];
            //    count++;
            //}
            //else
            //{
            //    count = 0; yeahh
            //}
        }
        int xcount = -1;
        private void button1_Click(object sender, EventArgs e)
        {
            if (xcount < 8)
            {
                xcount++;
            }

            pictureBox1.Image = imageList1.Images[xcount];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (xcount > 0)
            {
                xcount--;
            }

            pictureBox1.Image = imageList1.Images[xcount];
        }
    }
}
