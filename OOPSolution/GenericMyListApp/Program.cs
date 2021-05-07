using System;

namespace GenericMyListApp
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<int> list = new MyList<int>();
            for (int i = 0; i < list.Length; i++)
            {
                list[i] = i + 1;
            }


            for (int i = 0; i < list.Length; i++)
            {
                Console.Write($"list{i}\t");
            }
        }

        
    }
}
