#include <iostream>
#include <string>

using namespace std;

constexpr double licenseFee = 12.95;

class Dog
{
    private:
        string name;
        string breed;
        int age;
        static constexpr double licenseFee = ::licenseFee;

    public:
        Dog(string name, string breed, int age)
        {
            this->name = name;
            this->breed = breed;
            this->age = age;
        }

        void display()
        {
            cout << name << " is a " << breed << " and is " << age << " years old." << endl;
            cout << "Licensing Fee: $" << licenseFee << endl;
        }

};

int main(void)
{
    Dog dog1("Clifford", "Big Red Dog", 57);
    dog1.display();

    return 0;
}