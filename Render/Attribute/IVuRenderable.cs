﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Vulpes.Render.Attribute
{
    interface IVuRenderable
    {
        abstract public void Render(int samples);
    }
}
