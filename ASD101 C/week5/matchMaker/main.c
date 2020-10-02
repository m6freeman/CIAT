#include <stdio.h>
#include <stdlib.h>


// GENDER exists outside the scope of the PERSON struct
// because it could be applied to other species as well
enum Gender
{
	female,
	male
};

// PERSON encapsulates both the properties we need to manage
// per the assignment. Having two separate BOY and GIRL structs
// would be redundant, so we'll differentiate with their GENDER property
typedef struct person
{
	char name[25];
	enum Gender gender;
} Person;

// GENERATE ALL COUPLES
// This function will take two iterable groups of type Person and join them 
// generate_all_couples :: Person*, Person* -> Person**
Person** generate_all_couples(Person*, Person*);

// PRINT ARRAY
// This function will iterate over a 2D array/matrix and print the results of each PERSON pair
// print_array :: Person** -> void
void print_array(Person**);


int main(void)
{
	const Person p1 = { "Alan", male };
	const Person p2 = { "Bethany", female };
	const Person p3 = { "Carl", male };
	const Person p4 = { "Dana", female };
	const Person p5 = { "Eric", male };
	const Person p6 = { "Felicia", female };

	Person males[3] = { p1, p3, p5 };
	Person females[3] = { p2, p4, p6 };

	Person** couples = generate_all_couples(males, females);
	print_array(couples);

	system("pause");
	return 0;
}



Person** generate_all_couples(Person* male_list, Person* female_list)
{
	Person** arr = malloc(3 * sizeof(Person*));
	for (int i = 0; i < 3; ++i)
	{
		arr[i] = malloc(2 * sizeof(Person));
		for (int j = 0; j < 2; ++j)
		{
			arr[i][j] = (j % 2 == 0) ? male_list[i] : female_list[i];
		}
	}
	return arr;
}

void print_array(Person** arr)
{
	for (int i = 0; i < 3; i++)
	{
		for (int j = 0; j < 2; j++)
		{
			printf_s("%s\t", arr[i][j].name);
		}
		printf_s("%s", "\n");
	}
}
