#include <stdio.h>
#include <string.h>
#include <stdlib.h>

// MAIN MENU
// This function prints the menu options out to the user and prompts them to enter a option value
// main_menu :: int -> void
void main_menu(char*, char*);

// OPTION 1: INPUT PIN TWICE
// This function will prompt the user to enter their pin twice, storing each input in separate strings to compare against with other functions
// input_PIN :: string, string -> void
void input_PIN(char*, char*);

// OPTION 2: VERIFY PINS
// This function will compare the two strings given by the user and return 1/0 on their equality
// compare_PIN :: string, string -> int
int compare_PIN(char*, char*);

// OPTION 3: NO LEADING 0
// This function will check to see if a 0 (invalid input) was entered and return 1/0 if valid
// validate_PIN :: string, string -> int
int validate_PIN(char*, char*);

// OPTION 4: EXIT APPLICATION
// This function will break out of the main loop and exit the application
// stdlib.exit :: int -> void

// CLEAR STDIN INPUT STREAM
// This function will clear the input stream, allowing new values to be added after a newline break
// // Credit: https://stackoverflow.com/questions/17318886/fflush-is-not-working-in-linux
// clean_stdin :: void -> void
void clean_stdin(void);

// REMOVE SPACES
// This function will iterate though a string and remove any spaces in the string input
// Credit: https://stackoverflow.com/questions/1726302/removing-spaces-from-a-string-in-c
// remove_spaces :: string -> void
void remove_spaces(char*);


int main(void)
{
	char s1[13] = { '\0' };
	char s2[13] = { '\0' };

	main_menu(s1, s2);

	return 0;
}

void main_menu(char* s1, char* s2)
{
	int option;
	
	printf_s("%s", "Welcome to the PIN Verification Program.\n");
	printf_s("%s", "\n");
	printf_s("%s", " [1] Input your PIN\n");
	printf_s("%s", " [2] Compare your PIN\n");
	printf_s("%s", " [3] Verify your PIN is legal (6 numbers, not starting with 0)\n");
	printf_s("%s", " [4] Exit application\n");
	printf_s("%s", "\n");
	//printf_s("%s: %s\n%s: %s\n", "PIN 1", s1, "PIN 2", s2);
	scanf_s("%d", &option);
	clean_stdin();

	switch (option)
	{
	case 1:
		input_PIN(s1, s2);
		system("cls");
		main_menu(s1, s2);
		break;
	case 2:
		system("cls");
		compare_PIN(s1, s2);
		main_menu(s1, s2);
		break;
	case 3:
		system("cls");
		validate_PIN(s1, s2);
		main_menu(s1, s2);
		break;
	case 4:
		exit(0);
	default:
		system("cls");
		main_menu(s1, s2);
	}
}

void input_PIN(char* s1, char* s2)
{
	printf_s("%s", "Please enter your PIN: ");
	fgets(s1, 13, stdin);
	printf_s("%s", "\nPlease re-enter your PIN: ");
	fgets(s2, 13, stdin);
}

int compare_PIN(char* s1, char* s2)
{
	remove_spaces(s1);
	remove_spaces(s2);
	
	if (strcmp(s1, s2) == 0)
	{
		printf_s("%s\n\n", "Your PINs match!");
		return 1;
	}
	printf_s("%s\n\n", "ERROR: PINs do not match.");
	return 0;
}

int validate_PIN(char* s1, char* s2)
{
	if (s1[0] != '0' || s2[0] != '0')
	{
		if (strlen(s1) == 7)
		{
			printf_s("%s\n\n", "Your PIN is valid!");
			return 1;
		}
	}
	printf_s("%s\n\n", "ERROR: PIN is illegal.");
	return 0;
}

void clean_stdin(void)
{
	int c;
	do {
		c = getchar();
	} while (c != '\n' && c != EOF);
}

void remove_spaces(char* s)
{
	const char* d = s;
	do {
		while (*d == ' ') 
		{
			++d;
		}
	} while ((*s++ = *d++));
}