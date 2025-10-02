#include <stdio.h>
#include <time.h>
#include <stdlib.h>

int main() {
	srand(time(NULL));
	
	// kostka s hodnotami 12-16
	int kostka = rand() % 5 + 12;
	
	printf("padlo: %d", kostka);
	
	return 0;
}
