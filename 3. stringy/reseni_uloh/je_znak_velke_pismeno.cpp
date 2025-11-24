#include <stdio.h>

int main() {
	char znak;
	scanf(" %c", &znak);
	
	// je znak velké písmeno
	// ASCII kod 65=A; 90=Z
	if ('A' <= znak && znak <= 'Z') {
		printf("Znak %c je velke pismeno.\n", znak);
	} else {
		printf("Znak %c neni velke pismeno.\n", znak);
	}
	
	printf("ASCII kod znaku: %d", znak);
	
	return 0;
}

