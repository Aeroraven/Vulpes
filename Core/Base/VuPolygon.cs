using System;
using System.Collections.Generic;
using System.Text;

namespace Vulpes.Core.Base
{
    class VuPolygon
    {
        private List<VuVector2f> vertices;
        public VuPolygon()
        {
            vertices = new List<VuVector2f>();
        }
        public void Add(VuVector2f v)
        {
            vertices.Add(v);
        }
        public void Reset()
        {
            vertices = new List<VuVector2f>();
        }
        public VuVector2f this[int index]
        {
            get
            {
                return vertices[index];
            }
            set
            {
                vertices[index] = value;
            }
        }
        public int Length
        {
            get
            {
                return vertices.Count;
            }
        }
    }
}
