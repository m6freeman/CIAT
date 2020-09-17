#include <iostream>
#include <vector> // <== Wow this would have been handy in C!

using namespace std;
using std::vector;


vector<int> multiplicationTable(int);

int main(void)
{
    int num;
    cout << "Enter a number in which to multiply: ";
    cin >> num;

    for (auto elem : multiplicationTable(num))
        cout << elem << endl;

    return 0;
}

vector<int> multiplicationTable(int number)
{
    vector<int> ret;
    for (int i = 2; i <= 10; i++)
        ret.push_back(number * i);
    return ret;    
}