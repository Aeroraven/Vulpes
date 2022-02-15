using System;
using System.Collections.Generic;
using System.Text;
using Vulpes.Core.Image;

namespace Vulpes.Imaging.Filtering
{
    interface IVuImageFiltering
    {
        public abstract VuBitmapBuffer GetFilteredImage(VuBitmapBuffer src);
    }
}
