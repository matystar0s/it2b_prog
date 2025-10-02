#include <stdio.h>
#include <time.h>
#include <stdlib.h>

int main() {
	srand(time(NULL));
	
	int mince;
	
	for (int i = 0; i < 10; i++) {
	
		// 0 = panna, 1 = orel
		mince = rand() % 2;
	
		if (mince == 0) {
			printf("panna\n");
		}
		else {
			printf("orel\n");
		}
	}
	
	return 0;
}
