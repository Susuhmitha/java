using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondayProject
{
    class Mobile
    {
        int mid;
        string name;
        float price;

        public Mobile()
        {
            Console.WriteLine("Default Constructor");
        }

        public Mobile(int mid, string name, float price)
        {
            this.mid = mid;
            this.name = name;
            this.price = price;
        }
        public void AcceptDetails()
        {
            Console.WriteLine("Enter mobile ID");
            mid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter mobile Name");
            name = Console.ReadLine();
            Console.WriteLine("Enter mobile Price");
            price = Convert.ToSingle(Console.ReadLine());



            Console.WriteLine("Acceptdetails executed");
        }

        public void DisplayDetails()
        {
            Console.WriteLine("Mobile id {0} Name {1} price {2}", this.mid, this.name, this.price);
            Console.WriteLine($"Mobile id {this.mid} Name {this.name} price {this.price}");
            Console.WriteLine("Display details executed");
        }
    }
}
