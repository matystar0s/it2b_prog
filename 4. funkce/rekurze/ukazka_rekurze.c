#include <stdio.h>


// REKURZE značí funkci, která volá sebe samotnou

int suma(int cislo) {
    if (cislo == 1) {
        return 1;
    }

    return cislo + suma(cislo-1);
}

void vypisCislaDoN(int n) {
    if (n == 0) {
        return;
    }
    vypisCislaDoN(n-1);
    printf("%d\n", n);
}


int main() {
    int vystup = suma(5);
    printf("Vystup rekurzivniho vypoctu sumy je %d\n\n", vystup);

    vypisCislaDoN(5);

    return 0;
}
