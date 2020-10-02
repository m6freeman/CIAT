#include <stdio.h>
#include <stdlib.h>
#include <string.h>

int main(void)
{
	// initialize string variables, explicitly declaring the ending null
    char s1[11] = {'\0'};
	char s2[11] = {'\0'};

	// provide the user with info and prompt for input
    printf_s("%s", "Please enter 5 letters. This will be string #1!\n");
    printf_s("%s", "The program will detect if a 'Z' or a 'z' was entered in this string!\n");

	// take an uninterrupted line of input from user, store in first string var
	gets_s(s1, 11);  

	// iterate over each character, testing against val == z
    for (unsigned int i = 0; i < strlen(s1); ++i)
    {
	    if (s1[i] == 'z' || s1[i] == 'Z')
	    {
			printf_s("%s %d %s", "Match with Character Z at position", i, "detected!\n");
			// If we catch an instance of z, break the loop to reduce cycles
            break;
	    }
    }

	// prompt user again
    printf_s("%s", "Please enter 5 more letters. This will be string #2!\n");

	// store second input
	gets_s(s2, 11);

	// concatenate with buffer safety
    strcat_s(s1, 11, s2);

	// display string and length to user
	printf_s("Concatenated String: %s\n", s1);
	printf_s("Concatenated string length: %d\n", strlen(s1));
	
    system("pause");
	return 0;
}