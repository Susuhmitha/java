using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayThreeProject2
{
    class Trainer:Employee
    {
        string Subject;

        public Trainer(int id, string name, string Subject) : base(id, name)
        {
            this.Subject = Subject;
            Console.WriteLine("Trainer constructor executor");
        }

        public new void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine($"subject : {Subject}");
        }

        public override void SaySomething()
        {
            Console.WriteLine("SaySomething from Trainer");
        }
    }
}
