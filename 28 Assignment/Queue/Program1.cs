using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue_Demo
{
    class Program1
    {
        static void Main(string[] args)
        {
            Queue<string> strQ = new Queue<string>();

            strQ.Enqueue("H");

            strQ.Enqueue("e");

            strQ.Enqueue("l");

            strQ.Enqueue("l");

            strQ.Enqueue("o");



            Console.WriteLine("Total elements: {0}", strQ.Count); //prints 5



            if (strQ.Count > 0)
            {

                Console.WriteLine(strQ.Peek()); //prints H

                Console.WriteLine(strQ.Peek()); //prints H

            }



            Console.WriteLine("Total elements: {0}", strQ.Count); //prints 5

            Console.ReadLine();
        }
    }
}