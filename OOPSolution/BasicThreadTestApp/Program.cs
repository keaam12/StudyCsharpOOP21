using System;
using System.Threading;

namespace BasicThreadTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // DoSomething();
            Thread th1 = new Thread(DoSomething);  // 대리자에 메서드 이름만 넣어서 해결 // 대리자도 생략 가능
            th1.Start();
            // th1.Join(); // 스레드 종료 대기
            DoOhterthing();
        }

        private static void DoOhterthing()
        {
            for (int i = 0; i < 30; i++)
            {
                Console.WriteLine($"DoOhterthing : {i}");
                Thread.Sleep(10);
            }
        }

        private static void DoSomething()
        {
            for (int i = 0; i < 30; i++)
            {
                Console.WriteLine($"DoSomething : {i}");
                Thread.Sleep(10); // 10ms 대기

            }
        }


    }
}
