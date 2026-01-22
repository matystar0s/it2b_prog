#include <stdio.h>


int odpocetSekund(int hod, int min, int sec) {
	int vteriny = 24*60*60;
	vteriny -= hod*60*60;
	vteriny -= min*60;
	vteriny -= sec;
	
	return vteriny;
}

int main() {
	int vystup = odpocetSekund(23, 59, 50);
	printf("%d", vystup);
	return 0;
}
