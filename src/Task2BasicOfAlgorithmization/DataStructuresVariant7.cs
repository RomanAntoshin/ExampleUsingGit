using System;
using System.Collections.Generic;

namespace Task2BasicOfAlgorithmization
{
    class DataStructuresVariant7<T>
    {
        private List<T> data;
        public int Count
        {
            get { return data.Count; }
        }
        public DataStructuresVariant7()
        {
            this.data = new List<T>();
        }
        public void Push(T item)
        {
            data.Add(item);
        }
        public T Pop()
        {
            T item = data[data.Count - 1];
            data.RemoveAt(data.Count - 1);
            return item;
        }
        public T  Peek()
        {
            return data[data.Count - 1];
        }
        public void Clear()
        {
            data.Clear();
        }
        public bool Contains(T item)
        {
            return data.Contains(item);
        }
    }
}
