// Tento kód je CHYBNÝ
/*
    V kódu se nachází 6 klasických chyb při práci se stringy.
    Najdi je a zkus je opravit.
*/

#include <stdio.h>


int main() {
    char heslo[] = "mamRadChleba24";
    printf("Delka hesla je: %d\n", strlen(heslo));
        
    char slovo[5];
    int delkaVstupu = strlen(slovo);
    
    printf("Zadej slovo: ");
    scanf("%s", &slovo);

    if (strcmp(slovo, heslo)) {
        printf("Zadal jsi správné heslo.\n");
    } else {
        printf("Zadal jsi špatné heslo.\n");
    }

    return 0;
}
