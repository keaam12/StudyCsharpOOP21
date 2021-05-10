using System;
using System.IO;

namespace FileReadingTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string fullPath = @"C:\Test\Help\PFRO.log";
            StreamReader sr = new StreamReader(new FileStream(fullPath, FileMode.Open));

            while (sr.EndOfStream == false)
            {
                Console.WriteLine(sr.ReadLine());
            }

            sr.Close(); // Open 후 Close 필수!
            // 텍스트파일 읽어오는 부분

            string writePath = @"C:\Test\Help\SMG.txt";
            StreamWriter sw = new StreamWriter(new FileStream(writePath, FileMode.Create));

            sw.WriteLine("Hello, World!");
            sw.WriteLine("안녕하세요");
            sw.WriteLine(3.141592f);
            sw.Close();

            Console.WriteLine("텍스트파일 작성완료!!");
        }
    }
}
