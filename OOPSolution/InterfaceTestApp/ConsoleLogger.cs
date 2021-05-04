using System;
using System.Diagnostics;

namespace InterfaceTestApp
{
    class ConsoleLogger : ILogger
    {
        public void WriteError(string error)
        {
            Debug.WriteLine($"에러 : {error}");
        }

        public void WriteLog(string message)
        {
            // 구햔 안됐다고 말해주는 것! (일부러 발생시키는 것)
            // throw new NotImplementedException();
            Console.WriteLine($"로그 {DateTime.Now} : { message}");
            // new를 안하는 예외사항

        }
    }
}
