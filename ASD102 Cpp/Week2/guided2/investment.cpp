#include <iostream>

using namespace std;

int main(void)
{

    int years;
    float balance;
    float returnRate = 8;

    cout << "Please enter your initial investment capital: ";
    cin >> balance;

    cout << "Enter the number of years you want to have your account mature (between 1 and 30): ";
    cin >> years;
    while (years < 1 || years > 30)
    {
        cout << "Invalid number" << endl;
        cout << "Please enter a number from 1 to 30: ";
        cin >> years;
    }


    for (int i = 1; i <= years; i++)
    {
        balance += (balance * returnRate) / 100;
        cout.precision(2);
        cout << "After " << i << ((i > 1) ? " years" : " year") << " the value is $" << fixed << balance << endl;
    }
    


    return 0;
}