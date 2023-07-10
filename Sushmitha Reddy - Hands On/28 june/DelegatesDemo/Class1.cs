using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesDemo
{
    public delegate int CalcuateDelegate(int a, int b);
    public class Class1
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
        public int Subs(int a, int b)
        {
            return a + b;
        }
        public int Multiply(int a, int b)
        {
            return a * b;
        }
        public int Divide(int a, int b)
        {
            return a / b;
        }

    }
}
