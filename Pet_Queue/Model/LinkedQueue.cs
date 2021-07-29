using System;
using System.Collections.Generic;
using System.Text;

namespace Pet_Queue.Model
{
    public class LinkedQueue<T>
    {
        private Item<T> head;
        private Item<T> tail;
        public int Count { get; private set; }

        public LinkedQueue()
        {

        }
        public LinkedQueue(T data)
        {
            SetheadItem(data);
        }

        private void SetheadItem(T data)
        {
            var item = new Item<T>(data);
            head = item;
            tail = item;
            Count = 1;
        }

        public void Enque(T data)
        {
            if (Count == 0) 
            {
                SetheadItem(data);
                return;
            }
            var item = new Item<T>(data)
            {
                Next = tail
            };
            tail = item;
            Count++;
        }

        public T Deque()
        {
            var data = head.Data;

            var current = tail.Next;
            var previous = tail;
            while(current != null && current.Next != null)  
            {
                previous = current;
                current = current.Next;
            }
            head = previous;
            head.Next = null;
            Count--;
            return data;
        }

        public T Peek()
        {
            return head.Data;
        }
    }
}
