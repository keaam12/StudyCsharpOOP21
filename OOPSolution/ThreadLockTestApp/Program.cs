using System;
using System.Threading;

namespace ThreadLockTestApp
{
    class Counter
    {
        private int counter = 1000;

        public void Run()
        {
            for (int i = 0; i < 10; i++)
            {
                Thread th = new Thread(unsafeCalc);
                th.Start();
            }
        }

        private void unsafeCalc()
        {
            /*       lock (thisLock)
                   {
                       counter++;
                       Thread.Sleep(1);
                       Console.WriteLine(counter);
                   }
               }*/









            /*private int count = 0;
            public int Count
            {
                get => count;
            }
            public void Increment()
            {
                count++;
                Thread.Sleep(1); // 1ms 대기
            }
            public void Decrement()
            {
                count--;
                Thread.Sleep(1);
            }*/
        }
        class Program
        {


            static void Main(string[] args)
            {





                /*Counter obj = new Counter();
                Thread th1 = new Thread(obj.Increment);
                Thread th2 = new Thread(obj.Increment);
                Thread th3 = new Thread(obj.Increment);

                th1.Start();
                th2.Start();
                th3.Start();*/
                /*            th1.Join();
                            th2.Join();
                            th3.Join();*//*

                            Console.WriteLine($"obj.Count = {obj.Count}");
                        }*/
            }
        }
    }
}
