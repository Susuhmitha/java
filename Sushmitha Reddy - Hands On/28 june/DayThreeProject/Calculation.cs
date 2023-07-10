using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayThreeProject
{
    class Calculation
    {
        public int a, b;
        int c, d, e, f;




        void Calculate(int num1, int num2, out int sum, out int sub, out int mul, out int div)
        {
            sum = num1 + num2;
            sub = num1 - num2;
            mul = num1 * num2;
            div = num1 / num2;

        }

        public void DisplayResult()
        {
            Calculate(a, b, out c, out d, out e, out f);
            Console.WriteLine($"Additon {c} Substraciton {d} Multiplication {e} division {f}");
        }


    }
}
