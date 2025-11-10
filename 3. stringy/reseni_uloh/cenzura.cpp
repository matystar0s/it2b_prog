#include <stdio.h>
#include <string.h>

int main() {
	char slovo[40];
	
	printf("Zadej slovo: ");
	scanf(" %39s", slovo);
	
	for (int i = 0; i < strlen(slovo); i++) {
		if (i % 2 == 1) {
			printf("#", slovo[i]);
		} else {
			printf("%c", slovo[i]);
		}
	}
	
	return 0;
}

