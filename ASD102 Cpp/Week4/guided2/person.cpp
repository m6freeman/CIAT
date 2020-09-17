#include <iostream>
#include <string>

using namespace std;

class Person
{
    private:
        string firstName, lastName, zip;
    
    public:
        Person(string firstName = "X", string lastName = "X", string zip = "X")
        {
            this->firstName = firstName;
            this->lastName = lastName;
            this->zip = zip;
        }

        void display()
        {
            cout << firstName << " " << lastName << ", " << zip << endl;
        }
};

int main(void)
{
    Person personA;
    personA.display();

    Person personB("Matt", "Freeman", "92105");
    personB.display();


    return 0;
}