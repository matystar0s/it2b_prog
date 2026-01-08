#include <stdio.h>


void trojuhelnik(int patra) {
	for (int i = 0; i < patra; i++) {
		
		for (int j = 0; j < i+1; j++) {
			printf("#");
		}
		
		printf("\n");
	}
}

void stojan(int vyska) {
	for (int i = 0; i < vyska-1; i++) {
		printf("#\n");
	}
	printf("###\n");
}

void stromecek(int pocet_pater, int vyska) {
	printf("*\n");
	for (int i = 0; i < pocet_pater; i++)
		trojuhelnik(i+4);
	stojan(vyska);
}

int main() {
	stromecek(5, 10);
	return 0;
}

