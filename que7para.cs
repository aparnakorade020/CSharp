using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllTasks
{
    class que7para
    {

        public static void Main3(string[] args)
        {
            //Example for use of Params parameter
            NamesDisplay("abc", "Pune");
            NamesDisplay("aparna", "xyz", "nager", "India", "4595258");

            Console.Read();

        }

        private static void NamesDisplay(params string[] parameters)
        {
            Console.WriteLine("Employee Details are as follows:");

            foreach (var item in parameters)
            {
                Console.WriteLine(item);
            }

        }
    }
}