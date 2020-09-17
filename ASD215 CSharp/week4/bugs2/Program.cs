using System;

/*
    Many businesses need to determine the amount of time that has passed between events.
    These durations are measured in elapsed seconds, and the values can be large.  However,
    humans cannot easily understand times in these units.  Conversion between seconds and
    the more standard hours, minutes, and seconds is therefore necessary.

    Assume that a previous programmer wrote this code, but before debugging and delivering
    it, was transferred to a new department.  Your task to finish the work.  The code is
    almost correct, but compilation (syntax), coding (specification), or output (semantic)
    bugs exist.

    Carefully study the code, determine the problem, and fix the bug or bugs so that the
    output is as expected.  Change as little code as possible to correct the problem.
    Place a comment on or before the fixed lines explaining what is wrong and how the fix
    resolves the issue--no comment(s), no points.
*/
namespace FFTB04
{
    class TimeConverterForSeconds                                       // CORRECTED NAMING CONVENTION
    {
        static void Compute(int duration, out int hours, out int minutes, out int seconds)
        {
            hours = duration / (60 * 60);  // how many hours?           // CHANGED MODULO OPERATOR FOR DIVISION OPERATOR AND GROUPED MULTIPLICATION TOGETHER
            duration -= hours * 60 * 60;  // subtract the hours
            minutes = duration / 60;  // how many minutes?              // CHANGED MODULO OPERATOR FOR DIVISION OPERATOR
            duration -= minutes * 60;  // subtract the minutes          // CHANGED (DURATION -= DURATION * 60) TO (DURATION -= MINUTES * 60)
            seconds = duration;
        }

        static void Main(string[] args)
        {
            int duration = 12345;  // in seconds
            Console.WriteLine("12345 seconds is 3 hours, 25 minutes, and 45 seconds");
            Compute(duration, out int hours, out int minutes, out int seconds);         // NOT NECESSARY, BUT I INLINED THE VARIABLES SINCE THEY'RE ONLY USED ONCE AND IT LOOKS NICER
            Console.WriteLine($"{duration} seconds is {hours} hours, {minutes} minutes, and {seconds} seconds");    // INTERPOLATED STRINGS LOOK GOOD TOO
        }
    }
}
