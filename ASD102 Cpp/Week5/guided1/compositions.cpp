#include <iostream>


using namespace std;

class Composition
{
    protected:
        string title;
        string composer;
        int yearWritten;
    public:
        Composition(string title, string composer, int yearWritten)
        {
            this->title = title;
            this->composer = composer;
            this->yearWritten = yearWritten;
        }
        void showComposition()
        {
            cout << title << " was written by " << composer << " in " << yearWritten << endl;
        }
};

class NationalAnthem : public Composition
{
    private:
        string nation;
    public:
        NationalAnthem(string title, string composer, int yearWritten, string nation)
            : Composition(title, composer, yearWritten)
        {
            this->nation = nation;

        }
        void showNationalAnthem()
        {
            showComposition();
            cout << " and is the national anthem of " << nation << endl;
        }
};

int main(void)
{
    Composition comp1("Symphonie Fantastique", "Berlioz", 1780);
    NationalAnthem nat1("Star Spangled Banner", "Key", 1778, "US");

    comp1.showComposition();
    nat1.showNationalAnthem();

    return 0;
}