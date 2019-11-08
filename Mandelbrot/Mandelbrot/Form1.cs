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
        }

       
        private void Form1_Load(object sender, EventArgs e)
        {
            MandelbrotSet();
        }

        public void MandelbrotSet()
        {

            //PRUEBA mandelbrot
            int width = pictureBox1.Width;
            int heigh = pictureBox1.Height;
            Bitmap bmp = new Bitmap(width, heigh);

            for (int row = 0; row < heigh; row++)
            {
                for (int col = 0; col < width; col++)
                {

                    double c_re = (col - width / 2.0) * 4.0 / width;
                    double c_in = (row - heigh / 2.0) * 4.0 / heigh;
                    int iteracion = 0;
                    double x = 0, y = 0;

                    while (iteracion < 1000 && ((x * x) + (y * y)) <= 4)
                    {
                        double x_temp = (x * x) - (y * y) + c_re;
                        y = 2 * x * y + c_in;
                        x = x_temp;
                        iteracion++;

                        if (iteracion < 1000)
                        {
                            bmp.SetPixel(col, row, Color.FromArgb(iteracion%120, iteracion%45*5, iteracion%10));
                        }
                        else
                        {
                            bmp.SetPixel(col, row, Color.Black);
                        }
                    }


                }
            }

            pictureBox1.Image = bmp;

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
