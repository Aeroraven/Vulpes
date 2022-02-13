using System;
using System.Collections.Generic;
using System.Text;
namespace Vulpes.Core.Base
{
    class VuVector2i : VuVector<int>
    {
        public VuVector2i() : base(2) { }
        public VuVector2i(int x, int y) : base(2)
        {
            this[0] = x;
            this[1] = y;
        }
        public VuVector2i(VuVector2i value) : base(2)
        {
            this[0] = value[0];
            this[1] = value[1];
        }
        public int X
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
        public int Y
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
    }
}
