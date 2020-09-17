#include <iostream>
#include <ios>
#include <limits>

using namespace std;

int main(void)
{
    char choice;
    int numOne, numTwo;

    while (true)
    {
        for (;;)
        {
            cout << "Enter the first number: ";
            if (cin >> numOne) break;
            else
            {
                cout << "Please enter a valid integer" << endl;
                cin.clear();
                cin.ignore(numeric_limits<streamsize>::max(), '\n');
            }
        }

        for (;;)
        {
            cout << "Enter the second number: ";
            if (cin >> numTwo) break;

            else
            {
                cout << "Please enter a valid integer" << endl;
                cin.clear();
                cin.ignore(numeric_limits<streamsize>::max(), '\n');
            }
        }
        


        cout << "Choose an operator: " << endl
             << "\t[a]ddition" << endl
             << "\t[s]ubtraction" << endl
             << "\t[m]ultiply" << endl
             << "\t[d]ivide" << endl
             << "\t[q]uit" << endl;
        cin >> choice;

        switch (choice)
        {
            case 'a':
            case 'A':
                cout << numOne << " plus " << numTwo << " = " << numOne + numTwo << endl;
                break;
            case 's':
            case 'S':
                cout << numOne << " minus " << numTwo << " = " << numOne - numTwo << endl;
                break;
            case 'm':
            case 'M':
                cout << numOne << " times " << numTwo << " = " << numOne * numTwo << endl;
                break;
            case 'd':
            case 'D':
                cout << numOne << " divided by " << numTwo << " = " << numOne / numTwo << endl;
                break;
            case 'q':
            case 'Q':
                return 0;
            default:
                break;
        }
    }
}