using System;
using System.Collections.Generic;

namespace ClassTestApp
{
    class MainApp
    {


        /* 오버라이딩 
        기반 클래스에서 선언된 메소드를 자식 클래스에서 재정의
        기반 클래스에서 virtual로 한정
        override 한정자로 재선언
         */
        static void Main(string[] args)
        {
            Console.WriteLine("고양이 객체 생성");

            Cat kitty = new Cat();
            kitty.Name = "키티";
            kitty.Age = 3;
            kitty.Color = "하얀색";
            kitty.Meow();

            Cat nero = new Cat();
            nero.Name = "네로";
            nero.Age = 12;
            nero.Color = "검은";
            nero.Meow();

            
            // 기본 생성자 와 추가 생성자
            Cat mimi = new Cat("미미", "노랑", 3);
            mimi.Meow();
            // 생성자를 만들 때 순서를 지켜주기
            Cat coco = new Cat("코코", "얼룩이");
            coco.Age = 2;
            coco.Meow();

            Cat noname = new Cat("은색", 10);
            noname.Name = "야옹이";
            noname.Meow();
            noname.Sleep();

            var list = (First : "Cat", Second : "Dog", Third : "Pig", 55);
            Console.Write($"튜플 첫번째 : {list.First}");
            Console.Write($"튜플 두번째 : {list.Second}");
            Console.Write($"튜플 세번째 : {list.Third}");
            Console.Write($"튜플 세번째 : {list.Item4}");

        }
    }
}
