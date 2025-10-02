#include <stdio.h>
#include <stdlib.h>
#include <time.h>


int main() {
	// nastav strany a preference
    int pocet_stran = 8;
    char strany[][14] = { "ANO", "SPOLU", "SPD", "STAN", "Piráti", "Motoristé", "Stačilo", "Jiné" };
    float preference[] = { 29.3, 20.5, 13.4, 11.1, 10, 6, 5.5,  4.2};

	// TO DO:
		// - gneeruj nahodne hlasy
		// - zobraz vysledky 

	// Vypis strany
	for (int i = 0; i < pocet_stran; i++) {
		printf("%s\n", strany[i]);
	}


    return 0;
}
