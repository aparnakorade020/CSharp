using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllTasks
{
    class SortedList
    {

        public static void Main_4(string[] args)
        {
            //SortedList of int keys, string values

            var descendingComparer = Comparer<int>.Create((x, y) => y.CompareTo(x));

            SortedList<int, string> descSortedList = new SortedList<int, string>(descendingComparer);
            descSortedList.Add(1200, "CSharp");
            descSortedList.Add(1400, "Python");
            descSortedList.Add(456, "Java");
            descSortedList.Add(1900, "JavaScript");
            descSortedList.Add(1500, "SQL");

            for (int i = 0; i < descSortedList.Count; i++)
            {
                Console.WriteLine("Rank: {0} - {1} ", i + 1, descSortedList.Values[i]);
            }

            Console.Read();

        }

    }
}

//OUTPUT:-  Rank: 1, - JavaScript
//          Rank: 2, - SQL
//          Rank: 3, - Python
//          Rank: 4, - CSharp
//          Rank: 5, - Java


