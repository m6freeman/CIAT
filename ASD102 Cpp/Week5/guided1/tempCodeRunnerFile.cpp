// List of demands
    // fraction class with 
        // overloaded operators
    // problem generator class to
        // generate fractions based on criteria
        // build fractions from user input
        // conduct tests against problem's expected result and user result
    // main needs to
        // display problem options 
        // instantiate problem obj based on options
        // display what it wants the user to do
        // pass user input to problem 
        // display results to screen
    
#include <iostream>

using namespace std;

class Fraction
{
    private:
        int whole;
        int numerator;
        int denominator;

    protected:
    public:
        string display()
        {
            return whole + numerator + "/" + denominator;
        }
};

class Problem
{
    private:
    protected:
    public:
};


int main(void)
{
    return 0;
}