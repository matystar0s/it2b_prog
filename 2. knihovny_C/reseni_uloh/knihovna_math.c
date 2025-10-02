#include <stdio.h>
#include <math.h>   

int main() {

    // sqrt() - odmocnina
    //     vystup je typu float   (ve skutečnostidouble)
    int cislo = 4;
    printf("Cislo: %d\n", cislo);
    printf("Odmocnina: %f\n\n", sqrt(cislo));


    // round() - zaokrouhleni
    //     vystup je typu float   (ve skutečnostidouble)
    float desetinne = 15.87;
    printf("Cislo: %f\n", desetinne);
    printf("Zaokrouhleno: %f\n\n", round(desetinne));


    // M_PI - konstanta cislo pi
    printf("Cislo PI: %f", M_PI);


    return 0;
}
