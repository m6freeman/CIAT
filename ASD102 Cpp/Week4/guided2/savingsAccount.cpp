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

        string getName()
        {
            return firstName + " " + lastName;
        }
};

class SavingsAccout
{
    private:
        int accountNumber;
        float balance, interestRate;

    public:
        Person customer;

        SavingsAccout(Person customer)
        {
            this->customer = customer;
            this->accountNumber = 0;
            this->balance = 0;
            this->interestRate = 0;
        }
        // constructor overload
        SavingsAccout(Person customer, int accountNumber)
        {
            this->customer = customer;
            this->accountNumber = accountNumber;
            this->balance = 100;
            this->interestRate = 0.03;
        }

        void display()
        {
            cout << customer.getName() << " | " << accountNumber << " | $" << balance << " | " << interestRate << "%" << endl;
        }
};

int main(void)
{
    Person personA("Matt", "Freeman");

    SavingsAccout accountA(personA);
    accountA.display();

    SavingsAccout accountB(personA, 1234);
    accountB.display();

    return 0;
}