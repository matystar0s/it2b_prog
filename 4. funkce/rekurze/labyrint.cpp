#include <stdio.h>

#define RADKY 10
#define SLOUPCE 10

/*
 * Toto je složitější úloha na rekurzi.
 * Tvým úkolem je napsat algoritmus, který dokáže v labyrintu najít cestu ze startu do cíle.
 * */

// '0' = volná cesta
// '1' = zeď
// S = start
// C = cíl

char labyrint[RADKY][SLOUPCE] = {
        {'S', '1' , '0' , '0' , '0' , '1' , '1' , '1' , '1' , '1'},
        {'0' , '0' , '0' , '1' , '0' , '1' , '0' , '0' , '0' , '1'},
        {'1' , '1' , '1' , '1' , '0' , '1' , '0' , '1' , '0' , '1'},
        {'1' , '0' , '0' , '0' , '0' , '1' , '0' , '1' , '0' , '0'},
        {'1' , '0' , '1' , '1' , '1' , '1' , '0' , '1' , '1' , '1'},
        {'1' , '0' , '0' , '0' , '0' , '0' , '0' , '1' , '0' , '0'},
        {'1' , '1' , '1' , '1' , '1' , '1' , '0' , '1' , '0' , '1'},
        {'1' , '0' , '0' , '0' , '0' , '0' , '0' , '1' , '0' , '1'},
        {'1' , '0' , '1' , '1' , '1' , '1' , '1' , '1' , '0' , '1'},
        {'1' , '0' , '0' , '0' , '0' , '0' , '0' , '0' , '0' , 'C'}
};


void vypisLabyrint()
{
    for (int r = 0; r < RADKY; r++)
    {
        for (int s = 0; s < SLOUPCE; s++)
        {
            char znak = labyrint[r][s];

            if (znak == '1')
                printf("█ ");
            else if (znak == '0')
                printf(". ");
            else
                printf("%c ", znak);
        }
        printf("\n");
    }
}


// =================================
// REKURZIVNÍ HLEDÁNÍ (DOPLNIT)
// =================================
int najdiCestu(int r, int s)
{
    // TODO
    // vstup: souřadnice hráče r, s
    // výstup: 1 pokud existuje cesta do cíle, 0 pokud neexistuje

    return 0;
}


int main()
{
    printf("Labyrint:\n");
    vypisLabyrint();

    // start je v [0][0]
    int start_r = 0, start_s = 0;
    printf("Tvůj znak je: %c\n\n", labyrint[start_r][start_s]);

    printf("Hledam cestu...\n");

    if (najdiCestu(start_r, start_s))
        printf("Cesta existuje!\n");
    else
        printf("Cesta neexistuje.\n");

    return 0;
}
