#include <stdio.h>
#include <stdlib.h>

int main() {
    int opakovani;

    // Získání vstupu
    printf("Zadej pocet opakovani: ");
    scanf("%d", &opakovani);

    // Záporný vstup – chyba
    if (opakovani < 0) {
        printf("*Neplatny vstup*\n");
        return 1;
    }

    // Výpis zprávy tolikrát, kolik uživatel zadal
    for (int i = 0; i < opakovani; i++) {
        printf("Ahoj svete!\n");
    }

    return 0; // Úspěšné ukončení
}
