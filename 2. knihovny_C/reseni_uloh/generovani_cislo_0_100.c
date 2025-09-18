#include <stdio.h>
#include <stdlib.h>   
#include <time.h>    

int main() {
    srand(time(NULL));

    int cislo = rand() % 100;

    printf("Náhodné číslo: %d\n", cislo);
    return 0;
}


