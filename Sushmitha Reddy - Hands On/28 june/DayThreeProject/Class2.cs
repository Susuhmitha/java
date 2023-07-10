using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyClassLibrary;

namespace DayThreeProject
{
    class Class2
    {
        Mat obj = new Mat();
        public string name;
        public int a, b;
        public void CallSayHello()
        {
            obj.SayHello(name);

        }

        public void CallAdd()
        {
            Console.WriteLine($"Result is {obj.Add(a, b)}");
        }
    }
}
