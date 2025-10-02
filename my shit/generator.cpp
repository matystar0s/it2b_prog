#include <stdio.h>
#include <stdlib.h>
#include <time.h>

int main(){
    srand(time(NULL));

    int max;
    int min;

    printf("What is the max number: ");
    scanf("%d", &max);
    printf("What is the min number: ");
    scanf("%d", &min);

    int cislo = rand() % (max + 1 - min);
    cislo += min;

    printf("%d", cislo);
}