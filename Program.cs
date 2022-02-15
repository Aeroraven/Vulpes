using System;
using Vulpes.Core.Renderer.OpenGL;
using Vulpes.Core.Renderer;
using Vulpes.Core.Image;
using Vulpes.Render.Component;
using Vulpes.Render.Geometry;
using Vulpes.Core.Base;
using Vulpes.Render.Material;
using Vulpes.Imaging.Filtering;

namespace Vulpes
{
    class Program
    {
        static void Main(string[] args)
        {
            VuLightMaterial m1 = new VuLightMaterial();
            m1.Emission.SetColor(new VuColor(255, 0, 0));

            VuScene scene = new VuScene(400, 400, 2.0f, 2.0f);
            VuCircle circle = new VuCircle(new VuVector2f(1.0f, 1.0f), 0.25f,null);
            VuCircle circle2 = new VuCircle(new VuVector2f(1.5f, 1.5f), 0.125f, m1);

            scene.AddShape(circle, "1");
            scene.AddShape(circle2, "2");

            scene.Render(40);
            VuImageMeanFilter filter = new VuImageMeanFilter(1);
            filter.GetFilteredImage(scene.GetImage()).Save(@"C:\WR\hello.bmp");
        }
    }
}
