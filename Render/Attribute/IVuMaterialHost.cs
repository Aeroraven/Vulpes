using System;
using System.Collections.Generic;
using System.Text;
using Vulpes.Render.Material;

namespace Vulpes.Render.Attribute
{
    interface IVuMaterialHost
    {
        public abstract VuLightMaterial GetLightMaterial();
    }
}
