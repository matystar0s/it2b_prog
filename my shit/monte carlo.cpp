#include <math.h>
#include <time.h>
#include <stdio.h>
#include <stdlib.h>  

int main(){
    srand(time(NULL));

    const int RES = 1000;
    const float NUM = 10000000;
    float y;
    float x;
    int in = 0;
    for (int i = 0; i < NUM; i++)
    {
        float x = rand() % RES;
        float y = rand() % RES;

        if (sqrt(x*x + y*y) <= RES){
            in++;
        }
    }

    float pi = (in/NUM)*4.0;
    printf("pi = %f", pi);
    
    return 0;
}