using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pet_Queue.Model
{
    class EasyQueue<T>
    {
        private List<T> items = new List<T>();
        private T Head => items.Last();
        private T Tail => items.First();
        public int Count => items.Count;

        public EasyQueue() { }
        public EasyQueue(T data)
        {
            items.Add(data);
        }

        public void Enque(T data) 
        {
            items.Insert(0, data);
        }

        public T Deque() 
        {
            var item = Head;
            items.Remove(item);
            return item;
        }

        public T Peek() 
        {
            return Head;
        }

    }
}
