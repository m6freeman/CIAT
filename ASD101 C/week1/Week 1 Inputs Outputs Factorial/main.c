#include <stdio.h>

unsigned long factorial(unsigned long x)
{
	return (x == 0) ? 1 : (x * factorial(x - 1));
}

int main(void)
{
	unsigned long x = 1;
	
	printf("%s", "Enter a positive whole number to see it's factorial: \n");

	if (scanf_s("%lu", &x) == 1) printf("%lu! = %lu", x, factorial(x));
	else
	{
		while (getchar() != '\n') {}
		main();
	}
	
	return 0;
}