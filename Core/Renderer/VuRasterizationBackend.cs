using System;
using System.Collections.Generic;
using System.Text;
using Vulpes.Core.Base;

//Graphical Backend
//This is the abstract class for Graphical APIs

namespace Vulpes.Core.Renderer
{
    abstract class VuRasterizationBackend
    {
        abstract public void RuntimeInit();
        abstract public void DrawPixel(VuVector<float>[] locations, VuColor[] colors);
        abstract public void DrawTriangle(VuVector<float>[] locations, VuColor[] colors);
        abstract public void DrawLines(VuVector<float>[] locations, VuColor[] colors);
        abstract public void Render();
        abstract public void Clear();
    }
}
