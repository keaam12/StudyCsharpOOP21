using System;

namespace ExceptionTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("프로그램 시작");

            int[] list = { 107, 100, 109 };

                try
                {
                    var result = list[i] / 0;
                    for (int i = 0; i < 5; i++)
                    {
                        Console.WriteLine(list[i]);
                    }
                }
                catch (IndexOutOfRangeException ex)
                {
                    //예외 발생시 다른일 처리
                    Console.WriteLine(ex.Message);
                    Console.WriteLine($"예외발생 {ex.Message}, : Main(16~)");
                    Console.WriteLine("IndexOoutOfRangeException 이후 처리!");
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine($"예외발생 : {ex.Message}");
                    Console.WriteLine("DivdeByZeroException 이후 처리!!");
                }

            // exception 만으로 모든 예외 처리 가능
            // 다양한 case로 나누기 위해서 필요!



            finally
            {

            }
                Console.WriteLine("다른 로직 수행");

                Console.WriteLine("프로그램 종료!");
                }
            }
        }
    