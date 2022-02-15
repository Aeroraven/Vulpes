using System;
using System.Collections.Generic;
using System.Text;
using Vulpes.Core.Image;

namespace Vulpes.Imaging.Filtering
{
    class VuImageMeanFilter:IVuImageFiltering
    {
        private int step;
        public VuImageMeanFilter(int x)
        {
            step = x;
        }
        public VuBitmapBuffer GetFilteredImage(VuBitmapBuffer src)
        {
            VuBitmapBuffer ret = new VuBitmapBuffer(src.Width, src.Height);
            for(int i = 0; i < src.Width; i++)
            {
                for(int j = 0; j < src.Height; j++)
                {
                    ret[i, j] = src[i, j];
                }
            }
            
            for (int i = step; i < src.Width - step; i++)
            {
                for (int j = step; j < src.Height - step; j++)
                {
                    int sR = 0, sG = 0, sB = 0, sW = 0;
                    for(int k = -step; k <= step; k++)
                    {
                        for(int l = -step; l <= step; l++)
                        {
                            sR += src[i + k, j + l].R;
                            sG += src[i + k, j + l].G;
                            sB += src[i + k, j + l].B;
                            sW++;
                        }
                    }
                    ret[i, j].R = (byte)(sR / sW);
                    ret[i, j].G = (byte)(sG / sW);
                    ret[i, j].B = (byte)(sB / sW);
                }
            }
            return ret;

        }
    }
}
