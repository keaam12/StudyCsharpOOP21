using System;

namespace DelegateChainApp
{
    delegate int Calculate(int a, int b); // 계산 대리자를 선언

        class Program
    {
        static void Main(string[] args)
        {
            #region

            Calculate calc;
            calc = delegate (int a, int b)
            {
                return a + b;
            };
            Console.WriteLine($"a + b = {calc(3, 5)}"); //하나의 메서드


            /// 무명함수 표현 1 = 일반식
            /// *calc = delegate (int a, int b)
            /// {
            /// return a + b;
            /// 무명함수 표현 2 = 람다식
            /// calc = (a, b) => a + b;
            /// Console.WriteLine($"a+b=(calc);")








            /*FireStation station = new FireStation();

            ThereIsAFire FireHouse = new ThereIsAFire(station.Call119);
            FireHouse += new ThereIsAFire(station.ShotOut);
            FireHouse += new ThereIsAFire(station.Escape);
            FireHouse("우리집");


            // ㄲㄲ
            ThereIsAFire fireWoorim = new ThereIsAFire(station.Call119);
            fireWoorim += new ThereIsAFire(station.Escape);

            fireWoorim("우림라이온밸리A"); */
        }
    }
}
#endregion