#include <iostream>

using namespace std;

int main(void)
{
    const int x = 1;
    
    y(z(x));
    z(x);
}

int y(int x)
    {
        return x;
    }

    int z(const int x)
    {
        return (0);
    }