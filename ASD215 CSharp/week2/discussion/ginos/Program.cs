using System;
using System.Collections.Generic;
using System.Linq;
using static System.Console;


namespace ginos
{
    public class Example

    {

        public static void Main()
        {

            List<int> list = new List<int>() { 4, 5, 2, 5, 4, 7 };

            HashSet<int> hashset = new HashSet<int>();

            IEnumerable<int> duplicates = list.Where(e => !hashset.Add(e));

            WriteLine("The number which are duplicates are: " + String.Join(",", duplicates));

        }

    }
}
