using System;
using System.Collections.Generic;
using System.Text;

using Vulpes.Core.Base;
using Vulpes.Render.Attribute;

namespace Vulpes.Render.Geometry
{
    class VuCircle : IVuShape
    {
        protected VuVector2f center;
        protected float radius;
        public VuCircle()
        {
            center = new VuVector2f();
            radius = 0;
        }
        public VuCircle(VuVector2f c,float r)
        {
            center = c;
            radius = r;
        }
        public float GetSDFDistance(VuVector2f source)
        {
            VuVector2f d = source - center;
            return d.Dist - radius;
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
