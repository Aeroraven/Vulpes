using System;
using System.Collections.Generic;
using System.Text;

using Vulpes.Core.Exceptions;

namespace Vulpes.Core.Base
{
    class VuColor : VuVector<byte>
    {
        public VuColor() : base(4) {
            this[0] = 0;
            this[1] = 0;
            this[2] = 0;
            this[3] = 255;
        }
        public VuColor(byte r, byte g, byte b) : base(4)
        {
            this[0] = r;
            this[1] = g;
            this[2] = b;
            this[3] = 255;
        }
        public VuColor(byte r, byte g, byte b, byte a) : base(4)
        {
            this[0] = r;
            this[1] = g;
            this[2] = b;
            this[3] = a;
        }
        public VuColor(VuColor c) : base(4)
        {
            for (int i = 0; i < 4; i++)
            {
                this[i] = c[i];
            }
        }
        public VuColor(VuVector<byte> c) : base(4)
        {
            if (c.Size != 4)
            {
                throw new VuMathematicalException("Color vector must be a 4d vector");
            }
            for (int i = 0; i < 4; i++)
            {
                this[i] = c[i];
            }
        }
        public void SetColor(VuColor c)
        {
            for (int i = 0; i < 4; i++)
            {
                this[i] = c[i];
            }
        }
        public byte R
        {
            get
            {
                return this[0];
            }
            set
            {
                this[0] = value;
            }
        }
        public byte G
        {
            get
            {
                return this[1];
            }
            set
            {
                this[1] = value;
            }
        }
        public byte B
        {
            get
            {
                return this[2];
            }
            set
            {
                this[2] = value;
            }
        }
        public byte A
        {
            get
            {
                return this[3];
            }
            set
            {
                this[3] = value;
            }
        }
    }
}
