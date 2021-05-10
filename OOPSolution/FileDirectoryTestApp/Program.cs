using System;
using System.IO;

namespace FileDirectoryTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            /*string path = @"C:\Windows"; // Verbatim 스트링
            var dirs = Directory.GetDirectories(path);

            foreach (var item in dirs)
            {
                Console.WriteLine(item);
                var dirInfo = new DirectoryInfo(item);
                Console.WriteLine($"{dirInfo.Name} / {dirInfo.Attributes} / {dirInfo.CreationTime}");
            }

            var files = Directory.GetFiles(path);
            foreach (var item in files)
            {
                Console.WriteLine(item);
                var fileInfo = new FileInfo(item);
                Console.WriteLine($"{fileInfo.Name} / {fileInfo.Attributes} / {fileInfo.CreationTime}/ {fileInfo.Length}");
            } */


            string Newpath = @"C:\Test\Help"; // 디렉토리, 파일을 생성할 위치

            int dirNum  = 0;
            Console.WriteLine("file / dir을 입력하세요(종료는 X)");

            while (true) // 무한반복 프로그램
            {
                var input = Console.ReadLine();

                if (input == "X")
                {
                    break;
                }
                else
                {
                    if (input == "file")
                    {
                        var fileName = $"Samplefile_{DateTime.Now.ToString("yyMMddHHmmss")}.txt";
                        var fullpath = $@"{Newpath}\{fileName}";
                        File.Create(fullpath);
                        Console.WriteLine("파일생성");
                    }
                    else if (input == "dir")
                    {
                        // Console.WriteLine("디렉토리생성");
                        var dirName = "SampleDirectory";
                        var fullPath = $@"{Newpath}\{dirName}"; // @"C:\Test\Help"
                        if (Directory.Exists(fullPath))
                        {
                            Directory.CreateDirectory(fullPath);
                        }
                        else
                        {
                            dirNum++;
                            fullPath = $@"{Newpath}\{dirName}{dirNum}";
                        }

                     }
                    else
                    {
                        Console.WriteLine("file / dir로 값을 입력하세요");
                    }
                }
                Console.WriteLine("프로그램 종료");
            }
            


        }
    }
}
