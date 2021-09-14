using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThirdPartyLibrary;

namespace AllTasks
{
    class Program1ExeDllDemo
    {

        public static void Main_5(string[] args)
        {
            //Program for displaying message in exe from dll and adding a third party reference DLL 

            //Method accessing from dll
            Student s = new Student();
            Console.WriteLine(s.Mymethod());

            Console.WriteLine("Hello This a demo program for exe and DLL...!!!!");
            Console.WriteLine("Thank You..!");
            Console.Read();

        }

    }
}
//OUTPUT:
//This is from DLL
//Hello This a demo program for exe and DLL...!!!!
//Thank You..!



