using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesDemo
{
    public class Class2
    {
        [Obsolete]
        public void Function1()
        {
            Console.WriteLine("Function1 executed");
        }

        public void Function2()
        {
            Console.WriteLine("function2 execute");
        }
        static void Main(string[] args)
        {
            Class2 obj = new Class2();
            obj.Function1();
            Console.ReadLine();
        }
        
    }
    


}
