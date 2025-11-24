#include <stdio.h>
#include <string.h>

int main() {
	char vstup[50];
	int posun;
	
	printf("Zadej mi slovo:");
	scanf(" %49s", vstup);
	
	printf("Zadej posun:");
	scanf("%d", &posun);
	
	char vypis;
	
	for (int i = 0; i < strlen(vstup); i++) {
		if ('A' <= vstup[i]  && vstup[i]  <= 'Z') {
			vypis = vstup[i] + posun;
			while (vypis > 'Z') {
				vypis -= 26;
			}
		} else if ('a' <= vstup[i]  && vstup[i]  <= 'z') {
			vypis = vstup[i] + posun;
			while (vypis > 'z') {
				vypis -= 26;
			}
		} else {
			vypis = vstup[i];
		}
		
		printf("%c", vypis);
	}

	return 0;
}

