#include <stdio.h>

int main() {
	int pole[11];
	int cislo = 0;
	
	// generov�n� ��sel 0-10
	for (int i = 0; i < 11; i++) {
		pole[i] = cislo;
		cislo++;
	}
	
	// v�pis
	for (int i = 0; i < 11; i++) {
		printf("%d ", pole[i]);
	}
	
	return 0;
}

