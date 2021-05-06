using System;
using System.Collections;
using System.Collections.Generic;

namespace QueueTestApp
{
    class MainApp
    {
        static void Main(string[] args)
        {






            #region 스택큐 로직 영역


            Hashtable dictionary = new Hashtable();
            dictionary["book"] = "책";
            dictionary["cook"] = "요리사";
            dictionary["tweet"] = "지저귀다";
            dictionary["whale"] = "고래";

            Console.WriteLine(dictionary["tweet"]);

            // Hashtable은 키가 따로있다. arraylist는 index값만 있(key의 역할 수행, 그러나 지정 X)
            Console.WriteLine("Queue 테스트");

            
            Queue queue = new();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);

            while (queue.Count > 0)
            {
                Console.WriteLine(queue.Dequeue() + "\t");
            }
            Console.WriteLine();


            Stack stack = new Stack();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);

            while (stack.Count > 0)
            {
                Console.WriteLine($"{stack.Pop()}");
            }

            #endregion


        }
    }
}
