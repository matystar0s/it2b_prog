#include <stdio.h>


void trojuhelnik(int patra) {
	for (int i = 0; i < patra; i++) {
		
		for (int j = 0; j < i+1; j++) {
			printf("#");
		}
		
		printf("\n");
	}
}

int main() {
	trojuhelnik(30);
	return 0;
}
