#include <stdio.h>
#include <stdlib.h>

int main(void)
{
	// declare all variables
	int nums[5] = {0,0,0,0,0};
	float sum = 0;
	int highest = 0;

	printf("%s", "Enter 5 numbers:\n");

	// 
	for (int i = 0; i < 5; ++i) scanf_s("%d", &nums[i]);

	printf("%s", "The numbers you entered were: ");

	// iterate through the array once. add numbers together to get sum.
	// check current number in iteration against highest. save if higher
	for (int i = 0; i < 5; ++i)
	{
		printf("%d ", nums[i]);
		sum += nums[i];
		highest = (nums[i] >= highest) ? nums[i] : highest;
	}

	printf("\nThe average between those numbers is: %.2f", sum / 5 );
	printf("\nThe highest number you entered was: %d\n\n", highest);

	system("pause");
	return 0;
}
