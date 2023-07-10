using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayThreeProject
{
    class Class1
    {
        public int num;

        void Calculate(ref int num)
        {
            num = num * num;
            Console.WriteLine($"square is {num}");
        }

        public void DisplayResult()
        {
            Console.WriteLine($"num = {num}");
            Calculate(ref num);
            Console.WriteLine($"num = {num}");
        }

        public void DisplayTotalBill(int pid, string pname, float price, params int[] arr)
        {
            float total = 0;

            Console.WriteLine($" id {pid} name {pname} price {price}");

            foreach (var a in arr)
            {
                total = total + a;
            }
            Console.WriteLine($"Total Bill {total * price}");

        }
    }
}
