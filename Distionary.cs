using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllTasks
{
    class Distionary
    {
        public static void Main1(string[] args)
        {

            Dictionary<int, string> d = new Dictionary<int, string>();
            d.Add(1, "2020");
            d.Add(2, "aparna");
            d.Add(3, "PUNE");
            d.Add(4, "458625");

            foreach (KeyValuePair<int, string> D in d)
            {
                Console.WriteLine("Key: {0}, Value: {1}", D.Key, D.Value);
            }

            Console.WriteLine("Enter key ");
            int a = Convert.ToInt32(Console.ReadLine());
            if (!d.ContainsKey(a))
            {
                Console.WriteLine("Key does not exist");

            }
            else
            {
                d.Remove(a);
                Console.WriteLine("Key Removed  and new Collection is:");
            }


            foreach (KeyValuePair<int, string> D in d)
            {
                Console.WriteLine("Key: {0}, Value: {1}", D.Key, D.Value);
            }


            Console.Read();

        }
    }
}