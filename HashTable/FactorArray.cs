using HashTable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicStructures
{
    public class FactorArray<T> where T : IComparable<T>
    {

        T[] array;
        public FactorArray() : this(2) { }
        public FactorArray(int factor)
        {
            this.factor = factor;
            array = new T[0];
        }
        int factor;
        public int Factor
        {
            get { return factor; }
        }
        public int Size { get { return array.Length; } }

        public void Add(T item, int index)
        {
            while (index >= array.Length)
            {
                Resize();
            }
            array[index] = item;
        }
        public void Add(T item)
        {
            int index = 0;
            while (index >= array.Length)
            {
                Resize();
            }

            while (array[index] != null)
            {
                index++;
                if (index >= array.Length)
                {
                    Resize();
                }
            }

            Add(item, index);
        }
        public T Remove(int index)
        {
            T[] tempArray = new T[array.Length - 1];

            long count = 0;
            while (count < index)
            {
                tempArray[count] = array[count];
                count++;
            }
            while (count++ < tempArray.Length)
            {
                tempArray[count - 1] = array[count];
            }

            T outVal = array[index];
            array = tempArray;
            return outVal;
        }
        public T Get(int index)
        {
            return array[index];
        }
        public T Search(T t, out bool result)
        {
            if (array.Length == 0)
            {
                result = false;
                return t;
            }

            int count = 0;
            while (count < array.Length && array[count] != null)
            {
                if (array[count].CompareTo(t) == 0)
                {
                    result = true;
                    return array[count];
                }
                count++;
            }
            result = false;
            return t;
        }
        void Resize()
        {
            T[] tempArray = new T[array.Length * factor + 1];

            for (long i = 0; i < array.Length; i++)
            {
                tempArray[i] = array[i];
            }
            array = tempArray;
        }
    }
}