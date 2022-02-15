using System;
using System.Collections.Generic;
using System.Text;

using Vulpes.Core.Exceptions;

namespace Vulpes.Core.Base
{
    class VuColor 
    {
        byte _r, _g, _b, _a;
        public VuColor() {
            R = 0;
            G = 0;
            B = 0;
            A = 255;
        }
        public VuColor(byte r, byte g, byte b)
        {
            R = r;
            G = g;
            B = b;
            A = 255;
        }
        public VuColor(byte r, byte g, byte b, byte a)
        {
            R = r;
            G = g;
            B = b;
            A = a;
        }
        public VuColor(VuColor c) 
        {
            SetColor(c);
        }
        public void SetColor(VuColor c)
        {
            R = c.R;
            G = c.G;
            B = c.B;
            A = c.A;
        }
        public VuColor MixColor(VuColor c)
        {
            VuColor ret = new VuColor();
            ret.R = (byte)(c.R * R / 255);
            ret.G = (byte)(c.G * G / 255);
            ret.B = (byte)(c.B * B / 255);
            ret.A = (byte)(c.A * A / 255);
            return ret;
        }
        public void MixColorRM(VuColor c,ref float sR,ref float sG,ref float sB)
        {
            VuColor ret = new VuColor();
            sR += (byte)(c.R * R / 255);
            sG += (byte)(c.G * G / 255);
            sB += (byte)(c.B * B / 255);
        }
        public byte R
        {
            get
            {
                return _r;
            }
            set
            {
                _r = value;
            }
        }
        public byte G
        {
            get
            {
                return _g;
            }
            set
            {
                _g = value;
            }
        }
        public byte B
        {
            get
            {
                return _b;
            }
            set
            {
                _b = value;
            }
        }
        public byte A
        {
            get
            {
                return _a;
            }
            set
            {
                _a = value;
            }
        }
    }
}
