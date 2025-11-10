#include <stdio.h>

int main() {
	char str[] = "abeceda";
	
	char znak;
	printf("Zadej mi znak: ");
	scanf(" %c", &znak);
	
	int pocet_vyskytu = 0;
	int i = 0;
	while (str[i] != '\0') {
		if(str[i] == znak) {
			pocet_vyskytu++;
		}
		i++;
	}
	
	if (pocet_vyskytu > 0) {
		printf("Znak %c JE ve stringu %s\n", znak, str);
		printf("  Znak je ve strinu %d-krat", pocet_vyskytu);
	} else {
		printf("Znak %c NENI ve stringu %s\n", znak, str);
	}
	
	return 0;
}


