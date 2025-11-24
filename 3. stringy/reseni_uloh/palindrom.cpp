#include <stdio.h>
#include <string.h>

int main() {
	char string[40];
	char opak[40];
	
	printf("Zadej slovo: ");
	scanf(" %s", string);
	
	for (int i = 0; i < strlen(string); i++) {
		opak[strlen(string)-i-1] = string[i];
	}
	opak[strlen(string)] = '\0';
	
	if (strcmp(string, opak) == 0) {
		printf("Slovo je palindrom.");
	} else {
		printf("Slovo neni palindrom.");
	}
	
	return 0;
}

