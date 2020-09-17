#include <iostream>

using namespace std;

int main(void)
{
    int idNum;
    const int LOW_NUM = 1;
    const int HIGH_NUM = 10;

    cout << "Enter a number between " << LOW_NUM <<
        " and " << HIGH_NUM << " inclusive: ";
    cin >> idNum;
    while (idNum < LOW_NUM || idNum > HIGH_NUM)
    {
        cout << "Invalid number" << endl;
        cout << "Please enter a number from " << LOW_NUM << 
            " through " << HIGH_NUM;
        cin >> idNum;
    }

    cout << "Thank you. Your valid number is " << idNum << endl;
    return 0;
}