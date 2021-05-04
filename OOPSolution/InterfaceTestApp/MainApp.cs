using System;

namespace InterfaceTestApp
{
    class MainApp
    {
        static void Main(string[] args)
        {
            Console.WriteLine("콘솔로거 사용합니다.");

            ConsoleLogger logger = new ConsoleLogger();
            logger.WriteLog("기본 콘솔 로그입니다.");
            logger.WriteError("에러메시지!!!!!");
            ILogger clmLogger = new FileLogger();  // ver 1.0 ClimateLogger --> 1.2 FileLogger 변경
            clmLogger.WriteLog("맑음");
            clmLogger.WriteError("문제발생!");

            ILogger logger2 = new ClimateLogger();
            logger2.WriteLog("흐릠//");
            //Logger.WriteError는 실행오류 발생
        }
    }
}
