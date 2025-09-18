# Po-prázdninový Céčkový refresher


Nebojte se googlovat a hledat programátorské rady :)

### Násobné Ahoj světě!
Uživatel ti na vstupu zadá počet opakování. Následně tolikrát vypiš zprávu "Ahoj svete!".

Pokud uživatel zadá na vstupu záporné číslo, vypiš "*Neplatny vstup*" a ukonči program errorem.

Např.
- vstup: 3
- výstup:
  Ahoj svete!
  Ahoj svete!
  Ahoj svete!

### Vykreslení schodů
Načti číslo udávající výšku a znak. Následně z tohoto znaku vykresli schody o dané výšce.

Např.
- vstup: 5 "h"
- výstup:<br>
  h<br>
  hh<br>
  hhh<br>
  hhhh<br>
  hhhhh

### Vypsání dělitelů
Vytvoř program, který na vstupu načte celé kladné číslo. Následně vypíše všechny dělitele tohoto čísla.

Např.
- vstup: 12
- výstup:
  1
  2
  3
  4
  6
  12

### Čas příletu
Uživatel ti na vstupu zadá tři informace:
1. čas odletu – dvě celá čísla: hodiny *H* (0–23) a minuty *M* (0–59)
2. vzdálenost v kilometrech – nezáporné číslo *S*
3. rychlost letadla v km/h – kladné číslo *V*

Následně program vypíše v kolik hodin letadlo přiletí ve formátu HH:MM. Počítejte s tím, že letadlo může leťet přes noc a přiletět až další den.

Např.

- vstup: H=8hod, M=40min, S=900km, V=600km/h
- výstup: 10:10


- vstup: H=5hod, M=55min, S=20 000km, V=800km/h
- výstup: 6:55    (o 1 den později)

### Generátor rodného čísla:
Uživatel ti zadá:
- své datum narození (den, měsíc a rok)
- své pohlaví
- koncovku rodného čísla

Generuj z těchto údajů následně jeho rodné číslo dle tohoto diagramu:
  ![tahak k datu narození](helpers/datum-narozeni-1404272651.jpg)
  Např.
- vstup: 26.1.1985, Muž, 1158
- výstup: 850126/1158

### Validátor vstupu:
Uživatel musí na vstupu zadat libovolné kladné třímístného sudé číslo. Pokud uživatel zadá špatný vstup, podej mu chybovou hlášku a načítej vstup znovu (dokud nezadá vstup správný.)

### Vymazání duplicit
Vytvoř program, který na vstupu dostane pole čísel. Následně z tohoto pole vymaže veškeré duplicity.
Např.
- vstup: [3, 1, 3, 2, 1, 3]
- výstup: [3, 1, 2]

# Těžší příklad:

K řešení tohoto příkladu je potřeba umět *generovat náhodná čísla*, což jsme ještě nebrali. Řešte jej případně pomocí online nápověd.

### Generátor sudoku
Vytvoř program, která je schopna náhodně generovat zadání pro sudoku. Na základě hodnoty proměnné *komplet* má tento program dvě varianty:
- pokud *komplet=True* vypiš kompletní řešení generovaného sudoku
- pokud *komplet=False* vypiš pouze polovinu číslic ze zadání.