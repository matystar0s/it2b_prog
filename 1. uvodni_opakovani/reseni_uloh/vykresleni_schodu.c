#include <stdio.h>
#include <stdlib.h>

int main() {
    int vyska;
    char znak;

    // Načtení vstupu od uživatele
    printf("Zadej vysku: ");
    scanf("%d", &vyska);
    printf("Zadej znak: ");
    scanf(" %c", &znak);

    // Neplatný vstup
    if (vyska <= 0) {
        printf("*Neplatna vyska*\n");
        return 1;
    }

    // Vykreslení schodů
    for (int i = 1; i <= vyska; i++) {
        for (int j = 0; j < i; j++) {
            printf("%c", znak);
        }
        printf("\n");
    }

    return 0;
}
