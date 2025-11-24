#include <stdio.h>

int main() {
    char word[100];

    printf("Enter a word: ");
    scanf("%99s", word);

    printf("ASCII codes of the word characters:\n");
    for (int i = 0; word[i] != '\0'; i++) {
        printf("%d ", (int)word[i]);
    }
    printf("\n");

    return 0;
}
