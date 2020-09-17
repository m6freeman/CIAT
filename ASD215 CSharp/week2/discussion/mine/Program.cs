using System;
using System.Linq;
using System.Collections.Generic;

namespace discussion
{
    class Program
    {
        // The overarching goal of this class is to iterate over a collection
        // and identify duplicate entries. There are various ways to accomplish
        // the same goal, and often times a functional approach can be far more
        // efficient than a proceedural approach. In order to leverage some of
        // C#'s more functional behavior, we'll start by substituting the
        // System.Collections for System.Collections.Generic because we want access
        // to the generic type List<T>, as well as System.Linq.

        // An ArrayList is a collection type used historically for general purpose
        // collections that implements the IList interface, can store the values of
        // different data types or same datatype, and can increase or decrease its
        // size dynamically.

        // Alternatively, an Array must be declared with a specific
        // datatype, have a fixed length that cannot be changed during
        // runtime, and does not implement the IList interface meaning it doesn't
        // allow us to invoke a Add() method to modify its contents.

        // What we're interested in working with, however, is the generic type List<T>.
        // This type was implemented in C# to replace ArrayList in favor of a more
        // generic approach. List<T>s have the added benefit of implementing the
        // IEnumerable interface, meaning we can ask the List for its next item instead
        // of manually accessing each index individually. This can be leveraged to apply
        // lambda functions on the items, performing sorting, grouping, filtering, ect.
        // type tasks.


        // The first functionality we need this class to perform is simply displaying the contents of a list.
        // By using Lists, we can leverage the IEnumerable ForEach function and pass WriteLine to each item.
        // We must declare these methods statically because the Main method of our Program class is Static
        public static string DisplayArray(List<int> numbers) => string.Join(", ", numbers);


        // Secondly, we want to identify and return a new list of any duplicate entries in the first list
        // To do this, we'll take our input List<int>, group by like numbers if there is more than one occurrence
        // and add those reoccuring numbers to a new list called queryToGetDuplicates. This is done with a Language-
        // Integrated Query (LINQ) expression. LINQ is a technology added to C# that allows us to use querying statements
        // against collection types implementing the IEnumerable interface (like List<int>, but can also be used for database
        // entities) with the use of functions. If you've taken SQL before, these function names should look familiar.
        public static void FindDuplicate(List<int> numbers)
        {
            var queryToGetDuplicates = numbers.GroupBy(x => x)
              .Where(y => y.Count() > 1)
              .Select(z => z.Key)
              .ToList();

            Console.WriteLine("The duplicate numbers are " + DisplayArray(queryToGetDuplicates));
            ;
        }

        public static void GinosSolution(List<int> list)
        {
            //List<int> list = new List<int>() { 4, 5, 2, 5, 4, 7 };

            HashSet<int> hashset = new HashSet<int>();

            IEnumerable<int> duplicates = list.Where(e => !hashset.Add(e));

            Console.WriteLine("The number which are duplicates are: " + string.Join(",", duplicates));
        }


        static void Main(string[] args)
        {
            List<int> ourList = new List<int>
            {
                4, 5, 2, 5, 4, 7
            };

            var watch = System.Diagnostics.Stopwatch.StartNew();
            for (int i = 0; i < 2_000_000; i++) FindDuplicate(ourList);
            //for (int i = 0; i < 2_000_000; i++) GinosSolution(ourList);
            watch.Stop();
            Console.WriteLine(watch.ElapsedMilliseconds);
        }
    }
}