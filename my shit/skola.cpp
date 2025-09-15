#include <iostream>
#include <stdio.h>

int main() {
    int hodiny;
    int minuty;
    int dalka;
    int v;

    printf("v kolik hodin odlitas:\n");
    scanf_s("%d", &hodiny);
    printf("kolik minut:\n");
    scanf_s("%d", &minuty);
    printf("vzdalenost:\n");
    scanf_s("%d", &dalka);
    printf("rychlost:\n");
    scanf_s("%d", &v);

    if (v <= 0)
    {
        printf("neplatna hondnota, novou:\n");
        scanf_s("%d", &v);
    }
    

    int cas = dalka/v;
    int result = hodiny+cas;

    printf("+-  %d:%d", result, minuty);
}