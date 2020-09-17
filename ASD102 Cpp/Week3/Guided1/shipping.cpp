#include <iostream>
#include <map>

using namespace std;


enum DeliveryMethods
{
    AIR, HAND, RAIL, TRUCK
};

map<DeliveryMethods, float> deliveryMethodPrices = 
{
    {AIR,   14.95},
    {HAND,  25.99},
    {RAIL,  8.75},
    {TRUCK, 10.25}
};

int main(void)
{
    char choice;

    cout << " [" << AIR << "] "     << "Air Delivery"   << endl;
    cout << " [" << HAND << "] "    << "Hand Delivery"  << endl;
    cout << " [" << RAIL << "] "    << "Rail Delivery"  << endl;
    cout << " [" << TRUCK << "] "   << "Truck Delivery" << endl;
    cout << "Enter your preferred shipping method: ";
    cin >> choice;

    switch (choice)
    {
    case '0':
    case 'a':
    case 'A':
        cout << deliveryMethodPrices[AIR] << endl;
        break;
    
    case '1':
    case 'h':
    case 'H':
        cout << deliveryMethodPrices[HAND] << endl;
        break;

    case '2':
    case 'r':
    case 'R':
        cout << deliveryMethodPrices[RAIL] << endl;
        break;

    case '3':
    case 't':
    case 'T':
        cout << deliveryMethodPrices[TRUCK] << endl;
        break;

    default:
        break;
    }


    return 0;
}