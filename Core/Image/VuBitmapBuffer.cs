using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Drawing.Imaging;
using Vulpes.Core.Base;
namespace Vulpes.Core.Image
{
    class VuBitmapBuffer
    {
        int width;
        int height;
        VuColor[,] buffer;
        public VuBitmapBuffer(int w, int h)
        {
            this.width = w;
            this.height = h;
            buffer = new VuColor[w, h];
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    buffer[i, j] = new VuColor();
                }
            }
        }
        public Bitmap GetImage()
        {
            Bitmap ret = new Bitmap(width, height);
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {

                    buffer[i, j].A = 100;
                    ret.SetPixel(i, j, Color.FromArgb(buffer[i, j].A, buffer[i, j].R, buffer[i, j].G, buffer[i, j].B));
                }
            }
            return ret;
        }
        public void Save(String filename)
        {
            Bitmap res = GetImage();
            res.Save(filename, ImageFormat.Bmp);
        }
        public int Width{
            get
            {
                return width;
            }
        }
        public int Height
        {
            get
            {
                return height;
            }
        }
        public VuColor this[int _x,int _y]
        {
            get
            {
                return buffer[_x, _y];
            }
            set
            {
                buffer[_x, _y] = value;
            }
        }
    }
}
