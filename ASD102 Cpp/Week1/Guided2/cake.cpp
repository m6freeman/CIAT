#include <iostream>

using namespace std;

class Cake
{
    public:
        void set_kcal(float kc)
        {
            kcal = kc;
        }
        float get_kcal(void)
        {
            return kcal;
        }

        void set_price(float pr)
        {
            price = pr;
        }
        float get_price(void)
        {
            return price;
        }

        Cake(float kcal, float price)
        {
            set_kcal(kcal);
            set_price(price);

            cout << "The " << get_kcal() << " calorie cake costs $" << get_price() << "." << endl;
            cout << "The cost of the cake per calorie is $" << fixed << get_price() / get_kcal() << "." << endl;
        }
    
    private:
        float kcal;
        float price;
};




int main(void)
{
    float kcals, cost;
    cout    << "Enter the cake price: ";
    cin     >> cost;
    cout    << "Enter the calorie count: ";
    cin     >> kcals;

    Cake cake_one = Cake(kcals, cost);
    return 0;
}