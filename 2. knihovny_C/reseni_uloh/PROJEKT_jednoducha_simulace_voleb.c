#include <stdio.h>
#include <stdlib.h>
#include <time.h>


int main() {
	srand(time(NULL));
	
	int volici = 1000;
	int pocet_stran = 8;
	char strany[][14] = { "ANO", "SPOLU", "SPD", "STAN", "Piráti", "Motoristé", "Stačilo", "Jiné" };

	int hlasy[8];
	for (int i = 0; i < pocet_stran; i++) {
		hlasy[i] = 0;
	}
	
	int volba;
	for (int i = 0; i < volici; i++) {
		volba = rand() % 8;
		hlasy[volba] += 1;
	}
	
	for (int i = 0; i < pocet_stran; i++) {
		printf("%s: %d hlasu\n", strany[i], hlasy[i]);
	}
	
	return 0;
}