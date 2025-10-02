#include <stdio.h>
#include <time.h>
#include <stdlib.h>

int main() {
	srand(time(NULL));
	
	// generuje nahodne cislo 0 az 1
	float nahoda =  (float) rand() / RAND_MAX;

	printf("Nahodna hodnota: %f", nahoda);

	return 0;
}
