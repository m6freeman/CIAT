#include <stdio.h>
#include <stdlib.h>
#include <time.h>
#include <math.h>


int roll(const int sides, const int rolls, int* results)
{
	for (int i = 0; i < rolls; ++i) *(results + i) = (rand() % sides) + 1;
	return 0;
}

int sum(const int* results, const int rolls)
{
	int sum = 0;
	for (int i = 0; i < rolls; ++i) sum += *(results + i);
	return sum;
}

double average(const int sum, const int rolls)
{	
	return (double)sum / (double)rolls;
}

double standard_deviation(const int* results, const int rolls)
{
	double sd = 0;
	for (int i = 0; i < rolls; ++i) sd += pow(*(results + i) - average(sum(results, rolls), rolls), 2);
	return sqrt(sd / rolls);
}

int main(void)
{
	int sides, rolls = 0;

	// Get type of dice and number of rolls from the user.
	printf("%s", "How many sides are there to these dice?\t");
	scanf_s("%d", &sides);
	printf("%s", "How many times should we roll each die?\t");
	scanf_s("%d", &rolls);	

	// Dynamically allocate size of array based on user-input
	int* results = malloc(sizeof(int) * rolls);

	// provide a new seed each time the application runs, avoiding repeated results
	srand((unsigned)time(NULL));
	
	// populate results array
	roll(sides, rolls, results);

	// Print results of each roll to the console
	printf("%1s", "\n");
	for (int x = 0; x < rolls; ++x)
	{
		printf("\t%2d", results[x]);
		// display the results in as neat of a square formation as possible, no matter how many rolls
		if ((x + 1) % (int)sqrt(rolls) == 0) printf("\n");
	}

	// Print average and standard deviation of results below
	printf("\n\tAVERAGE: %.2f\t\t", average(sum(results, rolls), rolls));
	printf("STANDARD DEVIATION: %.2lf\n\n", standard_deviation(results, rolls));

	// deallocate memory
	free(results);
	system("pause");
	return 0;
}