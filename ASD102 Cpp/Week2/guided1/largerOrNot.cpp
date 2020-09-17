#include <iostream>

using namespace std;


int main(void)
{
    int numOne, numTwo;
    
    cout << "Enter the first number: ";
    cin >> numOne;
    cout << "Enter the second number: ";
    cin >> numTwo;

    if (numOne > numTwo) cout << "The first number you entered was larger." << endl;
    else if (numOne < numTwo) cout << "The second number you entered was larger." << endl;
    else cout << "The numbers were identical." << endl;

}