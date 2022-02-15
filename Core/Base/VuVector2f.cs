using System;
using System.Collections.Generic;
using System.Text;
using Vulpes.Core.Exceptions;
namespace Vulpes.Core.Base
{
    class VuVector2f
    {
        float _x, _y;
        public VuVector2f() { }
        public VuVector2f(float x,float y)
        {
           X = x;
           Y = y;
        }
        public VuVector2f(VuVector2f value) 
        {
            X = value.X;
            Y = value.Y;
        }
        public float X
        {
            get
            {
                return _x;
            }
            set
            {
                _x = value;
            }
        }
        public float Y
        {
            get
            {
                return _y;
            }
            set
            {
                _y = value;
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
            return new VuVector2f(lhs.X+rhs.X,lhs.Y+rhs.Y);
        }
        public static VuVector2f operator -(VuVector2f lhs, VuVector2f rhs)
        {
            return new VuVector2f(lhs.X - rhs.X, lhs.Y - rhs.Y);
        }
        public static VuVector2f operator *(VuVector2f lhs, VuVector2f rhs)
        {
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
