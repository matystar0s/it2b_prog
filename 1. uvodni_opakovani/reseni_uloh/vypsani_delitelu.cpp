#include <stdio.h>

int main() {
	int cislo;
	
	printf("Zadej kladne cele cislo: ");
	scanf("%d", &cislo);
	
	if (cislo <= 0) {
		printf("Spatny vstup");
		//perror("Spatny vstup");
		return 1;
	}
	
	printf("Delitele cisla %d\n", cislo);
	for (int i = 1; i <= cislo; i++) {
		if (cislo % i == 0) {
			printf("  %d\n", i);
		}
	}
	
	return 0;
}

