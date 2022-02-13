using System;
using System.Collections.Generic;
using System.Text;
using Vulpes.Core.Base;
namespace Vulpes.Render.Attribute
{
    interface IVuSignedDistanceField
    {
        abstract public float GetSDFDistance(VuVector2f source);
    }
}
