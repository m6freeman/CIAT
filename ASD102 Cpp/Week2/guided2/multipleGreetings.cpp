c#include <iostream>

using namespace std;
int main(void)
{
    int count = 0;
    int request;
    cout << "How many greetings do you want to see? ";
    cin >> request;
    for (count = 0; count < request; count++)
        cout << "Hello World!" << endl;
}