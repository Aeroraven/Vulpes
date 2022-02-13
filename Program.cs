using System;
using Vulpes.Core.Renderer.OpenGL;
using Vulpes.Core.Renderer;
using Vulpes.Core.Image;
using Vulpes.Render.Component;
using Vulpes.Render.Geometry;
using Vulpes.Core.Base;

namespace Vulpes
{
    class Program
    {
        static void Main(string[] args)
        {
            VuScene scene = new VuScene(400, 400, 2.0f, 2.0f);
            VuCircle circle = new VuCircle(new VuVector2f(1.0f, 1.0f), 0.25f);
            scene.AddShape(circle, "debug");
            scene.Render(100);
            scene.Save(@"C:\WR\hello.bmp");
        }
    }
}
