using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    class Test
    {
        int a, b, c;
        public void divide(int a, int b)
        {
            try
            {

                int result = a / b;
                Console.WriteLine($"result is {result}");
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.ReadLine();

            }
        }
    }
}