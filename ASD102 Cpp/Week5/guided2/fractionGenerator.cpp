#include <iostream>
#include <vector>
#include <time.h>
#include <string>
#include <math.h>

using namespace std;

// create bold keywords to help with display
ostream& bold_on(ostream& os)
{
    return os << "\e[1m";
}
ostream& bold_off(ostream& os)
{
    return os << "\e[0m";
}

// Fraction contains information about a fraction. Privately, we keep track of
// the whole number, numerator, denominator, as well as it's decimal representation.
// When a Fraction is created, the constructor will assign "0 0/1" as a default fraction.
// We keep the default denominator at 1 to avoid /0 exceptions. Then we calculate the
// decimal value it represents. When checking the denominator, we'll set it to 1 if the 
// user entered 0 (as they should if they're entering a whole numbered answer).
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

// When a Problem obj is instantiated, it will generate two fractions based on
// various private boolean flags the user may turn on or off. These Fractions are stored
// as first and second, and the Problem constructor adds first and second together
// to create the sum Fraction.
class Problem
{
    private:
        bool numeratorsOfOne;
        bool sameDenominator;
        bool sumLessThanOne;

        // Generate a vector of two Fractions that have certain  
        // attributes limited depending on user choices. 
        vector<Fraction> generateFractions()
        {
            int w1, w2, n1, n2, d1, d2;

            if (numeratorsOfOne)
                n1 = n2 = 1;
            else
            {
                n1 = rand() % 10 + 1;
                n2 = rand() % 10 + 1;
            }
            
            if (sameDenominator)
                d1 = d2 = rand() % 10 + 1;
            else
            {
                d1 = rand() % 10 + n1;
                d2 = rand() % 10 + n2;
            }
            
            if (sumLessThanOne)
            {
                w1 = w2 = 0;
                while ((float(n1) / float(d1)) >= 0.5f) n1--;
                while((float(n2) / float(d2)) >= 0.5f) n2--;
            }
            else
            {
                w1 = rand() % 10;
                w2 = rand() % 10;
            }

            return vector<Fraction> { Fraction(w1, n1, d1), Fraction(w2, n2, d2) };
        }
    protected:

    public:
        Fraction first;
        Fraction second;
        Fraction sum;

        // Constructor takes user input to change how generateFractions() behaves
        // and assigns the generated Fractions to first, second, and sum
        Problem(bool numeratorsOfOne, bool sameDenominator, bool sumLessThanOne)
        {
            this->numeratorsOfOne = numeratorsOfOne;
            this->sameDenominator = sameDenominator;
            this->sumLessThanOne = sumLessThanOne;
            vector<Fraction> probs = generateFractions();
            first = probs[0];
            second = probs[1];
            sum = first + second;
        }
};




int main(void)
{   

    // establish random seed and user variable placeholders 
    srand((unsigned int)time(NULL));
    char UInumeraterOfOne, UIsameDenominator, UIsumLessThanOne;
    bool numeratorOfOne, sameDenominator, sumLessThanOne = false;
    
    // prompt the user for problem settings
    cout << "Please select the type of fraction problems you'd like to solve:" << endl;
    cout << "\tAll Numerators are 1? [y/n] ";
    cin >> UInumeraterOfOne;
    numeratorOfOne = (UInumeraterOfOne == 'y' || UInumeraterOfOne == 'Y');
    cout << "\tAll Denominators are the same? [y/n] ";
    cin >> UIsameDenominator;
    sameDenominator = (UIsameDenominator == 'y' || UIsameDenominator == 'Y');
    cout << "\tThe total sum is less than 1? [y/n] ";
    cin >> UIsumLessThanOne;
    sumLessThanOne = (UIsumLessThanOne == 'y' || UIsumLessThanOne == 'Y');

    // generate problems
    vector<Problem> problems;
    for (int i = 0; i < 5; i++)
        problems.push_back(Problem(numeratorOfOne, sameDenominator, sumLessThanOne));

    // display each problem and prompt the user to input an answer
    for (int i = 0; i < problems.size(); i++)
    {
        int w, n, d;
        cout << "Problem #" << i + 1 << endl;
        cout << " \t";
        problems[i].first.display();
        cout << endl << "+\t";
        problems[i].second.display();
        cout << endl << "-------------------" << endl << "\t";
        problems[i].sum.display();                            /*** uncomment this line to display answers! ***/
        cout << endl << endl;
        cout << "Your answer" << endl;
        cout << "\tWhole number: ";
        cin >> w;
        cout << "\tNumerator: ";
        cin >> n;
        cout << "\tDenominator: ";
        cin >> d;
        cout << bold_on << ((Fraction(w, n, d) ==  problems[i].sum) ? "Correct!" : "Incorrect.") << bold_off << endl << endl;

    }

    return 0;
}