using System;

namespace GenericTestApp2
{
    class Program
    {
        private static void CopyArray<T>(T[] source, T[] target) // 일반화 메서드 통일
        {
            for (int i = 0; i < source.Length; i++) // T가 무엇이든 상관없다

            {
                target[i] = source[i];
            }
        }
        static void Main(string[] args)
        {
            int[] sourceInt = { 1, 2, 3, 4, 5 };
            int[] targetInt = new int[sourceInt.Length]; // 5짜리 int 배열

            Console.WriteLine("복사 전 tagetInt값 ======>");
            foreach (var item in targetInt)
            {
                Console.Write($"{item}\t");
            }

            Console.WriteLine();

            CopyArray<int>(sourceInt, targetInt);

            Console.WriteLine("복사 후 tagetInt값 ======>");
            foreach (var item in targetInt)
            {
                Console.Write($"{item}\t");
            }

            Console.WriteLine();

            float[] sourceFloat = { 1.2f, 2.3f, 3.4f, 4.5f, 5.6f };
            float[] targetFloat = new float[sourceFloat.Length];
            Console.WriteLine("복사 전 tagetFloat값 ======>");
            foreach (var item in targetFloat)
            {
                Console.Write($"{item}\t");
            }

            Console.WriteLine();

            CopyArray<float>(sourceFloat, targetFloat);

            Console.WriteLine("복사 후 tagetFloat값 ======>");
            foreach (var item in targetFloat)
            {
                Console.Write($"{item}\t");
            }

            Console.WriteLine();


            string[] sourceString = { "하나", "둘", "셋", "넷", "다섯" };
            string[] targetString = new string[sourceString.Length];

            Console.WriteLine("복사 전 tagetString값 ======>");
            foreach (var item in targetString)
            {
                Console.Write($"{item}\t");
            }

            Console.WriteLine();

            CopyArray<string>(sourceString, targetString);

            Console.WriteLine("복사 후 tagetString값 ======>");
            foreach (var item in targetString)
            {
                Console.Write($"{item}\t");
            }

            Console.WriteLine();
        }
    }
}
