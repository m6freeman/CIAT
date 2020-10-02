#include <stdio.h>
#include <string.h>
#include <stdlib.h>

int cubed(int);

int main(void)
{
	FILE* fp;
	errno_t err;
	char buff[255];

	if ((err = fopen_s(&fp,"test.txt", "w+") == 0))
	{
		fputs("This is testing for fputs...\n", fp);
		fprintf(fp, "This is testing for fprintf...\n");
		fprintf(fp, "Following will be all cubic numbers < 1000...\n");

		int x = 0;
		for (int i = 1; x < 1000; ++i)
		{
			x = cubed(i);
			fprintf(fp, "%d\n", x);
		}

		fclose(fp);
		printf_s("%s", " File has been written\n");
	}
	else printf_s("%s%ld", "File could not be written to. Error #", err);
		
	printf_s("%s", " Now we read the same file\n");

	if ((err = fopen_s(&fp, "test.txt", "r") == 0))
	{
		for (int i = 0; i < 13; i++)
		{
			fgets(buff, 255, (FILE*)fp);
			printf_s(" %s\n", buff);
		}

		fclose(fp);
	}
	else printf_s("%s%ld", "File could not be read. Error #", err);

	
	system("pause");
	return 0;
}


int cubed(const int x)
{
	return x * x * x;
}
