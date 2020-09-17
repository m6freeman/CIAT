#include <iostream>

using namespace std;
int main(void)
{
    double num, num2;
    cout    << "Enter first value: ";
    cin     >> num;
    cout    << "Enter second value: ";
    cin     >> num2;
    cout    << "The sum of " << num << " and " << num2 << " is " << (num + num2) << endl;
    cout    << "The difference of " << num << " and " << num2 << " is " << (num - num2) << endl;
    cout    << "The product of " << num << " and " << num2 << " is " << (num * num2) << endl;
    cout    << "The quotient of " << num << " and " << num2 << " is " << (num / num2) << endl;
}