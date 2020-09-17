#include <iostream>


using namespace std;

class CollegeCourse
{
    protected:
        string department;
        int courseNum;
        int creditHours;
        double tuition;

    public:
        CollegeCourse(string department, int courseNum, int creditHours, double tuition)
        {
            this->department = department;
            this->courseNum = courseNum;
            this->creditHours = creditHours;
            this->tuition = tuition;
        }

        void showCollegeCourse()
        {
            cout << department << courseNum << " " << creditHours << " credits. Tuition $" << tuition << endl;
        }
};

class LabCourse : public CollegeCourse
{
    private:
        double labFee;
    public:
        LabCourse(string department, int courseNum, int creditHours, double tuition, double labFee = 100.0)
            : CollegeCourse(department, courseNum, creditHours, tuition)
        {
            this->labFee = labFee;
        }
        void showLabCourse()
        {
            showCollegeCourse();
            double total = tuition + labFee;
            cout << " plus lab fee $" << labFee << " for a total of $" << total << endl;
        }
};

int main(void)
{
    CollegeCourse course1("ENG", 101, 4, 512.33);
    LabCourse course2("ASD", 250, 4, 644.44);
    course1.showCollegeCourse();
    course2.showLabCourse();
    return 0;
}