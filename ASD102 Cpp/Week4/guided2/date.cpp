#include <iostream>
#include <string>

using namespace std;

class Date
{
    private:
        static const char FORMAT = '/';
        static const int MAX_DAYS = 31;
        static const int MAX_MONTHS = 12;
        int day, month, year;
    
    public:
        Date(int day = 1, int month = 1, int year = 2000)
        {
            this->day = (day < MAX_DAYS) ? day : MAX_DAYS;
            this->month = (month < MAX_MONTHS) ? month : MAX_MONTHS;
            this->year = year;
        }

        void display()
        {
            cout << day << FORMAT << month << FORMAT << year << endl;
        }
};

int main(void)
{
    Date noArgs;
    noArgs.display();

    Date birthday(45, 13, 1990);
    birthday.display();

    return 0;
}