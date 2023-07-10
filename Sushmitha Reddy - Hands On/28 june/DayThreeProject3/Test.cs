using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayThreeProject3
{
    public class Test
    {
        public int a;
        public int b;
        int c;



        public void Divide(int num1, int num2)
        {
            try
            {
                int div = num1 / num2;
                Console.WriteLine(div);
                
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                
            }
        }



    }


}
