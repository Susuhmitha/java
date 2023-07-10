using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CollectionProject
{
    class Class1
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>() { "one", "two", "three", "four" };
            foreach(var s in names)
            {
                Console.WriteLine(s);
            }
            Console.ReadLine();

        }
    }
}
