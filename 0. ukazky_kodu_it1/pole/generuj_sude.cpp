#include <stdio.h>

int main() {
	int pole[11];
	int cislo = 0;
	
	// generov�n� sud�ch ��cel
	for (int i = 0; i < 10; i++) {
		pole[i] = cislo;
		cislo += 2;
	}
	
	// v�pis
	for (int i = 0; i < 10; i++) {
		printf("%d ", pole[i]);
	}
	
	return 0;
}

