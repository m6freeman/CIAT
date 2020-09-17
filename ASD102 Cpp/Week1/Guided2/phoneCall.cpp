#include <iostream>

using namespace std;

class PhoneCall
{
    public:
        void set_minutes(float min)
        {
            minutes = min;
        }
        float get_minutes(void)
        {
            return minutes;
        }

        void set_price(float price)
        {
            price_per_minute = price;
        }
        float get_price(void)
        {
            return price_per_minute;
        }

        PhoneCall(float min, float price)
        {
            set_minutes(min);
            set_price(price);

            cout.precision(2);
            cout << "The call is " << get_minutes() << " minutes long." << endl;
            cout << "The cost of the call is $" << fixed << get_minutes() * get_price() << "." << endl;
        }
    
    private:
        float minutes;
        float price_per_minute;
};




int main(void)
{
    PhoneCall my_call_to_grandma = PhoneCall(7.5, 0.1);
    return 0;
}