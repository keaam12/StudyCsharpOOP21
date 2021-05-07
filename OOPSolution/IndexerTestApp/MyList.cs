using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerTestApp
{
    class MyList : IEnumerable, IEnumerator
    {
        private int[] array;

        private int position = -1; //  배열의 현재 위치값
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

        public object Current => throw new NotImplementedException();

        public MyList()
        {
            array = new int[3]; // 이보다 큰수를 넣지 못하도록 막아주는 역할
        }

        public IEnumerator GetEnumerator()
        {
            yield return this;
        }

        public bool MoveNext()
        {
            position++;
            return (position < array.Length);
        }

        public void Reset()
        {
            position = -1; // 초기화        }
        }
    }
}
