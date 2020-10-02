#include <stdio.h>

// establish math functions
float sum(float x, float y)
{
	return x + y;
}

float diff(float x, float y)
{
	return x - y;
}

float prod(float x, float y)
{
	return x * y;
}

float quot(float x, float y)
{
	return x / y;
}

// begin application
int main(void)
{
	float x, y = 0;

	printf("%s", "Enter ANY two numbers (no imaginary numbers, please):\n");

	// verify scanf_s has received valid input
	if (scanf_s("%f %f", &x, &y) == 2) 
	{
		printf("%s", "\nYour numbers were: ");
		// display these numbers back to the user. Their input is stored as float, but displayed without trailing 0's
		printf("%.5g and %.5g\n", x, y);

		// format as table
		printf("+\t-\t*\t\\\n");
		printf("%.5g\t%.5g\t%.5g\t%.5g\n", sum(x, y), diff(x, y), prod(x, y), quot(x, y));
	}
	// user input is not a number
	else 
	{
		// clear input buffer and re-run application
		while (getchar() != '\n') {};
		main();
	}

	return 0;
}