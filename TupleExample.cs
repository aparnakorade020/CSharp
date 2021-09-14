using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllTasks
{
    class TupleExample
    {

        static void Main_10(string[] args)
        {
            //Example for use of Tuple
            var mytuple = Tuple.Create(1, "aparna", "xyz", 63.20, 25000, true, "Location_Pune", "Zensar");
            Console.WriteLine(mytuple.Item1);
            Console.WriteLine(mytuple.Item2);
            Console.WriteLine(mytuple.Item3);
            Console.WriteLine(mytuple.Item4);
            Console.WriteLine(mytuple.Item5);
            Console.WriteLine(mytuple.Item6);
            Console.WriteLine(mytuple.Item7);
            Console.WriteLine(mytuple.Rest);

            //mytuple.Item1 = 2; // we cannot change value because tuple is read only

            Console.Read();

        }
    }
}