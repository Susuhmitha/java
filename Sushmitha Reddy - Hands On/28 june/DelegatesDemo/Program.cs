using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.Add \n 2.Substract \n 3. Divide \n Multiply");
            int choice = Convert.ToInt32(Console.ReadLine());

            CalcuateDelegate delobj;
            Class1 obj = new Class1();
            int result;

            switch (choice)
            {
                case 1:
                    delobj = new CalcuateDelegate(obj.Add);
                    result = delobj.Invoke(12, 34);
                    Console.WriteLine($"Result {result}");
                    break;
                case 2:
                    delobj = new CalcuateDelegate(obj.Subs);
                    result = delobj.Invoke(12, 34);
                    Console.WriteLine($"Result {result}");
                    break;
                case 3:
                    delobj = new CalcuateDelegate(obj.Multiply);
                    result = delobj.Invoke(12, 34);
                    Console.WriteLine($"Result {result}");
                    break;
                case 4:
                    delobj = new CalcuateDelegate(obj.Divide);
                    result = delobj.Invoke(12, 34);
                    Console.WriteLine($"Result {result}");
                    break;

            }
            Console.ReadLine();
        }
    }
}
