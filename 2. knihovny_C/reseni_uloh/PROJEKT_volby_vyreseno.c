#include <stdio.h>
#include <stdlib.h>
#include <time.h>


int main() {
	// nastav strany a preference
    int pocet_stran = 8;
    char strany[][14] = { "ANO", "SPOLU", "SPD", "STAN", "Piráti", "Motoristé", "Stačilo", "Jiné" };
    float preference[] = { 29.3, 20.5, 13.4, 11.1, 10, 6, 5.5,  4.2};

	// nastav seed
	srand(time(NULL));
	
	// generuj pocet volici
	int populace = 8000;
	int procento_volici = rand() % 31 + 50;
	int volici = populace * (float) procento_volici / 100;
	
	// interval preferenci
	float interval_preference[pocet_stran];
	float suma_preference = 0;
	for (int i = 0; i < pocet_stran; i++) {
		suma_preference += preference[i];
		interval_preference[i] = suma_preference;
	}
	
	// vytvor pole vysledku
	int vysledky[pocet_stran];
	for (int i = 0; i < pocet_stran; i++) {
		vysledky[i] = 0;
	}
	
	// generuj hlas
	float hlas;
	int odvoleno; // 0=neodvoleno; 1=odvoleno
	for (int i = 0; i < volici; i++) {
		// generuj cislo 0-100 na dvě desetinné
		hlas = rand() % 10000;
		hlas = (float) hlas/ 100;
		odvoleno = 0;
		
		// prochazej strany
		for (int j = 0; j < pocet_stran; j++) {
			if (hlas < interval_preference[j] && odvoleno == 0) {
				odvoleno = 1;
				vysledky[j]++;
			}
		}
	}
	
	// Vypis vysledky
	for (int i = 0; i < pocet_stran; i++) {
		printf("%s:\n", strany[i]);
		printf("    %d hlasu\n", vysledky[i]*1000);
		printf("    %.2f%%\n", (float) vysledky[i]/volici * 100);
	}

    return 0;
}
