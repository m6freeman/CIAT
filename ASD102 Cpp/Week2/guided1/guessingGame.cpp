#include <iostream>
#include <ctime>

using namespace std;

int main(void)
{
    const int DIVISOR = 10;
    srand((unsigned)time(NULL));
    int guess;
    int randomNumber = rand() % DIVISOR;
    
    cout << "I am thinking of a number between 0 and 9" << endl <<
        "Can you guess it?" << endl;
    cin >> guess;
    cout << "Your guess was " << guess << " and the random number was " <<
        randomNumber << endl;
    if (guess == randomNumber)
    {
        cout << "Excellent! You must have ESP!" << endl;
    } else if (guess >= randomNumber - 2 && guess <= randomNumber + 2)
    {
        cout << "Very close!" << endl;
    } else
    {
        cout << "You were way off!" << endl;
    }
        
}