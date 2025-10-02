#include <stdio.h>
#include <time.h>
#include <stdlib.h>

int main() {
	int min, max;
	srand(time(NULL));
	
	// uzivatel zadá 2 celá cisla - min, max
	// generuj nahodne cislo mezi min a max
	
	printf("Zadej minimum: ");
	scanf("%d", &min);
	
	printf("Zadej maximum: ");
	scanf("%d", &max);
	
	int rozsah = max - min + 1;
	int nahoda = rand() % rozsah + min;
	
	printf("Padla: %d", nahoda);
	
	return 0;
}
