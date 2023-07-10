using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace CollectionsProject
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList arr = new ArrayList();
            arr.Add(1);
            arr.Add("Hyderabad");
            arr.Add(true);
            arr.Add(123.45f);



            //Auto implemented collections
            ArrayList arr2 = new ArrayList() { 1, "hyderabad", true, 123.45f };



            foreach (var a in arr)
            {
                Console.WriteLine(a);
            }
            for (int i = 0; i < arr.Count; i++)
            {
                Console.WriteLine(arr[i]);
            }
            Console.ReadLine();



        }
    }
}
