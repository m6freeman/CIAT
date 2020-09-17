#include <iostream>
#include <string>

using namespace std;


class CoffeeOrder
{
    private:
        static constexpr double price = 1.25;
        bool cream, milk, sugar, artificial = false;

    public:
        CoffeeOrder()
        {
            char c, m, s, a;

            cout << "Cream? Y/N ";
            cin >> c;
            cream = (c == 'y' || c == 'Y');
            if (!cream)
            {
                cout << "Milk? Y/N ";
                cin >> m;
                milk = (m == 'y' || m == 'Y');
            }
            
            cout << "Sugar? Y/N ";
            cin >> s;
            sugar = (s == 'y' || s == 'Y');
            if (!sugar)
            {
                cout << "Artificial Sweetener? Y/N ";
                cin >> a;
                artificial = (a == 'y' || a == 'Y');
            }
        }

        void display()
        {
            cout << "You ordered a coffee with " << 
                ((cream) ? "cream and " : ((milk) ? "milk and " : "")) <<
                ((sugar) ? "sugar " : ((artificial) ? "artificial sweetener " : "")) << 
                "for $" << price << endl;

        }
};

int main(void)
{
    CoffeeOrder co;
    co.display();
    return 0;
}