#include <stdio.h>

int main() {
	char pozdrav[] = "Hello";
	
	printf("Vypisuji string: %s\n", pozdrav);
	
	printf("Znaky stringu:\n");
	
	/*for (int i = 0; i < 5; i++) {
		printf("   %c\n", pozdrav[i]);
	}*/
	
	int i = 0;
	while (pozdrav[i] != '\0') {
		printf("   %c\n", pozdrav[i]);
		i++;
	}
	
	return 0;
}
