#include <iostream>
#include <list>
#include <sstream>

using namespace std;

bool luhn_test(string a, string b, string c, string d);


int main(void)
{
    // establish input placeholders
    string first, second, third, fourth;

    // take input from user
    cout        << "Enter first four digits of credit card: ";
    cin         >> first;
    cout        << "Enter second four digits of credit card: ";
    cin         >> second;
    cout        << "Enter third four digits of credit card: ";
    cin         >> third;
    cout        << "Enter fourth four digits of credit card: ";
    cin         >> fourth;

    // evaluate if card number is valid
    if (luhn_test(first, second, third, fourth))
    {
        cout    << "Result is 1" << endl;
    } 
    else
    {
        cout    << "Result is 0" << endl;
    }
    
    return 0;
}


bool luhn_test(string a, string b, string c, string d)
{
    // Add all number chunks together
    string full_number = a + b + c + d;
    
    // Create a list of individual ints in reverse order
    list<int> card;
    for (char c: full_number) card.push_front((int)c - 48);
    
    int total = 0;
    int card_index = 0;
    for (int d: card)
    {
        // double ternary time! check if the index is odd (usually even, but 
        // we're skipping the check number @ index[0]). If odd, check if the
        // number exceeds 9 when doubled. If it does, add the digits together
        // (or just -9). If not, just double it and add to total. If index is 
        // even, just add to total.
        total += (0 != card_index % 2) ? (((d * 2) > 9) ? (d * 2) - 9 : d * 2) : d;
        card_index++;
    }
    
    // return boolean representation of whether total is modulo 10
    return 0 == total % 10;
}