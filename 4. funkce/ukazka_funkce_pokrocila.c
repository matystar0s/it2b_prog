#include <stdio.h>

// VOID se používá pro označení absence datového typu
void pozdrav(char jmeno[]) {
    printf("Ahoj %s\n", jmeno);
}


// ve funkcích se často využívá více RETURNŮ

int jeCisloVPoli(int pole[], int delka, int cislo) {
    for (int i = 0; i < delka; i++) {
        if (pole[i] == cislo) {
            return 1;
        }
    }
    return 0;
}

float prumer(int soucet, int pocet) {
    if (pocet <= 0) {
        return -1;
    }

    return (float) soucet / pocet;
}


int main() {
    pozdrav("Gertrůdo");
    pozdrav("Pepo");

    printf("\n\n");

    int pole[] = {1, 2, 3};
    int delka_pole = 3;
    if (jeCisloVPoli(pole, delka_pole, 2) == 1) {
        printf("Cislo je v poli\n\n");
    } else {
        printf("Cislo neni v poli\n\n");

    }

    printf("Prumer je: %f", prumer(48, 5));

    return 0;
}
