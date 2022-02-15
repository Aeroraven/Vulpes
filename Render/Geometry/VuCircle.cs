using System;
using System.Collections.Generic;
using System.Text;

using Vulpes.Core.Base;
using Vulpes.Render.Attribute;
using Vulpes.Render.Material;

namespace Vulpes.Render.Geometry
{
    class VuCircle : IVuShape
    {
        protected VuVector2f center;
        protected readonly VuLightMaterial material = new VuLightMaterial();
        protected float radius;
        public VuCircle()
        {
            center = new VuVector2f();
            radius = 0;
        }
        public VuCircle(VuVector2f c, float r, VuLightMaterial m)
        {
            if (!(m is null))
            {
                material.CopyFrom(m);
            }
            center = c;
            radius = r;
        }
        public float GetSDFDistance(VuVector2f source)
        {
            VuVector2f d = source - center;
            return d.Dist - radius;
        }

        public VuLightMaterial GetLightMaterial()
        {
            return material;
        }

        public float GetSDFDistance(float sourceX, float sourceY)
        {
            float dx = sourceX - Center.X;
            float dy = sourceY - Center.Y;
            return (float)(Math.Sqrt(dx * dx + dy * dy) - Radius);
        }

        public VuVector2f Center
        {
            get
            {
                return center;
            }
            set
            {
                center = value;
            }
        }
        public float Radius
        {
            get
            {
                return radius;
            }
            set
            {
                radius = value;
            }
        }
    }
}
