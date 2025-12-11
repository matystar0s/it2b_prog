#include <stdio.h>

float objemValce(float v, float r) {
	return 3.14 * r * r * v;
}

int main() {
	float vyska, polomer;
	
	float celkovy_objem = 0;
	
	for (int i = 0; i < 3; i++) {
		printf("Zadej %d. vysku:", i+1);
		scanf("%f", &vyska);
		
		printf("Zadej %d. polomer:", i+1);
		scanf("%f", &polomer);
		
		celkovy_objem += objemValce(vyska, polomer);
	}
	
	printf("Objem dortu o trech patrech je %f", celkovy_objem);
	return 0;
}
