#include <stdio.h>
#include <stdlib.h>
#include <time.h>

int main() {
	int hod, min, vzdalenost, rychlost;
	
	printf("Zadej cas odletu (hod): ");
	scanf("%d", &hod);
	printf("Zadej cas odletu (min): ");
	scanf("%d", &min);
	printf("Zadej vzdalenost (km): ");
	scanf("%d", &vzdalenost);
	printf("Zadej rychlsot letadla (km/hod): ");
	scanf("%d", &rychlost);
	
	int cas_letu = (float) vzdalenost / rychlost * 60;
	hod += cas_letu / 60;
	
	min += cas_letu % 60;
	
	if (min > 60) {
		hod += 1;
		min -= 60;
	}
	
	if (hod > 24) {
		int dny = 0;
		while (hod > 24) {
			hod -= 24;
			dny += 1;
		}
		printf("dorazis o %d dny pozdeji\n", dny);
	}
	
	printf("Cas priletu: %d:%d", hod, min);
	
	return 0;
}
