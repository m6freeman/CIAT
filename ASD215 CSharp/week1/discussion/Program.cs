/*

Week 1 Discussion
• How do you determine when a method should be defined?
• How many values can be returned from a method?
• How do ref and out parameter types differ and when is one type versus the other used?  Provide examples.
• When is it preferable to use a return value or to use an out parameter type?  Provide examples.

*/


/*

How do you determine when a method should be defined?

As a basic principle in object oriented programming, a class is the definition of a collection of methods/functions
that perform tasks to accomplish a particular goal. When speaking about classes, when should one define a method?
Methods can consist of a single expression, or as many as you'd like, however common programming conventions strongly
recommend the former emphasising code readability and maintainability. The smaller you can break down a problem, the
better, and ideally we would be left with a large number of small functions/methods that perform only one single task
but that can work together to solve the larger problem at hand.

How many values can be returned from a method?

Methods may return any number of values, however should ideally only return one (assuming the problem at hand doesn't
absolutely require otherwise). C# offers the keyword OUT as a property for method parameters that allows us to pass in
an out of scope (relative to the method) variable to be modified and returned. This can be done to as many parameters as
necessary.

*/

using System;

namespace discussion
{

    /*

    How do ref and out parameter types differ and when is one type versus the other used?

    To be able to answer this properly, we must point out the distinction between passing by reference
    and passing by value. This isn't a crazy-hard concept to understand, but it is kind of counter-intuitive
    and was something I struggled with a lot while learning on my own. When you pass a variable to a method,
    there are two ways to do it; by reference, or by value. Reference means you are passing the variable itself,
    while Value means you are passing a copy of that variable's value. If you change a variable you passed by
    reference, it changes the variable. If you change a variable you passed by value, it does not change the
    original variable but instead returns a new variable. Certain datatypes in C# have a default pass-by
    characteristic that the compiler assumes unless we override it. This is where the REF and OUT keywords
    come in. Below will be a few examples demonstrating the difference in results by passing by reference
    versus passing by value.

    */


    class Program
    {
        // Let's make a simple addition function to demonstrate passing by value.
        // By default, C# passes strings, integers, and various other types by value.
        // When we call this function on line 98, you might expect the result to be 12,
        // however we get this: "The result of 5 plus 7 is 0." Result's value of 0 was
        // copied into the method, the number 12 was assigned to the copy, but that copy
        // was never returned.
        public static void AddByValue(int first, int second, int result)
        {
            result = first + second;
        }

        // This time, let's pass result as a reference instead of making a copy.
        // Now, the next time we use Result on line 103, it reflects that change:
        // "The result of 5 plus 7 is 12." Notice this method and the one above
        // are identical with the exception of the ref keyword.
        public static void AddByReference(int first, int second, ref int result)
        {
            result = first + second;
        }

        // Finally, let's look at out. When you pass a variable with OUT (as opposed
        // to REF) we still pass the variable by reference, except this time it works
        // just like if there was a RETURN statement at the end. This is a subtle but VERY
        // important distinction because REF allows us to change the variable if we want,
        // while OUT demands that we do.
        public static void AddByRefOut(int first, int second, out int result)
        {
            // I have intentionally commented out the expression below because
            // it throws an error, demonstrating the difference between REF and
            // OUT. Uncomment line 90 and everything will execute and you can see
            // all the results mentioned in the comments for yourself. Once you
            // uncomment it, you'll get "The result of 5 plus 7 is 12"

            //result = first + second;

        }
        static void Main(string[] args)
        {
            int a = 5;
            int b = 7;
            int result = 0;

            AddByValue(a, b, result);
            Console.WriteLine($"The result of {a} plus {b} is {result}");
            // PRINTS: "The result of 5 plus 7 is 0"

            AddByReference(a, b, ref result);
            Console.WriteLine($"The result of {a} plus {b} is {result}");
            // PRINTS: "The result of 5 plus 7 is 12"

            AddByRefOut(a, b, out result);
            Console.WriteLine($"The result of {a} plus {b} is {result}");
            // PRINTS: "error CS0177: The out parameter 'result' must be assigned to before control leaves the current method"
            // PRINTS: "The result of 5 plus 7 is 12" once uncommented.


        }
    }

}

/*

When is it preferable to use a return value or to use an out parameter type?

As we saw above, it will be entirely dependant on the situation at hand. Suppose we have a method
that is intended to change the active state of another variable, but only IF it changes. REF would
be appropriate. If we have a method that needs to change multiple values simultaneously, we could
use OUT. If we want to write pure methods that do not alter the state of others, but instead work
with copies of information, we wouldn't use either.

*/