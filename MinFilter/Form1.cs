using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MinFilter
{
    public partial class Form1 : Form
    {
        private Bitmap f_image = null;  //input image
        public Bitmap image;
        public Form1()
        {
            InitializeComponent();
        }

        private void Open_Click(object sender, EventArgs e)
        {
            OpenFileDialog OpenFileImage = new OpenFileDialog();
            OpenFileImage.Filter = "bitmap (*.bmp)|*.bmp";
            OpenFileImage.FilterIndex = 1;
            if (OpenFileImage.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if (f_image != null)
                        f_image.Dispose();
                    f_image = (Bitmap)Bitmap.FromFile(OpenFileImage.FileName, false);

                }
                catch (Exception)
                {
                    MessageBox.Show("Can not open file”, “File Error");
                }
            }
            image = new Bitmap(f_image.Width, f_image.Height);
            


            pictureBox1.Image = f_image;
            chart(f_image, 2);
        }
               
        private void MinFilter_Click(object sender, EventArgs e)
        {
            int[,] arrOut = new int[f_image.Width, f_image.Height];
            int[,] arrCal = new int[f_image.Width, f_image.Height];
            int[] arr3 = new int[9];
            int Q = 2;
            int B = 2;
            int filter = 3;
            int max = 0;
            int min = 999;
            int run = 0;
            for (int i = 0; i < f_image.Width; i++)
            {
                for (int j = 0; j < f_image.Height; j++)
                {

                    Color PixelColor = f_image.GetPixel(i, j);
                    int C_gray = (int)(PixelColor.R + PixelColor.G + PixelColor.B) / 3;
                    arrOut[i, j] = C_gray;

                }
            }

            for (int i = 0; i < f_image.Width; i++)
            {
                for (int j = 0; j < f_image.Height; j++)
                {

                    //filter 3*3      
                    if (filter + i - 1 <= f_image.Width &&
                        filter + j - 1 <= f_image.Height)
                    {
                        for (int x = i; x < i + filter - 1; x++)
                        {
                            for (int y = j; y < j + filter - 1; y++)
                            {
                                if (arrOut[x, y] > max)
                                    max = arrOut[x, y];
                                if (arrOut[x, y] < min)
                                    min = arrOut[x, y];


                            }
                        }
                        for (int x = i; x < i + filter; x++)
                        {
                            for (int y = j; y < j + filter; y++)
                            {
                                if (run == 4)
                                    arrCal[x, y] = min;
                                run++;
                            }
                        }
                    }
                    max = 0;
                    min = 999;
                    run = 0;

                }
            }

            for (int i = 0; i < f_image.Width; i++)
            {
                for (int j = 0; j < f_image.Height; j++)
                {
                    image.SetPixel(i, j, Color.FromArgb(arrCal[i, j], arrCal[i, j], arrCal[i, j]));
                }
            }

            pictureBox2.Image = image;
            this.chart1.Series["Series1"].Points.Clear();
            this.chart2.Series["Series1"].Points.Clear();
            chart(image, 1);
            chart(f_image, 2);

        }

        public void chart(Bitmap image, int c)
        {
            int[] arrCo = new int[255];
            int[] arrNco = new int[255];

            for (int i = 0; i < image.Width; i++)
            {
                for (int j = 0; j < image.Height; j++)
                {

                    Color PixelColor = image.GetPixel(i, j);
                    int C_gray = (int)(PixelColor.R + PixelColor.G + PixelColor.B) / 3;
                    if (C_gray >= 254)
                        C_gray = 254;
                    arrCo[C_gray] += 1;
                    
                }
            }
            if (c == 1)
            {
                for (int i = 0; i < arrCo.Length; i++)
                {
                    this.chart1.Series["Series1"].Points.AddXY(i, arrCo[i]);
                }
            }
            else
            {
                for (int i = 0; i < arrCo.Length; i++)
                {
                    this.chart2.Series["Series1"].Points.AddXY(i, arrCo[i]);
                }
            }
            arrCo = null;
            arrNco = null;

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void MaxFilter_Click(object sender, EventArgs e)
        {
            int[,] arrOut = new int[f_image.Width, f_image.Height];
            int[,] arrCal = new int[f_image.Width, f_image.Height];
            int[] arr3 = new int[9];
            int Q = 2;
            int B = 2;
            int filter = 3;
            int max = 0;
            int min = 999;
            int run = 0;
            for (int i = 0; i < f_image.Width; i++)
            {
                for (int j = 0; j < f_image.Height; j++)
                {

                    Color PixelColor = f_image.GetPixel(i, j);
                    int C_gray = (int)(PixelColor.R + PixelColor.G + PixelColor.B) / 3;
                    arrOut[i, j] = C_gray;

                }
            }

            for (int i = 0; i < f_image.Width; i++)
            {
                for (int j = 0; j < f_image.Height; j++)
                {

                    //filter 3*3      
                    if (filter + i - 1 <= f_image.Width &&
                        filter + j - 1 <= f_image.Height)
                    {
                        for (int x = i; x < i + filter - 1; x++)
                        {
                            for (int y = j; y < j + filter - 1; y++)
                            {
                                if (arrOut[x, y] > max)
                                    max = arrOut[x, y];
                                if (arrOut[x, y] < min)
                                    min = arrOut[x, y];


                            }
                        }
                        for (int x = i; x < i + filter; x++)
                        {
                            for (int y = j; y < j + filter; y++)
                            {
                                if (run == 4)
                                    arrCal[x, y] = max;
                                run++;
                            }
                        }
                    }
                    max = 0;
                    min = 999;
                    run = 0;

                }
            }

            for (int i = 0; i < f_image.Width; i++)
            {
                for (int j = 0; j < f_image.Height; j++)
                {
                    image.SetPixel(i, j, Color.FromArgb(arrCal[i, j], arrCal[i, j], arrCal[i, j]));
                }
            }

            pictureBox2.Image = image;
            this.chart1.Series["Series1"].Points.Clear();
            this.chart2.Series["Series1"].Points.Clear();
            chart(image, 1);
            chart(f_image, 2);
        }

        private void Midpoint_Click(object sender, EventArgs e)
        {
            int[,] arrOut = new int[f_image.Width, f_image.Height];
            int[,] arrCal = new int[f_image.Width, f_image.Height];
            int[] arr3 = new int[9];
            int Q = 2;
            int B = 2;
            int filter = 3;
            int max = 0;
            int min = 999;
            int run = 0;
            for (int i = 0; i < f_image.Width; i++)
            {
                for (int j = 0; j < f_image.Height; j++)
                {

                    Color PixelColor = f_image.GetPixel(i, j);
                    int C_gray = (int)(PixelColor.R + PixelColor.G + PixelColor.B) / 3;
                    arrOut[i, j] = C_gray;

                }
            }

            for (int i = 0; i < f_image.Width; i++)
            {
                for (int j = 0; j < f_image.Height; j++)
                {

                    //filter 3*3      
                    if (filter + i - 1 <= f_image.Width &&
                        filter + j - 1 <= f_image.Height)
                    {
                        for (int x = i; x < i + filter - 1; x++)
                        {
                            for (int y = j; y < j + filter - 1; y++)
                            {
                                if (arrOut[x, y] > max)
                                    max = arrOut[x, y];
                                if (arrOut[x, y] < min)
                                    min = arrOut[x, y];


                            }
                        }
                        for (int x = i; x < i + filter; x++)
                        {
                            for (int y = j; y < j + filter; y++)
                            {
                                if (run == 4)
                                    arrCal[x, y] = (int)((max + min)/2);
                                run++;
                            }
                        }
                    }
                    max = 0;
                    min = 999;
                    run = 0;

                }
            }

            for (int i = 0; i < f_image.Width; i++)
            {
                for (int j = 0; j < f_image.Height; j++)
                {
                    image.SetPixel(i, j, Color.FromArgb(arrCal[i, j], arrCal[i, j], arrCal[i, j]));
                }
            }

            pictureBox2.Image = image;
            this.chart1.Series["Series1"].Points.Clear();
            this.chart2.Series["Series1"].Points.Clear();
            chart(image, 1);
            chart(f_image, 2);
        }


        public void Contra()
        {
            int[,] arrOut = new int[f_image.Width, f_image.Height];
            int[,] arrCal = new int[f_image.Width, f_image.Height];
            int[] arr3 = new int[9];
            double Q = Convert.ToDouble(textBox1.Text);
            int B = 0;
            int filter = 3;
            int max = 0;
            int min = 999;
            int run = 0;          
            for (int i = 0; i < f_image.Width; i++)
            {
                for (int j = 0; j < f_image.Height; j++)
                {

                    Color PixelColor = f_image.GetPixel(i, j);
                    int C_gray = (int)(PixelColor.R + PixelColor.G + PixelColor.B) / 3;
                    arrOut[i, j] = C_gray;

                }
            }

            for (int i = 0; i < f_image.Width; i++)
            {
                for (int j = 0; j < f_image.Height; j++)
                {

                    //filter 3*3      
                    if (filter + i - 1 <= f_image.Width &&
                        filter + j - 1 <= f_image.Height)
                    {
                        for (int x = i; x < i + filter - 1; x++)
                        {
                            for (int y = j; y < j + filter - 1; y++)
                            {
                                max += (int)(Math.Pow(arrOut[x, y], Q + 1.0));
                                min += (int)(Math.Pow(arrOut[x, y], Q));
                               
                            }
                        }
                        for (int x = i; x < i + filter; x++)
                        {
                            for (int y = j; y < j + filter; y++)
                            {
                                if (run == 4)
                                {                                  
                                                          
                                    arrCal[x, y] = max / min;

                                }                                   
                                run++;
                            }
                        }
                    }
                    max = 0;
                    min = 999;
                    run = 0;
                    B = 0;

                }
            }

            for (int i = 0; i < f_image.Width; i++)
            {
                for (int j = 0; j < f_image.Height; j++)
                {                   
                    image.SetPixel(i, j, Color.FromArgb(arrCal[i, j], arrCal[i, j], arrCal[i, j]));
                }
            }

            pictureBox2.Image = image;
            this.chart1.Series["Series1"].Points.Clear();
            this.chart2.Series["Series1"].Points.Clear();
            chart(image, 1);
            chart(f_image, 2);
        }

        private void ContraFilter_Click(object sender, EventArgs e)
        {
            Contra();
        }

        public void Alphatrimmed()
        {
            int[,] arrOut = new int[f_image.Width, f_image.Height];
            int[,] arrCal = new int[f_image.Width, f_image.Height];
            int[] arr3 = new int[9];
            double Q = Convert.ToDouble(textBox1.Text);
            int B = 0;
            int filter = 3;
            int max = 0;
            int min = 0;
            int run = 0;
            for (int i = 0; i < f_image.Width; i++)
            {
                for (int j = 0; j < f_image.Height; j++)
                {

                    Color PixelColor = f_image.GetPixel(i, j);
                    int C_gray = (int)(PixelColor.R + PixelColor.G + PixelColor.B) / 3;
                    arrOut[i, j] = C_gray;

                }
            }

            for (int i = 0; i < f_image.Width; i++)
            {
                for (int j = 0; j < f_image.Height; j++)
                {

                    //filter 3*3      
                    if (filter + i - 1 <= f_image.Width &&
                        filter + j - 1 <= f_image.Height)
                    {
                        for (int x = i; x < i + filter - 1; x++)
                        {
                            for (int y = j; y < j + filter - 1; y++)
                            {
                                max += arrOut[x, y];
                                

                            }
                        }
                        for (int x = i; x < i + filter; x++)
                        {
                            for (int y = j; y < j + filter; y++)
                            {
                                if (run == 4)
                                {
                                    filter = 9;

                                    arrCal[x, y] = (int)(max / (filter - Q));
                                    

                                }
                                run++;
                            }
                        }
                    }
                    max = 0;
                    min = 0;
                    run = 0;
                    B = 0;

                }
            }
            max = 0;
            min = 9999;
            for (int i = 0; i < f_image.Width; i++)
            {
                for (int j = 0; j < f_image.Height; j++)
                {
                    if (arrCal[i, j] > max)
                        max = arrCal[i, j];
                    if (arrCal[i, j] < min)
                        min = arrCal[i, j];
                }
            }
            int c = 0;
            for (int i = 0; i < f_image.Width; i++)
            {
                for (int j = 0; j < f_image.Height; j++)
                {
                    int cc = arrCal[i, j];
                    c = (cc * 255 / max);
                    if (c < 0)
                        c = c * -1;
                    //c = ((arrCal[i, j] - min) / (max - min)) * 255;
                    image.SetPixel(i, j, Color.FromArgb(c, c, c));
                }
            }

            pictureBox2.Image = image;
            this.chart1.Series["Series1"].Points.Clear();
            this.chart2.Series["Series1"].Points.Clear();
            chart(image, 1);
            chart(f_image, 2);
        }

        private void Alpha_Click(object sender, EventArgs e)
        {
            Alphatrimmed();
        }

        public void cal()
        {
            int[,] arrOut = new int[f_image.Width, f_image.Height];
            int[,] arrCal = new int[f_image.Width, f_image.Height];
            int[] arr3 = new int[9];
            int Q = 2;
            int B = 2;
            int filter = 3;
            int max = 0;
            int min = 999;
            int run = 0;
            for (int i = 0; i < f_image.Width; i++)
            {
                for (int j = 0; j < f_image.Height; j++)
                {

                    Color PixelColor = f_image.GetPixel(i, j);
                    int C_gray = (int)(PixelColor.R + PixelColor.G + PixelColor.B) / 3;
                    arrOut[i, j] = C_gray;
                    
                }
            }

            for (int i = 0; i < f_image.Width; i++)
            {
                for (int j = 0; j < f_image.Height; j++)
                {
                                 
                    //filter 3*3      
                    if(filter + i -1 <= f_image.Width &&
                        filter + j -1 <= f_image.Height)
                    {
                        for (int x = i; x < i + filter-1; x++)
                        {
                            for (int y = j; y < j + filter-1; y++)
                            {
                                if (arrOut[x, y] > max)
                                    max = arrOut[x, y];
                                if (arrOut[x, y] < min)
                                    min = arrOut[x, y];


                            }
                        }
                        for (int x = i; x < i + filter; x++)
                        {
                            for (int y = j; y < j + filter; y++)
                            {
                                if (run == 4)
                                    arrCal[x, y] = max;
                                run++;
                            }
                        }
                    }
                    max = 0;
                    min = 999;
                    run = 0;
                    
                }
            }

            for (int i = 0; i < f_image.Width; i++)
            {
                for (int j = 0; j < f_image.Height; j++)
                {
                    image.SetPixel(i, j, Color.FromArgb(arrCal[i, j], arrCal[i, j], arrCal[i, j]));
                }
            }

            pictureBox2.Image = image;
            this.chart1.Series["Series1"].Points.Clear();
            this.chart2.Series["Series1"].Points.Clear();
            chart(image, 1);
            chart(f_image, 2);
        }
    }
}
