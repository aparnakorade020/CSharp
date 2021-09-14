using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllTasks
{

    public enum Days
    {
        Sun = 1,
        Mon,
        Tue,
        Wed,
        Thur,
        Fri,
        Sat
    }

    class EnumEx
    {

        public static void Main2(string[] args)
        {
            Console.WriteLine("Enter a value between 1 to 7:");


            int d = Convert.ToInt32(Console.ReadLine());

            Days WeekDays = new Days();

            WeekDays = (Days)d;

            switch (d)
            {
                case 1:
                    Console.WriteLine("Today is Sunday");
                    break;

                case 2:
                    Console.WriteLine("Today is Monday");
                    break;

                case 3:
                    Console.WriteLine("Today is Tuesday");
                    break;

                case 4:
                    Console.WriteLine("Today is Wednesday");
                    break;

                case 5:
                    Console.WriteLine("Today is Thursday");
                    break;

                case 6:
                    Console.WriteLine("Today is Friday");
                    break;

                case 7:
                    Console.WriteLine("Today is Saturday");
                    break;

                default:
                    Console.WriteLine("You have entered a wrong input!!!");
                    break;
            }

            Console.Read();

        }

    }
}

