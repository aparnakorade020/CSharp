using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdPartyLibrary
{
    public class Student
    {

        public readonly int discount;

        public string FullName { get; set; }

        public string Mymethod()
        {
            return "This is from DLL";
        }



        public Student()
        {

            discount = 12000;

        }
    }
}