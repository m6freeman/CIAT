#include <iostream>

using namespace std;

int main(void)
{
    int meals;
    float prices[] = 
    {
        300, 450, 520, 590
    };

    do 
    {
        cout << "How many meals per day (0-3): ";
        cin >> meals;
    }
    while (meals < 0 || meals > 3);

    cout << "Semester rate for " << meals << 
        (meals != 1 ? " meals" : " meal") << 
        " is " << prices[meals] << endl;

    return 0;
}