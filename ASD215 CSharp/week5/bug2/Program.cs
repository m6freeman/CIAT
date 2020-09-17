/*
This program computes the average of a student's grades.

The expected output is:
	<increasing line number followed by file text, line by line>

The program has a syntax error (wrongly coded), a specification error (wrongly implemented),
and a semantic error (wrong logic).

Discuss with the instructor what each of the errors is and why they are wrong.

After a response, fix the specification and semantic errors and test to ensure that
the program is working as expected.

 */

using System;
using System.IO;

namespace IDL5
{
    public class FileDumpByLine                                                                                     // Naming convention
    {
        public static void Main(string[] args)
        {
            if (args is null) throw new ArgumentNullException(nameof(args));

            string[] lines;                                                                                         // Changed string lines; to string[] lines; array
            try                                                                                                     // We're working with external resources. Better to TRY that. Nothing can be done unless
            {                                                                                                       // we find that file.
                var fileStream = new FileStream(@"test.txt", FileMode.Open, FileAccess.Read);
                using (var streamReader = new StreamReader(fileStream))
                {
                    string text = streamReader.ReadToEnd();
                    lines = text.Split('\n');
                }
                int num = 0;
                foreach (string line in lines) Console.WriteLine(++num + ": " + lines[num - 1]);                    // Added pre-increment to nums, removing +1, and subtracting 1 from num for index retrieval
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex);
                throw;
            }
            catch (Exception ex)                                                                                    // Just in case something unexpected comes along...
            {
                Console.WriteLine(ex);
                throw;
            }

        }
    }
}