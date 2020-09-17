#include <iostream>
#include <map>
#include <string>
#include <ctime>
#include <iomanip>

using namespace std;

int main(void)
{
    float averageSalesPrice;
    
    map<string, float> monthlySalesPrices =
    {
        // I hate hard coding values like this, but I can't seem to find a 
        // C/C++ equivalent to .NET's DateTimeFormatInfo class to iterate over
        {"[01] January",     0},
        {"[02] February",    0},
        {"[03] March",       0},
        {"[04] April",       0},
        {"[05] May",         0},
        {"[06] June",        0},
        {"[07] July",        0},
        {"[08] August",      0},
        {"[09] September",   0},
        {"[10] October",     0},
        {"[11] November",    0},
        {"[12] December",    0}
    };

    for (auto itr = monthlySalesPrices.begin(); itr != monthlySalesPrices.end(); ++itr)
    {
        cout << "Enter the sale price for " << (*itr).first << ": ";
        cin >> (*itr).second;
        averageSalesPrice += (*itr).second;
    }
    
    averageSalesPrice /= monthlySalesPrices.size();

    cout << setw(8) << "MONTH\t\tSALE\tAVERAGE(" << averageSalesPrice << ")" << endl;
    for (auto elem : monthlySalesPrices)
    {
        cout << setw(8) << elem.first << "\t" << elem.second << "\t" << 
            ((elem.second == averageSalesPrice) ? " = " : ((elem.second > averageSalesPrice) ? " > " : " < ")) << endl;
    }

    return 0;
}