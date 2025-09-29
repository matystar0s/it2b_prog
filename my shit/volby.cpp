#include <stdio.h>
#include <stdlib.h>   
#include <time.h>
#include <math.h>

int main(){
    int cislo;
    int nahoda;
	char strany[][67] = { "ANO", "SPOLU", "SPD", "STAN", "Pirati", "Motoriste", "Stacilo", "Jine" };    
    float preference[] = { 29.3, 20.5, 13.4, 11.1, 10.0, 6.0, 5.5,  4.2};
    long volic = 8300000;
    int i;
    int x;
    int z;
    int y;
    
	srand(time(NULL));
    cislo = rand() % 31;
    cislo += 50;   

    printf("%d\n", cislo);
    
	for (i = 0; i < 8; i++){
		nahoda = rand() % 9;
    	nahoda -= 4;
    	preference[i] += nahoda;
    	preference[i + 1 % 8] -= nahoda;
	}
    volic *= (float)cislo/100;
    volic /= 100;
    
    for (x = 0; x < 8; x++){
    	preference[x] *= (int)volic;
	}
	
	for (z = 0; z < 8; z++){
    	preference[z] /= volic;
    	printf(" %s : %.1f%%  ", strany[z], preference[z]);
    	for (y = 0; y < preference[z]; y++){
    		printf("*");
		}
	printf("\n");
	}
    
    return 0;
	
}

