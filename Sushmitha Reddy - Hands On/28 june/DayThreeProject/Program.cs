using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayThreeProject
{
    class Program
    {
        static void Main(string[] args)
        {
           //Calculation obj = new Calculation() { a = 10, b = 20 };
            //obj.DisplayResult();
            //Console.ReadLine();

            //Class1 obj = new Class1() { num = 10 };
            //obj.DisplayResult();
            //obj.DisplayTotalBill(1, "Pen", 200, 3, 5, 6, 1);
            //obj.DisplayTotalBill(1, "Pen", 200, 3, 5, 6, 1, 2, 2, 2);
            //obj.DisplayTotalBill(1, "Pen", 200, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2);

            Class2 obj = new Class2() { name = "sam", a = 10, b = 20 };
            obj.CallSayHello();
            obj.CallAdd();
            Console.ReadLine();

        }

    }
}
