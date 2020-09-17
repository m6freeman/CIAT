#include <iostream>
#include <string>

using namespace std;

class Car
{
    private:
        static int count;
        
    public:
        
        Car()
        {
            count += 1;
            cout << count << " Car " << ((count != 1) ? "objects exist" : "object exists" ) << endl;
        }

        ~Car()
        {
            count -= 1;
            cout << count << " Car " << ((count != 1) ? "objects exist" : "object exists" ) << endl;
        }
};

int Car::count = 0;

int main(void)
{
    Car cars[5];
    return 0;
}