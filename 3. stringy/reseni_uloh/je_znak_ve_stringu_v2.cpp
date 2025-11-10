#include <stdio.h>

int main() {
	char str[] = "abeceda";
	
	char znak;
	printf("Zadej mi znak: ");
	scanf(" %c", &znak);
	
	int i = 0;
	while (str[i] != '\0') {
		if(str[i] == znak) {
			printf("Znak %c JE ve stringu %s\n", znak, str);
			return 0;
		}
		i++;
	}
	
	printf("Znak %c NENI ve stringu %s\n", znak, str);
	
	return 0;
}


