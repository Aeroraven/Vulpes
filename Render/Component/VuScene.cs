using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using Vulpes.Core.Base;
using Vulpes.Core.Mathematics;
using Vulpes.Render.Attribute;
using Vulpes.Render.Algorithm;
using Vulpes.Core.Image;

namespace Vulpes.Render.Component
{
    class VuScene: VuRenderScene,IVuRenderable,IVuShapeContainer
    {
        protected Dictionary<string,IVuShape> shapes;
        protected readonly VuRayMarchingConfig renderConfig = new VuRayMarchingConfig();
        public VuScene(int iw, int ih, float sw, float sh):base(iw,ih,sw,sh)
        {
            shapes = new Dictionary<string, IVuShape>();
        }

        public void AddShape(IVuShape shape, string name)
        {
            shapes.Add(name, shape);
        }

        public void DeleteShape(string name)
        {
            shapes.Remove(name);
        }
        private void RayMarching(VuVector2f source,VuLightRay light,ref float sR,ref float sG,ref float sB)
        {
            float t = 0.0f;
            for(int i=0;i<renderConfig.MaxStep && t < renderConfig.MaxLength; i++)
            {
                float sr = 1e30f;
                string mark = "";
                foreach(var j in shapes)
                {
                    float dst = j.Value.GetSDFDistance(source.X+t*light.Direction.X,source.Y+t*light.Direction.Y);
                    if (dst < sr)
                    {
                        sr = dst;
                        mark = j.Key;
                    }
                }
                if (sr < VuMathBase.Eps)
                {
                    light.Color.MixColorRM(shapes[mark].GetLightMaterial().Emission,ref sR,ref sG,ref sB);
                    return;
                }
                t += sr;
            }
        }
        public void Render(int samples)
        {
            for (int i = 0; i < image.Width; i++)
            {
                for (int j = 0; j < image.Height; j++)
                {
                    float sR = 0.0f, sG = 0.0f, sB = 0.0f;
                    for (int T = 0; T < samples; T++)
                    {
                        float samplex = (float)i / image.Width * SceneWidth;
                        float sampley = (float)j / image.Height * SceneHeight;
                        VuVector2f dir = VuRandomUtil.RandomUnitVector();
                        VuColor color = new VuColor(255, 255, 255);
                        VuLightRay light = new VuLightRay(new VuVector2f(samplex, sampley), dir, color);
                        RayMarching(new VuVector2f(samplex, sampley), light,ref sR,ref sG,ref sB);
                    }
                    sR /= samples;
                    sB /= samples;
                    sG /= samples;
                    image[i, j].SetColor(new VuColor((byte)sR, (byte)sG, (byte)sB));
                }
            }
            
        }
        public VuRayMarchingConfig RenderConfig
        {
            get {
                return renderConfig;
            }
        }
        public void Save(string path)
        {
            base.image.Save(path);
        }
        public VuBitmapBuffer GetImage()
        {
            return image;
        }
    }
}
