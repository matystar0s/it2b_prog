#include <stdio.h>

int fib(int n) {
    printf("Zpracovava se fib(%d)\n", n);
    if (n == 1 || n == 2)
   	 return 1;
    printf("Vola se fib(%d) a fib(%d)\n", n-1, n-2);
    return fib(n-1) + fib(n-2);
}

int main() {
    printf("fib(6) = %d", fib(6));
    return 0;
}
