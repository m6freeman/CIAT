#include <iostream>
#include <math.h>
#include <vector>

using namespace std;

ostream& bold_on(ostream& os)
{
    return os << "\e[1m";
}
ostream& bold_off(ostream& os)
{
    return os << "\e[0m";
}

class Fraction
{
    private:
        int whole;
        int numerator;
        int denominator;
        float decimalRepresentation;

        // Find the greatest common denominator.
        // This will not need to be used outside this class.
        int gcd(int x, int y)
        {
            return x == 0 ? y : gcd(y % x, x);
        }

        // Find the lowest common multiple.
        // This will not need to be used outside this class.
        int lcm(int x, int y)
        {
            return (x * y) / gcd(x, y);
        }

        // Simplify an improper fraction to it's proper form.
        // This will not need to be used outside this class.
        Fraction simplify(Fraction unsimplified)
        {
            while (float(unsimplified.numerator) / float(unsimplified.denominator) >= 1)
            {
                unsimplified.numerator -= unsimplified.denominator;
                unsimplified.whole++;
            }
            int x = gcd(unsimplified.numerator, unsimplified.denominator);
            unsimplified.numerator /= x;
            unsimplified.denominator /= x;
            return unsimplified;
        }

    protected:

    public:

        // Default Fractions are set to "0 0/1" = 0.0f to avoid /0 exceptions.
        // User built fractions may pass 0 as denominator (in the case of whole numbers)
        // This will be changed to 1.
        Fraction(int whole = 0, int numerator = 0, int denominator = 1)
        {
            this->whole = whole;
            this->numerator = numerator;
            this->denominator = (denominator > 0) ? denominator : 1;
            this->decimalRepresentation = 
                 float(this->whole) + float(float(this->numerator) / float(this->denominator));
        }

        // Provides a non-mutating way to display private values
        void display()
        {
            if (whole)
                cout << bold_on << to_string(whole) << bold_off << " ";
            if (numerator)        
                cout << to_string(numerator) + "/" + to_string(denominator);
        }

        // Provides a non-mutating way to display private values
        // Mostly used for troubleshooting purposes (testing equality)
        void displayDecimal()
        {
            cout << to_string(decimalRepresentation) << endl;
        }

        float getDecimal()
        {
            return decimalRepresentation;
        }

        // A Fraction + Fraction should = a new Fraction
        // This utilizes the private gcd, lcm, and simplify functions to appropriately
        // perform an addition operation on two fractions (whether they are proper or not)
        Fraction operator+(Fraction rightOperand)
        {
            Fraction sum;
            Fraction leftOperand(this->whole, this->numerator, this->denominator);
            leftOperand = simplify(leftOperand);
            rightOperand = simplify(rightOperand);
            sum.denominator = lcm(leftOperand.denominator, rightOperand.denominator);
            leftOperand.numerator *= (sum.denominator / leftOperand.denominator);
            rightOperand.numerator *= (sum.denominator / rightOperand.denominator);
            sum.numerator = leftOperand.numerator + rightOperand.numerator;
            sum.whole += leftOperand.whole + rightOperand.whole;
            sum.decimalRepresentation = leftOperand.decimalRepresentation + rightOperand.decimalRepresentation;
            return simplify(sum);
        }

        // A Fraction == Fraction should return True/False
        // to keep it simple, we just compare (a rounded to 1000s to accomidate 
        // floating point range tolerance) decimal values
        bool operator==(Fraction rightOperand)
        {
            return ((floorf(this->decimalRepresentation * 1000) / 1000) == 
                    (floorf(rightOperand.decimalRepresentation * 1000) / 1000));
        }
};

void sortDescending(Fraction fractions[], int size)
{
    if (size == 1) return;

    for (int i = 0; i < size - 1; i++)
    {
        if (fractions[i].getDecimal() < fractions[i + 1].getDecimal())
            swap(fractions[i + 1], fractions[i]);
    }
    sortDescending(fractions, size - 1);
}

int main(void)
{

    Fraction f[] = 
    {
        Fraction(1, 1, 4),
        Fraction(0, 1, 2),
        Fraction(4, 8, 2),
        Fraction(2, 1, 7),
        Fraction(1, 2, 29),
        Fraction(6, 6, 2),
        Fraction(1, 1, 2),
        Fraction(0, 3, 2),
        Fraction(0, 1, 2),
        Fraction(1, 7, 9),
        Fraction(0, 4, 17)
    };

    cout << "Unsorted: " << endl;
    for (int i = 0; i < sizeof(f) / sizeof(f[0]); i++)
    {
        f[i].display();
        cout << endl;
    }
    cout << endl;

    sortDescending(f, sizeof(f) / sizeof(f[0]));

    cout << "Sorted: Descending" << endl;
    for (int i = 0; i < sizeof(f) / sizeof(f[0]); i++)
    {
        f[i].display();
        cout << endl;
    }
    

    return 0;
}