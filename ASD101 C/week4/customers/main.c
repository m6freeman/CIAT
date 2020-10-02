#include <stdio.h>
#include <stdlib.h>
#include <limits.h>
#include <string.h>

typedef struct customer
{
	char first_name[30];
	char last_name[30];
	char street[35];
	char city[20];
	char state[4];
	char phone[15];
	char zip[7];
	unsigned int account_id;
} Customer;

void print_info(Customer);


// the idea is to have the console always display the information, prompting the user
// to fill in info. As that info comes in, main will clear the console and reprint
// with the info provided to it.
int main(void)
{
	Customer customers_array[10];
	char state_query[4];

	// prompt the user to enter customer data
	for (unsigned int i = 0; i < sizeof(customers_array) / sizeof(*customers_array); ++i)
	{
		// Instantiate an instance of struct Customer
		// Customer IDs are auto-incrementing and will not be assigned by user
		// IDs start at 1 so we don't inadvertently read FALSE from the first Customer ID
		Customer c = {"", "", "", "", "", "","", i + 1};
		
		// FIRST NAME
		print_info(c);
		printf_s("%s", "\nEnter First Name: ");
		fgets(c.first_name, 30, stdin);
		unsigned int len = strlen(c.first_name);
		if (c.first_name[len - 1] == '\n') c.first_name[len - 1] = 0;
		system("cls");

		// LAST NAME
		print_info(c);
		printf_s("%s", "\nEnter Last Name: ");
		fgets(c.last_name, 30, stdin);
		len = strlen(c.last_name);
		if (c.last_name[len - 1] == '\n') c.last_name[len - 1] = 0;
		system("cls");

		// STREET ADDRESS
		print_info(c);
		printf_s("%s", "\nEnter Street Address: ");
		fgets(c.street, 35, stdin);
		len = strlen(c.street);
		if (c.street[len - 1] == '\n') c.street[len - 1] = 0;
		system("cls");

		// CITY
		print_info(c);
		printf_s("%s", "\nEnter City: ");
		fgets(c.city, 20, stdin);
		len = strlen(c.city);
		if (c.city[len - 1] == '\n') c.city[len - 1] = 0;
		system("cls");

		// STATE
		print_info(c);
		printf_s("%s", "\nEnter State: ");
		fgets(c.state, 4, stdin);
		len = strlen(c.state);
		if (c.state[len - 1] == '\n') c.state[len - 1] = 0;
		system("cls");

		// ZIP
		print_info(c);
		printf_s("%s", "\nEnter ZIP: ");
		fgets(c.zip, 7, stdin);
		len = strlen(c.zip);
		if (c.zip[len - 1] == '\n') c.zip[len - 1] = 0;
		system("cls");

		// PHONE
		print_info(c);
		printf_s("%s", "\nEnter Phone Number: ");
		fgets(c.phone, 15, stdin);
		len = strlen(c.phone);
		if (c.phone[len - 1] == '\n') c.phone[len - 1] = 0;
		system("cls");

		// Assign this object to array of customer objects
		customers_array[i] = c;
		
		// If we haven't capped out on all customers to add,
		// give the user the chance to break out of the enter
		// information loop
		if (i < (sizeof(customers_array) / sizeof(*customers_array)) - 1)
		{
			print_info(c);
			printf_s("%s", "\nEnter another Customer? [Y][N]");
			char customer_entry[3];
			fgets(customer_entry, 3, stdin);
			if (strcmp(customer_entry, "n\n") == 0 || strcmp(customer_entry, "N\n") == 0)
				break;
			system("cls");
		}
		// if we've reached the end of the loop, display the full
		// customer information before progressing
		else
		{
			print_info(c);
			printf_s("%s", "\n");
			system("pause");
		}
			
	}

	// Prompt the user to enter a state, pulling up all customers
	// that are within the query
	system("cls");
	printf_s("%s", "\tRetrieve Customer Data ...");
	printf_s("%s", "\n\nEnter a STATE to retrieve customer data: ");
	fgets(state_query, 4, stdin);
	const unsigned int len = strlen(state_query);
	if (state_query[len - 1] == '\n') state_query[len - 1] = 0;

	// if customers match, increase this number so we don't
	// display the wrong message
	int results = 0;

	// iterate through all customers in the array to
	// check if their state matches the users query
	for (unsigned int i = 0; i < sizeof(customers_array) / sizeof(*customers_array); ++i)
	{
		if (strcmp(customers_array[i].state, state_query) == 0)
		{
			// if they do, print that information out to the user
			results += 1;
			printf_s("%s", "\n");
			print_info(customers_array[i]);
			printf_s("%s", "\n");
		}
	}

	// if no results were found, tell the user
	if (results == 0)
		printf_s("%s", "No results found.\n");
	
	system("pause");
	return 0;
}


void print_info(Customer c)
{
	// CUSTOMER ID
	printf_s("\tCUSTOMER %d", c.account_id);
	printf_s("%s", "\n");

	// FIRST AND LAST NAME
	if (strcmp(c.first_name, "") != 0 && strcmp(c.last_name, "") != 0)
		printf_s("Name: %s %s\n", c.first_name, c.last_name);
	else if (strcmp(c.first_name, "") != 0)
		printf_s("Name: %s\n", c.first_name);
	else printf_s("%s", "Name: \n");

	// FULL ADDRESS
	if (strcmp(c.street, "") != 0 && strcmp(c.city, "") != 0 && strcmp(c.state, "") != 0 && strcmp(c.zip, "") != 0)
		printf_s("Address: %s %s, %s %s\n", c.street, c.city, c.state, c.zip);
	else if (strcmp(c.street, "") != 0 && strcmp(c.city, "") != 0 && strcmp(c.state, "") != 0)
		printf_s("Address: %s %s, %s\n", c.street, c.city, c.state);
	else if (strcmp(c.street, "") != 0 && strcmp(c.city, "") != 0)
		printf_s("Address: %s %s\n", c.street, c.city);
	else if (strcmp(c.street, "") != 0)
		printf_s("Address: %s\n", c.street);
	else printf_s("%s", "Address: \n");

	// PHONE NUMBER
	if (strcmp(c.phone, "") != 0)
		printf_s("Phone: %s\n", c.phone);
	else printf_s("%s", "Phone: \n");
}
