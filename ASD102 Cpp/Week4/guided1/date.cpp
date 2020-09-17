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
        Date(int day, int month, int year)
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
    Date today(15, 6, 2020);
    today.display();

    Date birthday(45, 13, 1990);
    birthday.display();

    return 0;
}