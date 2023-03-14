using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z1
{
    internal class MyList<T>
    {
        protected T[] arr = Array.Empty<T>();
        public void Add(T value)
        {
            var newArray = new T[arr.Length + 1];
            for (int i = 0; i < arr.Length; i++)
            {
                newArray[i] = arr[i];
            }
            newArray[arr.Length] = value;
            arr = newArray;
        }
        public T this[int index]
        {
            get => arr[index];
            set => arr[index] = value;
        }
        public int Count
        {
            get { return arr.Length; }
        }
    }
}
