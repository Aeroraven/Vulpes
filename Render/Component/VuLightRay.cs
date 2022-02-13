using System;
using System.Collections.Generic;
using System.Text;
using Vulpes.Core.Base;
namespace Vulpes.Render.Component
{
    class VuLightRay:VuRay
    {
        VuColor color;
        public VuLightRay(VuVector2f org, VuVector2f dir, VuColor col)
        {
            origin = org;
            direction = dir;
            color = col;
        }
        public VuColor Color
        {
            get
            {
                return color;
            }
            set
            {
                color = value;
            }
        }
    }
}
