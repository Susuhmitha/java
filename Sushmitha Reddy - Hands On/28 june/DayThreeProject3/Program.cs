using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayThreeProject3
{
    class Program
    {
        static void Main(string[] args)
        {
            Test obj = new Test();
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            obj.Divide(num1, num2);
            Console.ReadLine();
        }
    }
}
