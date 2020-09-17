#include <iostream>
#include <vector>


using namespace std;

int quad(int);

int main(void)
{
    int nums[5];
    vector<int> quadNums;

    cout << "Enter 5 numbers: ";
    for (int i = 0; i < (sizeof(nums) / sizeof(int)); i++)
        cin >> nums[i];

    cout << endl;

    for (int i = 0; i < (sizeof(nums) / sizeof(int)); i++)
        quadNums.push_back(quad(nums[i]));
    
    for (auto elem : quadNums)
        cout << elem << endl;
    
    return 0;
}

int quad(int num)
{
    return num * 4;
}