#include <stdio.h>
#include <stdlib.h>

void swap(int *, int *);

int main(void)
{
	// Declare and initiate initial values
	int x = 0;
	int y = 1;

	// Print the values of each variable
	printf_s("X = %d\tY = %d\n\n", x, y);

	// Use swap(by ref) function
	swap(&x, &y);
	printf_s("%s", "Calling swap() function...\n\n");

	// Print the values of each variable
	printf_s("X = %d\tY = %d\n\n", x, y);

	system("pause");
	return 0;
}

// Swap function takes 2 variables by their reference and swaps them.
void swap(int *x, int *y)
{
	int const t = *x;
	*x = *y;
	*y = t;
}