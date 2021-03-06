using System;
using System.Collections;

namespace CollectionTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 123;
            object obj = a;
            int b = (int) obj;

            Console.WriteLine("a의 타입 : " + a);
            Console.WriteLine("obj의 타입 : " + obj);
            Console.WriteLine("b의 값 : " + b);

            string str = "문자열임";
            obj = str;

            Console.WriteLine("str의 값 :" + str);
            Console.WriteLine("obj의 값 :" + obj);
            //




            Console.WriteLine("ArrayList 예제");

            ArrayList list = new ArrayList(); // 사이즈 지정 X (Array는 O)
            list.Add(3);
            list.Add(67);
            list.Add(14);
            list.Add(30);
            list.Add(14);

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            list.Sort();

            foreach (var item in list)

            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine();

            list.Reverse();
            foreach (var item in list)

            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine();

            list.Add(100);
            foreach (var item in list)

            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine();

            list.Insert(2, 88);
            foreach (var item in list)

            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine();

            list.RemoveAt(5);
            foreach (var item in list)

            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine();

            int index100 = list.IndexOf(100);
            Console.WriteLine($"100의 위치 : {index100}");


            list.Remove(5);
                 foreach (var item in list)

            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine();

            int index14 = list.IndexOf(14);
            Console.WriteLine($"14의 위치값 : {index14}");

            int lstIndex14 = list.LastIndexOf(14);
            Console.WriteLine($"마지막 14의 위치값 : {lstIndex14}");

            Console.WriteLine($"총 갯수 {list.Count}");
            Console.WriteLine($"리스트 마지막 값 {list[list.Count - 1]}");

            list.Add(135);
            list.Add(14);
        }


    }
}
