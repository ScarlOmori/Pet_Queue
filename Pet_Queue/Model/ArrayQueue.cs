﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Pet_Queue.Model
{
    class ArrayQueue<T>
    {
        private T[] items;
        private T Head => items[Count > 0 ? Count - 1 : 0];
        private T Tail => items[0];
        private int MaxCount => items.Length;
        public int Count { get; private set; }

        public ArrayQueue(int size)
        {
            items = new T[size];
            Count = 0;
        }
        public ArrayQueue(int size, T data)
        {
            items = new T[size];
            items[0] = data;
            Count = 1;
        }

        public void Enque(T data)
        {
            if (Count < MaxCount) 
            {
                var result = new T[] {data }.Concat(items);
                items = result.ToArray();
                Count++;
            }


            /*
            if (Count < MaxCount)
            {
                var result = new T[MaxCount];
                result[0] = data;
                for (int i = 0; i < Count; i++)
                {
                    result[i + 1] = items[i];
                }
                items = result;
                Count++;
            }*/
        }

        public T Deque()
        {
            var item = Head;
            Count--;
            return item;
        }

        public T Peek()
        {
            return Head;
        }
    }
}
