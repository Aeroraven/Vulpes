using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using Vulpes.Core.Base;
using Vulpes.Core.Mathematics;
using Vulpes.Render.Attribute;
using Vulpes.Render.Algorithm;

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
        private VuColor RayMarching(VuVector2f source,VuVector2f direction)
        {
            float t = 0.0f;
            for(int i=0;i<renderConfig.MaxStep && t < renderConfig.MaxLength; i++)
            {
                float sr = shapes["debug"].GetSDFDistance(source + t * direction.UnitVector);
                if (sr < VuMathBase.Eps)
                {
                    return new VuColor(255, 255, 255);
                }
                t += sr;
            }
            return new VuColor(0, 0, 0);
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
                        VuColor res = RayMarching(new VuVector2f(samplex, sampley), dir);
                        sR += res.R;
                        sB += res.B;
                        sG += res.G;
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
    }
}
