using System;

namespace EventHandlerTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("3,6,9 3,6,9! !");

            MyNotifer notifier = new MyNotifer();
            notifier.SomethingHappened += new EventHandler(MyHandler);

            for (int i = 1; i <= 100; i++)
            {
                notifier.DoSomething(i);
            }

        }

        private static void MyHandler(string message)
        {
            Console.WriteLine(message);
        }
    }
}
