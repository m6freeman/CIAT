#include <iostream>

using namespace std;

int main(void)
{
    int meals;

    cout << "Enter the number of meals requested: ";
    cin >> meals;

    switch (meals)
    {
    case 1 ... 10:
        cout << meals * 14.99 << endl;
        break;

    case 11 ... 20:
        cout << meals * 12.50 << endl;
        break;

    case 21 ... 39:
        cout << meals * 10.75 << endl;
        break;
    
    default:
        cout << meals * 9.45 << endl;
        break;
    }

    // the above case range syntax only works in the GNU C compiler
    // so in case you don't have that, please comment the above out
    // and uncomment the ugly and less intuitive block below:
    // 
    // if (meals >= 1 && meals <= 10)
    //     cout << meals * 14.99 << endl;
    // else if (meals >= 11 && meals <= 20)
    //     cout << meals * 12.50 << endl;
    // else if (meals >= 21 && meals <= 39)
    //     cout << meals * 10.75 << endl;
    // else
    //     cout << meals * 9.45 << endl;
    
    return 0;
}