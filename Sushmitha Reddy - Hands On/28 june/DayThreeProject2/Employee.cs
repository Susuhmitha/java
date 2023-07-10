using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayThreeProject2
{
    class Employee
    {
        int id;
        string name;

        public Employee(int id, string name)
        {
            this.id = id;
            this.name = name;
            Console.WriteLine("Employee constructor executor");
        }

        public void DisplayDetails()
        {
            Console.WriteLine($"id : {this.id} name : {this.name}");
        }

        public virtual void SaySomething()
        {
            Console.WriteLine("SaySomething from Employee class");
        }
    }

}
