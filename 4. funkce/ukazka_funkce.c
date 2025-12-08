#include <stdio.h>


// FUNKCE si lze představit jako vlastní menší podprogramy
//   funkce se vytváří před main()

// funkci definujeme pomocí:    datového_typu_na_výstupu názvu(vstupu)
int umocni(int x) {
    int y = x*x;
    return y;   // funkce vrací hodnotu pomocí return
}

// funkce může mít na vstupu také více hodnot
float soucet(float a, float b) {
    return a + b;
}


int main() {
    int cislo1, cislo2;

    printf("Zadej prvni cele císlo:");
    scanf("%d", &cislo1);

    int druha_mocnina = umocni(cislo1);
    printf("Druhá mocnina tohoto čísla je: %d\n\n", druha_mocnina);

    printf("Zadej druhe cele císlo:");
    scanf("%d", &cislo2);
    printf("Součet těchto čísel je: %d\n", (int) soucet(cislo1, cislo2));

    return 0;
}
