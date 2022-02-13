using System;
using System.Collections.Generic;
using System.Text;
using Vulpes.Core.Exceptions;
namespace Vulpes.Core.Base
{
    class VuVector2f:VuVector<float>
    {
        public VuVector2f() : base(2) { }
        public VuVector2f(float x,float y):base(2)
        {
            this[0] = x;
            this[1] = y;
        }
        public VuVector2f(VuVector2f value) : base(2)
        {
            this[0] = value[0];
            this[1] = value[1];
        }
        public float X
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
        public float Y
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
        public float Dist
        {
            get
            {
                return (float)Math.Sqrt(X * X + Y * Y);
            }
        }
        public VuVector2f UnitVector
        {
            get
            {
                return new VuVector2f(X / Dist, Y / Dist);
            }
        }
        public static VuVector2f operator +(VuVector2f lhs, VuVector2f rhs)
        {
            if (lhs.Size != rhs.Size)
            {
                throw new VuMathematicalException("Added vectors should have same dimensions");
            }
            
            return new VuVector2f(lhs.X+rhs.X,lhs.Y+rhs.Y);
        }
        public static VuVector2f operator -(VuVector2f lhs, VuVector2f rhs)
        {
            if (lhs.Size != rhs.Size)
            {
                throw new VuMathematicalException("Added vectors should have same dimensions");
            }

            return new VuVector2f(lhs.X - rhs.X, lhs.Y - rhs.Y);
        }
        public static VuVector2f operator *(VuVector2f lhs, VuVector2f rhs)
        {
            if (lhs.Size != rhs.Size)
            {
                throw new VuMathematicalException("Added vectors should have same dimensions");
            }

            return new VuVector2f(lhs.X * rhs.X, lhs.Y * rhs.Y);
        }
        public static VuVector2f operator *(float lhs, VuVector2f rhs)
        {
            return new VuVector2f(lhs * rhs.X, lhs * rhs.Y);
        }
        public static VuVector2f operator *(double lhs, VuVector2f rhs)
        {
            return new VuVector2f((float)lhs * rhs.X, (float)lhs * rhs.Y);
        }
        public static VuVector2f operator *(int lhs, VuVector2f rhs)
        {
            return new VuVector2f((float)lhs * rhs.X, (float)lhs * rhs.Y);
        }
    }
}
