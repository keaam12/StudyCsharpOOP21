using System;

namespace DelegaateTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator Calc = new Calculator();
            MyDelegate Callback;

            Callback = new MyDelegate(Calc.Plus);
            Console.WriteLine(Callback(3, 4));

            CalcDelegate callBack;
            callBack = new CalcDelegate(Calc.Plus);
            Console.WriteLine($"3 + 5 = ")
        }
    }
}
