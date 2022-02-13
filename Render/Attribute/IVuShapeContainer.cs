using System;
using System.Collections.Generic;
using System.Text;

namespace Vulpes.Render.Attribute
{
    interface IVuShapeContainer
    {
        abstract public void AddShape(IVuShape shape, String name);
        abstract public void DeleteShape(String name);
    }
}
