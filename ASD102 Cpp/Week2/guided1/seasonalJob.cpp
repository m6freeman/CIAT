#include <iostream>

using namespace std;

int main(void)
{
    const int MIN_YEARS_WORK    = 2;
    const int MIN_AGE           = 16;
    const int MIN_WEIGHT        = 40;
    const int MIN_TYPE_SPEED    = 50;

    int age, yearsWork, weight, typeSpeed;

    cout << "Age: ";
    cin >> age;
    cout << "Years of work experience: ";
    cin >> yearsWork;
    cout << "Max you can lift: ";
    cin >> weight;
    cout << "Max WPM: ";
    cin >> typeSpeed;

    if (age >= MIN_AGE && yearsWork >= MIN_YEARS_WORK && (weight >= MIN_WEIGHT || typeSpeed >= MIN_TYPE_SPEED))
    {
        cout << "Please submit an application." << endl;
    } else
    {
        cout << "Sorry, we cannot use you at this time." << endl;
    }
    
    
}