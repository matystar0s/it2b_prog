#include <stdio.h>
#include <stdlib.h>
#include <time.h>

int main()  {
	srand(time(NULL));
	int pocet_znamek = 10;
	int znamky[pocet_znamek];
	int soucet = 0;
	
	printf("Známky studenta:\n");
	for (int i = 0; i < pocet_znamek; i++) {
		znamky[i] = rand() % 5 + 1;	
		soucet += znamky[i];
		printf(" %d", znamky[i]);		
	}
	printf("\n");
	
	printf("Prumer je: %f", (float) soucet / pocet_znamek);
	return 0;
}
