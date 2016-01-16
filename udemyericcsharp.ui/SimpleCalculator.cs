using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyEricCsharp
{
    class SimpleCalculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
        public int Square(int a)
        {
            return a * a;
        }
        public int Maxthree(int a, int b, int c)
        {
            if (a>b && a>c)
            {
                return a;
            }
            else if (b>a && b>c)
            {
                return b;
            }
            else
            {
                return c;
            }
        }
    }
}
