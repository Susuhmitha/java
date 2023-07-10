using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayThreeProject2
{
    class Program
    {
        static void Main(string[] args)
        {
            Trainer t1 = new Trainer(1, "sushmitha", ".Net");
            t1.DisplayDetails();
            t1.SaySomething();
            Console.ReadLine();
        }
    }
}
