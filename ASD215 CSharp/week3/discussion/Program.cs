using System;
using System.Collections;
using System.Collections.Generic;

namespace discussion
{
    class Program
    {
        static void Main()
        {
            // Arrays are immutable (unable to be changable after established), strongly typed
            // collections for a single type of data. All data types in C#, whether predefined
            // or user-defined, reference types or value types, inherit directly or indirectly
            // from Object. If you want an array to accept various types, you could declare
            // your array as an array of objects, however this is not the best practice.

            // Arrays should be used when you have a simple list of similar datatypes you know you know you need to READONLY from

            // Establish our array of integers
            int[] ourArray = new int[] { 1, 2, 3, 4, 5 };
            // Iterate over each item in our array and write it to the console.
            foreach (var item in ourArray) Console.Write(item + " ");                                       // RESULT: 1 2 3 4 5
            Console.WriteLine();



            // ArrayLists are mutable and implement the IList interface. They can accept various
            // types. ArrayLists would be preferable over object[] if you need to store different
            // types within the same array.

            // ArrayLists should be used when you have abstract lists of various datatypes that you may need to modify/add to later

            // Establish our ArrayList
            ArrayList ourArrayList = new ArrayList();
            // Append the previous array of integers...
            ourArrayList.AddRange(ourArray);
            // And add another element of type string, demonstrating how ArrayList can hold different types
            ourArrayList.Add("six");
            // Iterate over each item in our ArrayList and write it to the console.
            foreach (var item in ourArrayList) Console.Write(item + " ");                                   // RESULT: 1 2 3 4 5 six
            Console.WriteLine();

            // Hashtables are vastly different from Arrays and ArrayLists. Hashtables implement the IDictionary
            // interface, but unlike a Dictionary<T,T> which is a generic type, Hashtable entries are of type
            // DictionaryEntry (a nongeneric Key,Value pair that may represent any type). Hashtables are also
            // unsorted, instead organizing their entries interally based on the Hash representation of their values.
            // As an aside, .NET Core Hashtables differ from .NET Framework Hashtables slightly: string hashes are
            // generated randomly each program execution in Core. This is done for security purposes (DoS or Hash attacks)
            // https://andrewlock.net/why-is-string-gethashcode-different-each-time-i-run-my-program-in-net-core/

            // Hashtables should be used when you have abstract key/value pairs of various datatypes who's order does not matter and need to be referenced quickly

            Hashtable ourHashtable = new Hashtable
            {
                { "one", "The" },
                { "two", "quick" },
                { "three", "brown" },
                { "four", "fox" }
            };
            // Iterate over each item in our Hashtable and write its Key, Value, and HashCode to the console.
            foreach (DictionaryEntry item in ourHashtable) Console.WriteLine($"[{item.Key}] : {item.Value} ({item.Key.GetHashCode()})  ");
            /*
                FIRST EXECUTION RESULT:
                    [one] : The (-1509694570)
                    [four] : fox (-279004666)
                    [three] : brown (1986114172)
                    [two] : quick (32957339)

                SECOND EXECUTION RESULT:
                    [three] : brown (1465042908)
                    [four] : fox (-1047560796)
                    [one] : The (-1520603096)
                    [two] : quick (-2103823721)
            */
            Console.WriteLine();
        }
    }

    // Summary and Official Docs

    /*
        Arrays
        Provides methods for creating, manipulating, searching, and sorting arrays, thereby serving as the base class for all arrays in the common language runtime.
        https://docs.microsoft.com/en-us/dotnet/api/system.array?view=netcore-3.1
    */

    /*
        ArrayList
        Implements the IList interface using an array whose size is dynamically increased as required.
        https://docs.microsoft.com/en-us/dotnet/api/system.collections.arraylist?view=netcore-3.1
    */

    /*
        Hashtable
        Represents a collection of key/value pairs that are organized based on the hash code of the key.
        https://docs.microsoft.com/en-us/dotnet/api/system.collections.hashtable?view=netcore-3.1
    */
}
