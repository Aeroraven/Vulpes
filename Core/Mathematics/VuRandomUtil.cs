using System;
using System.Collections.Generic;
using System.Text;

using Vulpes.Core.Base;

namespace Vulpes.Core.Mathematics
{
    class VuRandomUtil
    {
        private static Random randomEngine = new Random();
        public static double RandomNumber()
        {
            return randomEngine.NextDouble();
        }
        public static VuVector2f RandomUnitVector()
        {
            double deg = VuMathBase.Pi * 2.0 * RandomNumber();
            return new VuVector2f((float)Math.Cos(deg),(float)Math.Sin(deg));
        }
    }
}
