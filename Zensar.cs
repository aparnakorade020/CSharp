using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllTasks
{
    class Zensar
    {
        public static void IFutureMethod()
        {
            Console.WriteLine("IFutureMethod method");
        }
        public void ZensarMethod(string v)
        {
            first();
            Console.WriteLine("ZensarMethod method");
        }

        public void first()
        {

        }

        public void ZensarMethod(int i)
        {
            Console.WriteLine(i);
            ZensarMethod();
        }

        private void ZensarMethod()
        {
            throw new NotImplementedException();
        }
    }
    class program
    {
        public static void Main_0000()
        {
            sample obj = new sample();
            obj.first();
            obj.ZensarMethod("Aparna");
            Console.Read();
        }
    }