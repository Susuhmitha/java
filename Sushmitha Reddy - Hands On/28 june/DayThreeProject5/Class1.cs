using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace DayThreeProject5
{
    public class Class1
    {
        public void WriteToFile()
        {
            Console.WriteLine("Enter employee id");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter employee Name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter employee Salary");
            float sal = Convert.ToSingle(Console.ReadLine());


            Employee emp = new Employee() { Empid = id, EName = name, Salary = sal };

            FileStream fs = new FileStream("xmlFilename.xml", FileMode.OpenOrCreate, FileAccess.Write,
            FileShare.None);


            XmlSerializer employeeSerializer = new XmlSerializer(typeof(Employee));
            employeeSerializer.Serialize(fs, emp);

            Console.WriteLine("Object saved into file");
        }


        public void ReadFile()
        {
            FileStream fs2 = new FileStream("xmlFilename.xml", FileMode.OpenOrCreate, FileAccess.Read,
            FileShare.None);

            Employee emp2 = new Employee();

            XmlSerializer employeeSerializer2 = new XmlSerializer(typeof(Employee));
            emp2 = (Employee)employeeSerializer2.Deserialize(fs2);
            Console.WriteLine($"Employee Id : {emp2.Empid}");
            Console.WriteLine($"Name : {emp2.EName}");
            Console.WriteLine($"Salary : {emp2.Salary}");



        }
    }
}
