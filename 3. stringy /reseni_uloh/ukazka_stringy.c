#include <stdio.h>


int main() {
    // Tvorba stringu a vypsání:
    char str1[] = {'H','e','l','l','o','\0'};   // string končí koncovou nulou
    char str2[] = "Hello";                      // zkrácený zápis

    printf("str1: %s\n", str1);
    printf("str2: %s\n", str2);


    // Vstup uživatele:
    char input_str[40];
    printf("Zadej string: ");
    scanf(" %39s", input_str);  // uživatel smí zadat max 39 znaků - nutno započítat koncovou nulu
      // všimni si:
      //    - mezery před %s
      //    - limitu 39 znaků
      //    - absence &

    printf("Zadaný string: %s", input_str);
  
    return 0;
}
