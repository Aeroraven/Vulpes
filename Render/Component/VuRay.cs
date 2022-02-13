using System;
using System.Collections.Generic;
using System.Text;
using Vulpes.Core.Base;

namespace Vulpes.Render.Component
{
    class VuRay
    {
        protected VuVector2f origin;
        protected VuVector2f direction;
        public VuRay()
        {
            origin = new VuVector2f();
            direction = new VuVector2f();
        }
        public VuRay(VuVector2f org, VuVector2f dir)
        {
            origin = org;
            direction = dir;
        }
        public VuVector2f Origin
        {
            get
            {
                return origin;
            }
            set
            {
                origin = value;
            }
        }
        public VuVector2f Direction
        {
            get
            {
                return direction;
            }
            set
            {
                direction = value;
            }
        }
    }
}
