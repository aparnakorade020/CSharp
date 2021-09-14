using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllTasks
{
    class table
    {
        static void Main_1(string[] args)
        {

            Console.WriteLine(" Multiplication table for the number accepted by user");
            Console.WriteLine("Enter any Number:");
            int number = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= 20; i++)
            {
                Console.WriteLine("{0} x {1} = {2}", number, i, number * i);
            }

            Console.Read();


        }
    }
}
