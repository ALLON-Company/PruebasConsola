using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mandelbrot
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MandelbrotSet();
        }

        private void MandelbrotSet()
        {
            int width = pictureBox1.Width;
            int heigh = pictureBox1.Height;

            for (int row = 0; row<heigh;row++)
            {
                for (int col =0; col<width;col++)
                {
                    double C_re = (col - width / 2.0) * 4.0 / width;
                }
            }


        }


    }
}
