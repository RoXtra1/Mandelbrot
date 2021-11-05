using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Fractal
{
    class Mondelbrot
    {
        public readonly Bitmap bmp;
        private int max_iter_count;

        public Mondelbrot(Size size, int max_iter, double x0, double y0, double interval)
        {
            int bmp_size = size.Height < size.Width ? size.Height : size.Width;
            bmp = new Bitmap(bmp_size, bmp_size);
            max_iter_count = max_iter;
            double x = x0, y = y0, delta = interval / bmp_size;

            for(int i=0;i<bmp_size;i++)
            {
                for(int j = 0; j<bmp_size; j++)
                {
                    bmp.SetPixel(j, i, get_pix_col(get_iter_col(x, y)));
                    x += delta;
                }
                x = x0; y += delta;
            }
        }

        private Color get_pix_col(int i)
        {
            double k =1 - (double)i / max_iter_count;
            long rgb = (int)(0xFFFFFF * k) + 0xFF000000;
            return Color.FromArgb((int)rgb);
        }

        private int get_iter_col(double x0, double y0)
        {
            double x = x0, y = y0;
            int i_count = 0;

            while ((x * x + y * y < 4)&&(i_count<max_iter_count))
            {
                double pre_x = x, pre_y = y;

                x = pre_x * pre_x - pre_y * pre_y + x0;
                y = 2 * pre_x * pre_y + y0;
                i_count++;
            }
            return i_count;
        }

    }
}
