using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllTasks
{
    class Factorial
    {
        static void Main4(string[] args)
        {

            Console.WriteLine("Enter any Number:");
            int number = Convert.ToInt32(Console.ReadLine());
            int fact = 1;
            for (int i = 1; i <= number; i++)
            {
                fact *= i;
            }
            Console.WriteLine("Factorial of  " + number + "  is  :" + fact);
            Console.Read();
        }
    }
}
