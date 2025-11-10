#include <stdio.h>
#include <stdlib.h>
#include <time.h>

int main() {
	int spravne = 0;
	int mocnina, odmocnina, vstup;
	srand(time(NULL));
	
	for (int i = 0; i < 3; i++) {
		odmocnina = rand() % 101;
		mocnina = odmocnina*odmocnina;
		printf("Jaka je odmocnina z %d:", mocnina);
		scanf("%d", &vstup);
		
		if (vstup == odmocnina) {
			spravne++;
		}
	}
	
	printf("Spravne vypocitano: %d", spravne);
	
	return 0;
}
