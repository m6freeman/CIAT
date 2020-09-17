#include <iostream>

using namespace std;
int main(void)
{
    int i, j;
    int rows = 3;
    int k = 2 * rows - 2;

    for (i = -1; i < rows; i++)
    {
        for (j = 0; j <= k; j++) cout << " ";
        k = k - 1;

        for (j = 0; j <= i + 1; j++) cout << "* ";
        cout << endl;
    }

    for (i = rows; i >= -1; i--)
    {
        for (j = k; j >= 0; j--) cout << " ";
        k = k + 1;

        for (j = 0; j <= i + 1; j++) cout << "* ";
        cout << endl;
    }

    return 0;
}