using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegaateTestApp
{
    delegate int MyDelegate( int a, int b);
    class Calculator
    {
        public int Plus(int a, int b)
        {
            return a + b;
        }
        public static int Minus(int a, int b)
        {
            return a - b;
        }
    } 
}

