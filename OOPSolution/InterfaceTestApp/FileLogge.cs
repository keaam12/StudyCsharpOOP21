using System;
using System.Diagnostics;

namespace InterfaceTestApp
{
    class FileLogger : ILogger // Ver 1.0 개발
    {
        public void WriteError(string error)
        {
            Debug.WriteLine($"File error: {error}");
        }

        public void WriteLog(string message)
        {
            Console.WriteLine($"파일 txt.log에 저장 : {message}");
        }
    }
}
