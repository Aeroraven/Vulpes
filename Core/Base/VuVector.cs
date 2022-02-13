using System;
using System.Collections.Generic;
using System.Text;

using Vulpes.Core.Exceptions;

//Vector
//This class encapsulates vector operations

namespace Vulpes.Core.Base
{
    class VuVector<T>
    {
        T[] elements;
        public VuVector(int size)
        {
            elements = new T[size];
        }
        public VuVector(T[] array)
        {
            elements = new T[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                elements[i] = array[i];
            }
        }
        public VuVector(VuVector<T> array)
        {
            elements = new T[array.Size];
            for (int i = 0; i < array.Size; i++)
            {
                elements[i] = array.elements[i];
            }

        }
        //Vector Size
        public int Size
        {
            get
            {
                return elements.Length;
            }
        }
        //Vector Indexer
        public T this[int index]
        {
            get
            {
                return elements[index];
            }
            set
            {
                elements[index] = value;
            }
        }
        //Vector Add
        public static VuVector<T> operator +(VuVector<T> lhs, VuVector<T> rhs)
        {
            if (lhs.Size != rhs.Size)
            {
                throw new VuMathematicalException("Added vectors should have same dimensions");
            }
            VuVector<T> ret = new VuVector<T>(lhs);
            for (int i = 0; i < lhs.Size; i++)
            {
                lhs[i] = (dynamic)lhs[i] + rhs[i];
            }
            return ret;
        }
        //Vector Minus
        public static VuVector<T> operator -(VuVector<T> lhs, VuVector<T> rhs)
        {
            if (lhs.Size != rhs.Size)
            {
                throw new VuMathematicalException("Added vectors should have same dimensions");
            }
            VuVector<T> ret = new VuVector<T>(lhs);
            for (int i = 0; i < lhs.Size; i++)
            {
                lhs[i] = (dynamic)lhs[i] - rhs[i];
            }
            return ret;
        }
        //Vector Inner Product
        public static VuVector<T> operator *(VuVector<T> lhs, VuVector<T> rhs)
        {
            if (lhs.Size != rhs.Size)
            {
                throw new VuMathematicalException("Added vectors should have same dimensions");
            }
            VuVector<T> ret = new VuVector<T>(lhs);
            for (int i = 0; i < lhs.Size; i++)
            {
                lhs[i] = (dynamic)lhs[i] * rhs[i];
            }
            return ret;
        }
    }
}
