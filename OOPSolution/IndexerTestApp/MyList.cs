using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerTestApp
{
    class MyList
    {
        private int[] array;
        public int this[int index] // == Mylist[i] = array[i]
        {
            get
            {
                return array[index];
            }
            set
            {
                if (index >= array.Length) // 하나씩 증가
                {
                    Array.Resize(ref array, index + 1);
                    Console.WriteLine($"Array resized : {array.Length}");
                }
                array[index] = value;
            }
        }


        public int Length
        {
            get { return array.Length; }
        }
        public MyList()
        {
            array = new int[3]; // 이보다 큰수를 넣지 못하도록 막아주는 역할
        }
    }
}
