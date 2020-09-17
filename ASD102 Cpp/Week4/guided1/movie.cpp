#include <iostream>
#include <string>

using namespace std;


class Movie
{
    private:
        string title, director;
        int year;
    
    public:
        void setTitle(string title)
        {
            this->title = title;
        }

        void setYear(int year)
        {
            this->year = year;
        }

        void setDirector(string director)
        {
            this->director = director;
        }

        void display()
        {
            cout << title << " made in " << year << " directed by " << director << endl;
        }


};

int main(void)
{
    Movie movie1;
    
    movie1.setTitle("The Room");
    movie1.setDirector("Tommy Wiseau");
    movie1.setYear(2003);

    movie1.display();

    return 0;
}