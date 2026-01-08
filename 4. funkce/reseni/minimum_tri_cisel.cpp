#include <stdio.h>

float minimum(float a, float b, float c) {
	if (a < b && a < c)
		return a;
	if (b < c)
		return b;
	return c;
} 


int main() {
	float min = minimum(5.5, -25, 108);
	printf("%f", min);
		
	return 0;
}
