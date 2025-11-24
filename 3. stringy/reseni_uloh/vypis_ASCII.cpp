#include <stdio.h>

int main() {
	char znak = 'X';
	
	if ('A' <= znak && znak <= 'Z') {
		printf("Znak je velka abeceda");
	} else {
		printf("Znak NENI velka abeceda");
	}
	
	return 0;
}

