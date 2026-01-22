# Úlohy – Základy C# (IT2)

---

## Úlohy – Vstup a výstup

### 1. Výplata profesora
Profesor učí:
- 2hodinové přednášky
- 1hodinové semináře

Uživatel zadá:
- počet přednášek,
- počet seminářů,
- hodinovou mzdu profesora.

Vypočítej a vypiš celkovou výplatu profesora.

---

### 2. Farma se zvířaty
Na farmě žijí **kuřata a prasata** (žádná jiná zvířata).

Uživatel zadá:
- celkový počet nohou zvířat,
- počet prasat.

Vypočítej, kolik je na farmě kuřat.

---

### 3. Prezidentské volby
Ve volbách byli dva kandidáti: **X** a **Y**.

Uživatel zadá:
- počet hlasů pro kandidáta X,
- počet hlasů pro kandidáta Y.

Vypiš:
- kolik procent hlasů získal kandidát X,
- kolik procent hlasů získal kandidát Y.

---

### 4. Kalkulačka
Vytvoř jednoduchou kalkulačku.

Uživatel zadá:
- dvě čísla,
- matematickou operaci (`+`, `-`, `*`, `/`).

Program vypíše výsledek výpočtu.

---

### 5. Šachovnice 3×3
Uživatel zadá **dva znaky**.

Vytiskni šachovnici o velikosti **3×3**, kde se znaky střídají.

---

## Úlohy – Řízení toku

### 6. FizzBuzz
Vypisuj čísla od **1 do N** podle pravidel hry FizzBuzz:

- číslo dělitelné 3 → vypiš `Fizz`,
- číslo dělitelné 5 → vypiš `Buzz`,
- číslo dělitelné 15 → vypiš `FizzBuzz`,
- jinak vypiš číslo.

Uživatel zadá číslo `N`.

---

### 7. Nejbližší vyšší mocnina dvojky
Uživatel zadá celé číslo `N`.

Najdi a vypiš **nejbližší vyšší mocninu čísla 2**.

#### Příklady:
15 → 16 (2^4)
56 → 64 (2^6)

---


---

### 8. Kontrola číselné posloupnosti
Uživatel postupně zadává celá čísla (konec zadávání je `0`).

Každé nové číslo musí splňovat:
- je **větší** než předchozí,
- má **opačnou paritu** než předchozí (sudé ↔ liché),
- sdílí **alespoň jednu stejnou číslici** s předchozím číslem.

Rozhodni, zda celá posloupnost splňuje pravidla.

---

## Úlohy – Funkce (metody)

### 9. Součet cifer
Vytvoř funkci, která:
- přijme celé číslo,
- spočítá a vrátí **součet jeho cifer**.

---

### 10. Největší společný dělitel
Vytvoř funkci, která:
- přijme dvě celá čísla,
- vrátí jejich **největší společný dělitel (NSD)**.

---

### 11. Kontrolní kód čísla
Vytvoř algoritmus pro kontrolní kódování čísla:

- projdi číslo **po cifrách zprava doleva**,
- začni na pozici 0,
- cifry na lichých pozicích **přičti**,
- cifry na sudých pozicích **odečti**,
- vrať **absolutní hodnotu výsledku**.

#### Příklad:
57291 → abs(1 - 9 + 2 - 7 + 5) = 8


Vytvoř dvě funkce:
- `int VypocitejKod(int n)` – vypočítá kontrolní kód,
- `void Kontrola(int n, int kod)` – vypíše, zda je kód správný.

---


Toť vše.

K převodu úloh z prezentace do tohoto souboru bylo využito AI (ChatGPT 5.2)

