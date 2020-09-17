#include <iostream>
#include <cmath>

using namespace std;

int main(void)
{
    cout << " Number\t Square" << endl;
    for (int i = 1; i <= 20; i++)
    {
        cout << "| " << i << "\t| " << pow(i, 2) << "\t|" << endl;
        cout << "-----------------" << endl;
    }
    
    return 0;
}