using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTestApp
{
    class Cat : Animal
    {
        //생성자와 종료자//
       // public string Name{get; set;}
        public string Color{get; set;}
        public int Age { get; set; }

        public Cat() {/* Nothing */ }

        //추가 생성자
        public Cat(string name, string color, int age)
        {

            //intalization 초기화

            this.Name = name;
            this.Color = color;
            this.Age = age;

        }
        public Cat(string name, string color)
            {
            this.Name = name;
            this.Color = color;
            }
        public Cat(string color, int age)
        {
            this.Color = color;
            this.Age = age;
        }
        public void Meow() { Console.WriteLine($"{this.Color} {this.Name} 야옹!");  }

        public override void Sleep()
        {
          //  base.Sleep();  부모의 Sleep() 실행
          // 이후 자식 클래스의 Sleep내용 실행
            Console.WriteLine($"{this.Color} 고양이 {this.Name}이(가) ZZ잡니다!");
            // base.method가 없다면 override만 나온다.
            // 부모가 일을 처리 + 자식이 일을 처리

        }

    }
}
