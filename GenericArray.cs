using System;
using System.Diagnostics;

namespace learn
{
    public class GenericArray<T>
    {   
        private T[] array;
        public GenericArray(int size)
        {
            array = new T[size];   
        }

        public void setItem(int index, T item)
        {   
            // Console.WriteLine($"size by Length: {array.Length}");
            // Console.WriteLine($"size by GetLength: {array.GetLength(0)}");
            int size = array.Length;
            Debug.Assert(index<size);
            array[index] = item;
        }

        public T getItem(int index)
        {   
            int size = array.Length;
            Debug.Assert(index<size);
            return array[index];
        }

    }
}