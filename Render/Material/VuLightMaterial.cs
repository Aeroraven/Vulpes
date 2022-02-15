using System;
using System.Collections.Generic;
using System.Text;
using Vulpes.Core.Base;

namespace Vulpes.Render.Material
{
    class VuLightMaterial
    {
        protected VuColor emission = new VuColor(255,255,255);
        public void CopyFrom(VuLightMaterial p)
        {
            emission.SetColor(p.emission);
        }
        public VuColor Emission
        {
            get
            {
                return emission;
            }
            set
            {
                emission = value;
            }
        }
    }
}
