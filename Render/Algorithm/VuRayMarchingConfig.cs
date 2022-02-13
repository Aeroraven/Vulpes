using System;
using System.Collections.Generic;
using System.Text;

namespace Vulpes.Render.Algorithm
{
    class VuRayMarchingConfig
    {
        protected float maxLength = 2.0f;
        public float MaxLength
        {
            get
            {
                return maxLength;
            }
            set
            {
                maxLength = value;
            }
        }

        protected float maxStep = 20;
        public float MaxStep
        {
            get
            {
                return maxStep;
            }
            set
            {
                maxStep = value;
            }
        }
    }
}
