#include <stdio.h>
#include <string.h>

int main() {
	char string1[40];
	char string2[40];
	
	printf("Zadej prvni string: ");
	scanf(" %s", string1);
	printf("Zadej druhy string: ");
	scanf(" %s", string2);
	
	// je string1 stejny jako string2?
	if (strcmp(string1, string2) == 0) {
		printf("Stringy jsou stejne");
	} else {
		printf("Stringy nejsou stejne");
	}
	
	return 0;
}

