﻿using System;
using System.Threading;
using System.Threading.Tasks;

namespace TaskTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var myTask = Task.Run(() =>
            {
                Thread.Sleep(1000); // 1초동안 작업이 처리됨(대규모일)
                Console.WriteLine("비동기 처리 완료!");
            });

            var sum = 0;
            

            for (int i = 0; i < 100; i++)
            {
                sum += 1;
            }
            Console.WriteLine($"메인스레드 동기처리 : {sum}");
            myTask.Wait(); // 비동기 호출이 완료될때까지 대기
        }
    }
}
