using Pet_Queue.Model;
using System;
using System.Collections.Generic;

namespace Pet_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            #region EasyQueue
            /*
            EasyQueue<int> easyQueue = new EasyQueue<int>();
            easyQueue.Enque(1);
            easyQueue.Enque(2);
            easyQueue.Enque(3);
            easyQueue.Enque(4);
            easyQueue.Enque(5);
            Console.WriteLine(easyQueue.Deque());
            Console.WriteLine(easyQueue.Peek());
            Console.WriteLine(easyQueue.Deque());

            Console.ReadLine();*/
            #endregion

            #region ArrayQueue
            /*
            ArrayQueue<int> arrayQueue = new ArrayQueue<int>(5);
            arrayQueue.Enque(1);
            arrayQueue.Enque(2);
            arrayQueue.Enque(3);
            arrayQueue.Enque(4);
            arrayQueue.Enque(5);
            Console.WriteLine(arrayQueue.Deque());
            Console.WriteLine(arrayQueue.Peek());
            Console.WriteLine(arrayQueue.Deque());
            Console.WriteLine(arrayQueue.Deque());
            Console.WriteLine(arrayQueue.Deque());
            Console.WriteLine(arrayQueue.Deque());
            Console.WriteLine(arrayQueue.Deque());

            Console.ReadLine(); 
            */
            #endregion

            #region LinkedQueue
            /*
            LinkedQueue<int> linkedQueue = new LinkedQueue<int>();
            linkedQueue.Enque(1);
            linkedQueue.Enque(2);
            linkedQueue.Enque(3);
            linkedQueue.Enque(4);
            linkedQueue.Enque(5);
            Console.WriteLine(linkedQueue.Deque());
            Console.WriteLine(linkedQueue.Peek());
            Console.WriteLine(linkedQueue.Deque());
            Console.WriteLine(linkedQueue.Deque());

            Console.ReadLine();
            */
            #endregion

            #region EasyDeque
            /*
            EasyDeque<int> easyDeque = new EasyDeque<int>();
            easyDeque.PushFront(1);
            easyDeque.PushFront(2);
            easyDeque.PushFront(3);
            easyDeque.PushBack(60);
            easyDeque.PushBack(70);
            easyDeque.PushFront(700);
            easyDeque.PushBack(900);
            Console.WriteLine(easyDeque.PopFront());
            Console.WriteLine(easyDeque.PopBack());
            Console.WriteLine(easyDeque.PopFront());
            Console.WriteLine(easyDeque.PopBack());

            Console.ReadLine();
            */
            #endregion

            #region DoublyConnectedQueue

            DoublyConnectedQueue<int> doublyConnectedQueue = new DoublyConnectedQueue<int>();
            doublyConnectedQueue.PushFront(1);
            doublyConnectedQueue.PushFront(2);
            doublyConnectedQueue.PushFront(3);
            doublyConnectedQueue.PushBack(60);
            doublyConnectedQueue.PushBack(70);
            doublyConnectedQueue.PushFront(700);
            doublyConnectedQueue.PushBack(900);
            Console.WriteLine(doublyConnectedQueue.PopFront());
            Console.WriteLine(doublyConnectedQueue.PopBack());
            Console.WriteLine(doublyConnectedQueue.PopFront());
            Console.WriteLine(doublyConnectedQueue.PopBack());

            Console.ReadLine();

            #endregion

        }
    }
}
