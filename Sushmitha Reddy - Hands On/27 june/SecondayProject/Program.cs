using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondayProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Mobile m = new Mobile();
            m.AcceptDetails();
            m.DisplayDetails();
            Console.ReadLine();
        }
    }
}
