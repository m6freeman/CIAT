using System;
using System.Collections.Generic;
using System.Linq;

namespace chapterSixProjectFour
{
    class Program
    {
        // Set up our grading reference. I'm lazy and don't want to account for all
        // possibilities so we'll just catch any out-of-ranges as an F grade below.
        public static Dictionary<int, char> Grades = new Dictionary<int, char>()
        {
            {6, 'D'},
            {7, 'C'},
            {8, 'B'},
            {9, 'A'},
            {10, 'A'}
        };
        static void Main(string[] args)
        {
            // Just some VS boilerplate
            if (args is null) throw new ArgumentNullException(nameof(args));

            // Sentinel boolean to facilitate exiting from input loop
            bool sentinel = true;

            // Store all input values from user into a list to be averaged and
            // checked against Grades dict index.
            List<int> gradeList = new List<int>();

            // User input loop. Continue until they pass null
            Console.WriteLine("Input grades in values from 0 - 100.");
            Console.WriteLine("Press ENTER after each grade. Press ENTER twice to submit.");
            while (sentinel)
            {
                // So long as the user passes an integer, append value to gradeList
                    // If the number entered is higher than 100, append 100
                // otherwise flip sentinel to exit input loop
                if (int.TryParse(Console.ReadLine(), out int input))
                    gradeList.Add((input <= 100) ? input : 100);
                else
                    sentinel = !sentinel;
            }

            // 'F' accounts for all grade values under 60, so if its not in our dictionary
            // above, we'll just throw 'F'
            try
            {
                // To capture which 10s range the average is, we'll just divide by 10
                // and take the floor (since we don't care about + or - grades) and pass
                // that key to Grades dictionary to get our desired letter grade.
                Console.WriteLine(Grades[(int)Math.Floor(gradeList.Average() / 10)]);
            }
            catch (Exception)
            {
                Console.WriteLine('F');
            }
        }
    }
}
