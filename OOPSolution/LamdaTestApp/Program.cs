using System;

namespace LamdaTestApp
{
    class Program
    {
        delegate void DoSomething(string name);
        delegate string Concatenate(string[] arr);
        static void Main(string[] args)
        {
            DoSomething doIt = (name) =>
            {
                Console.WriteLine("Hello, ");
                Console.WriteLine($"{name} Doe~!");
            }; // void는 return 값이 없는 것! ==> return이 생략되는 것이다.
            string name = "Hugo";

            doIt(name);

            Concatenate concat = (arr) =>
            {
                string result = "";
                foreach (var item in arr)
                {
                    result += item;
                }
                return result;
            };

            string[] strarr = { "아버지가 ", "방에 ", "들어가신다." };
            Console.WriteLine(concat(strarr));

            Func<int> func = () => 3;


            var val = func();
            Console.WriteLine($"val의 값은 {val}.");

            Func<int, int, int> plus = (x, y) => x + y;
            Console.WriteLine($"3 + 5 = {plus(3, 5)}");

            Action<int> area = (r) =>
            {
                Console.WriteLine($"원의 넓이는 {(double)r * r * Math.PI}");
            };

            area(10);
        }
    }
}
