using System;
using System.Threading;

namespace UsingInterfaceTestApp
{
    class MainApp
    {
        static void Main(string[] args)
        {
            //이전생략 3000라인
            var monitor1 = new ExtendedMonitor(new ConsoleLogger(DateTime.Now));
            monitor1.PrintLog("콘솔로그입니다!");
            var monitor = new ExtendedMonitor(new FileLogger("210504.log"));
            monitor.PrintLog("로그내용입니다!");

            Thread.Sleep(1000); // 시간딜레이 1000ms == 1sec

            monitor.PrintLog("이하 오류가 발생했습니다.");

            Console.WriteLine("프로그램종료");

        }
    }
}
