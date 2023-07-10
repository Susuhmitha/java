using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    class Program
    {
        //  int a, b, c;
        //  public void divide(int a,int b)
        //  {
        //     int result = a / b;
        //     Console.WriteLine($"result is {result}");
        // }
        static void Main(string[] args)
        {
            Test obj = new Test();
            Console.WriteLine("enter the number 1");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the number 2");
            int num2 = Convert.ToInt32(Console.ReadLine());
            obj.divide(num1, num2);


        }
    }
}