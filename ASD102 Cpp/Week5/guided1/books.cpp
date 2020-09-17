#include <iostream>


using namespace std;


class Book
{
    protected:
        string title, author;

    public:
        void setData(string title, string author)
        {
            this->title = title;
            this->author = author;
        }

        string getTitle()
        {
            return this->title;
        }

        string getAuthor()
        {
            return this->author;
        }

};

class Fiction : public Book
{
    private:
        int readingLevel;

    public:
        void setData(string title, string author, int readingLevel)
        {
            Book::setData(title, author);
            this->readingLevel = readingLevel;
        }

        int getReadingLevel()
        {
            return this->readingLevel;
        }
};

class NonFiction : public Book
{
    private:
        int numberOfPages;

    public:
        void setData(string title, string author, int numberOfPages)
        {
            Book::setData(title, author);
            this->numberOfPages = numberOfPages;
        }

        int getNumberOfPages()
        {
            return this->numberOfPages;
        }
};


int main(void)
{
    Fiction book1;
    book1.setData("a title", "an author", 1);
    cout << book1.getTitle() << " " << book1.getAuthor() << " " << book1.getReadingLevel() << endl;

    NonFiction book2;
    book2.setData("another title", "another author", 123);
    cout << book2.getTitle() << " " << book2.getAuthor() << " " << book2.getNumberOfPages() << endl;

    return 0;
}