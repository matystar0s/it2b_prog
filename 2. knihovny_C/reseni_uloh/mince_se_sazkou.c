#include <stdio.h>
#include <time.h>
#include <stdlib.h>


int main() {
	int ucet = 1000;
	char pokracovat = 'a'; // a = pokracuj; n = ne
	int padlo, tip;
	int sazka;
	
	srand(time(NULL));
	
	printf("Na uctu mas: %d\n", ucet);
	
	while (ucet > 0 && pokracovat == 'a') {
		printf("Kolik chces vsadit: ");
		scanf("%d", &sazka);
		if (sazka > ucet) {
			printf("Sazka je vetsi nez obsah uctu.");
			return 1;
		}
		
		printf("Jaky je tvuj tip? panna [0], orel [1].");
		scanf("%d", &tip);
		
		padlo = rand() % 2;
		if (padlo == 0) {
			printf("Padla panna.\n");
		} else {
			printf("Padl orel\n");
		}
		
		if (padlo == tip) {
			ucet += sazka;
		} else {
			ucet -= sazka;
		}
		
		printf("Na uctu mas: %d\n", ucet);
		
		printf("Chces pokracovat [a/n]: ");
		scanf(" %c", &pokracovat);
	}
	
	return 0;
}