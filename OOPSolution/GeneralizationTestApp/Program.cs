using System;

namespace GeneralizationTestApp
{
    class Program


    {  /* 추상화와 비슷하다. 공통된 것을 찾는 것
         
         
         
        
        */
       

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

            CopyArray(sourceInt, targetInt);

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

            CopyArray(sourceFloat, targetFloat);

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

            CopyArray(sourceString, targetString);

            Console.WriteLine("복사 후 tagetFloat값 ======>");
            foreach (var item in targetString)
            {
                Console.Write($"{item}\t");
            }

            Console.WriteLine();
        }

        private static void CopyArray(string[] source, string[] target)
        {
            for (int i = 0; i < source.Length; i++)
            {
                target[i] = source[i];
            }
        }
            private static void CopyArray(float[] source, float[] target)
        {
            for (int i = 0; i < source.Length; i++)
            {
                target[i] = source[i];
            }
        }

            private static void CopyArray(int[] source, int[] target)
        {
            for (int i = 0; i < source.Length; i++)
            {
                target[i] = source[i];
            }        }
    }
}
