#include <stdio.h>
#include <string.h>

int main() {
	/*
	CHYBNY PROGRAM
	Zkus spustit tento kod a zadat na vstupu
	 stringy o delce vetsi nez 4.
	*/
	
	char string1[50];
	char string2[50];
	
	printf("Zadej prvni string: ");
	// CHYBA: nelimituju pamet u nacteneho stringu
	scanf(" %s", string1);
	printf("Zadej druhy string: ");
	// CHYBA: nelimituju pamet u nacteneho stringu
	scanf(" %s", string2);
	
	printf("Prvni string: %s\n", string1);
	printf("Druhy string: %s\n", string2);
	
	return 0;
}

