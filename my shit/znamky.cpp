#include <stdio.h>
#include <stdlib.h>   
#include <time.h>
#include <math.h>

int main(){
	
	srand(time(NULL));

	int z[10];
	int arr[] = {1, 2, 3, 4, 5};
	int i;
	int cislo;
	int znamka;
	int soucet = 0;
	float prumer;
	
	for (i = 0; i < 10; i++)
	{
	
	
	    cislo = rand() % 5;
		
		znamka = arr[cislo];
		
	    z[i] = znamka;
	    
	    soucet += z[i];
	    
	    printf("%d\n", z[i]);
	}
	
	prumer = (float)soucet/10;
	round(prumer);
	printf("prumer je %f", prumer);
	
	return 0;
	
}
