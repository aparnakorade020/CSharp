using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllTasks
{
    class thirdbignumber
    {

        public static void Main6(string[] args)
        {
            //Create an array of 10 numbers and print the 3rd highest no.

            int[] Numbers = new int[10];
            Console.WriteLine("Enter Numbers:");

            for (int i = 0; i < 10; i++)
            {
                int n = Convert.ToInt32(Console.ReadLine());
                Numbers[i] = n;
            }

            ThirdHighestNo(Numbers);

            Console.Read();

        }

        static void ThirdHighestNo(int[] Numbers)
        {
            int max1 = int.MinValue;
            int max2 = int.MinValue;
            int max3 = int.MinValue;

            foreach (int item in Numbers)
            {
                if (item > max1)
                {
                    max3 = max2;
                    max2 = max1;
                    max1 = item;
                }
                else if (item > max2)
                {
                    max3 = max2;
                    max2 = item;
                }
                else if (item > max1)
                {
                    max3 = item;
                }
            }
            Console.WriteLine("Third Highest Number is:" + max3);

        }
    }
}