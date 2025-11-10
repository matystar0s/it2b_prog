#include <stdio.h>
#include <string.h>

int main() {
	char slovo[40];
	
	printf("Zadej slovo: ");
	scanf(" %39s", slovo);
	
	int delka = strlen(slovo);
	
	printf("Zadal jsi slovo %s a ma delku %d", slovo, delka);
	
	return 0;
}


