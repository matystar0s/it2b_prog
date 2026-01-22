#include <stdio.h>

int suma(int cislo) {
	if (cislo == 1) {
		return 1;
	}
	else {
		return cislo + suma(cislo-1);
	}
}

int main() {
	printf("%d", suma(4));
	return 0;
}
