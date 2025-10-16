#include <stdio.h>
#include <stdlib.h>
#include <time.h>
#include <math.h>


int main() {
	int pocet_bodu = 100000;
	int body_v_kruhu = 0;
	
	float x, y;
	
	srand(time(NULL));
	
	for (int i = 0; i < pocet_bodu; i++) {
		x = (float) rand() / RAND_MAX; 
		y = (float) rand() / RAND_MAX; 
		
		if (x*x + y*y < 1) {
			body_v_kruhu++;
		}
	}
	
	float pi = 4 * (float) body_v_kruhu / pocet_bodu;
	 
	printf("Odhad pi: %f\n", pi);
	
	float rozdil = (float) fabs(pi - M_PI);
	printf("Rozdil od pi: %f", rozdil);
	
	return 0;
}

