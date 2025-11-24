#include <stdio.h>
#include <string.h>

int main() {
	char vstup[50];
	
	printf("Zadej mi slovo:");
	scanf(" %49s", vstup);
	
	printf("ASCII kody jednotlivych znaku:\n");
	for (int i = 0; i < strlen(vstup); i++) {
		printf("   %c : %d\n", vstup[i], vstup[i]);
	}

	
	return 0;
}

