using System;
using System.Drawing;

namespace PropertyTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("강아지객체 생성");
            Dog baekgoo = new Dog();
            // baekgoo.SetAge(5); // 5살


            baekgoo.Name = "백구";
            baekgoo.Age = 25000;
            Console.WriteLine($"백구의 나이는 {baekgoo.Age}세");

            /* Console.WriteLine($"백구의 나이는 {baekgoo.GetAge()}"); */



            Dog streetDog = new Dog();
            Console.WriteLine($"{streetDog.Name}는 {streetDog.Color}색입니다.");


            Dog dog1 = new Dog();
            dog1.Name = "황구";
            dog1.Color = "노랑";
            dog1.Age = 10;



           /* Dog dog = new Dog();
            {
                Age = 5,
                Name = "깜장이",
                Color = "검정" 
            }; */

            // 자바는 getname, setname을 다 해주지만 C#은 get;set; === property 형태로 할 수 있다.

            var myInstance = new { Name = "박상현", Age = 44 };
            Console.WriteLine(myInstance.Name);
            Console.WriteLine(myInstance.Age);

        }
    }
}
