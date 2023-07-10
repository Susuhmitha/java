using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayThreeProject5
{
	public class Program
	{
		public static void Main(string[] args)
		{

			int choice;
			char ch = 'y';

			Class1 obj = new Class1();

			do
			{
				Console.WriteLine("1.Write to file");
				Console.WriteLine("2.Read from file");
				Console.WriteLine("select an option");
				choice = Convert.ToInt32(Console.ReadLine());

				switch (choice)
				{
					case 1:
						obj.WriteToFile();
						break;

					case 2:
						obj.ReadFile();
						break;

					default:
						Console.WriteLine("Invalid choice");
						break;
				}
				Console.WriteLine("Do you want to continue y/n");
				ch = Convert.ToChar(Console.ReadLine());
			}
			while (ch == 'y');


			Console.ReadLine();
		}
}

}
