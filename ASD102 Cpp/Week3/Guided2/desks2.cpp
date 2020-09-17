#include <iostream>

using namespace std;

void assignNumberOfDrawersByRef(int &);
void assignTypeOfWoodByRef(char &);
void calculateCostByRef(int &, char &, float &);
void displayCostByRef(float &);

int main(void)
{
    float cost;
    int drawers = 0;
    char woodType = 'p';

    assignNumberOfDrawersByRef(drawers);
    assignTypeOfWoodByRef(woodType);
    calculateCostByRef(drawers, woodType, cost);
    displayCostByRef(cost);

    return 0;
}

void assignNumberOfDrawersByRef(int &drawers)
{
    cout << "Enter the number of drawers: ";
    cin >> drawers;
}

void assignTypeOfWoodByRef(char &woodType)
{
    cout << "Enter the type of wood:" << endl;
    cout << " [m] Mahogany" << endl;
    cout << " [o] Oak"      << endl;
    cout << " [p] Pine"     << endl;
    cout << "Type: ";
    cin >> woodType;
}

void calculateCostByRef(int &drawers, char &woodType, float &cost)
{
    switch (woodType)
    {
    case 'm':
    case 'M':
    default:
        cost = 180;
        break;

    case 'o':
    case 'O':
        cost = 140;
        break;
    
    case 'p':
    case 'P':
        cost = 100;
        break;
    }

    cost += (drawers * 35);
}

void displayCostByRef(float &cost)
{
    cout << cost << endl;
}