# Úlohy – Generování náhody


### 1. Hod mincí
- Vytvoř program, který vypíše výsledek hodu mincí. Pokud program vygeneruje 0 vypiš "*panna*". Při generování 1 vypiš "*orel*".

**Ukázka výstupu:**
```
Výsledek hodu: panna
```

```
Výsledek hodu: orel
```

---

### 2. Hod kostkou
- Vytvoř program, který vypíše výsledek hodu kostkou (číslo 1 až 6).  
- Rozšiř:  
  - možnost zvolit si počet kostek a vypiš součet,  
  - možnost zvolit si počet stěn kostky (např. 20).  

**Ukázka vstupu/výstupu:**
```
Zadej počet kostek: 2
Zadej počet stěn kostky: 6
Hody: 3 5
Součet: 8
```

```
Zadej počet kostek: 1
Zadej počet stěn kostky: 20
Hod: 17
```

---

### 3. Hádej číslo
- Vygeneruj náhodnéčíslo 1 až 100.  
- Uživatel hádá číslo.  
- Po každém odhadu vypiš, zda číslo uhodl, nebo jestli hádá příliš nízko/vysoko.  
- Nakonec vypiš, na kolik pokusů uhodl, a nabídni možnost hrát znovu.  

**Ukázka vstupu/výstupu:**
```
Hádej číslo (1-100): 50
Moc nízko!
Hádej číslo (1-100): 75
Moc vysoko!
Hádej číslo (1-100): 62
Uhodl jsi! Počet pokusů: 3
Chceš hrát znovu? (a/n): n
```

---

## 4. Generátor hesla
Vytvoř generátor dobrého hesla.  

Dobré heslo je takové heslo, které:  
- má náhodnou délku 7–12 znaků,  
- obsahuje alespoň 1 náhodné číslo na náhodné pozici,  
- obsahuje alespoň 1 ze znaků `. , - #` na náhodné pozici,  
- na zbytku pozic má náhodné abecední znaky.  

**Ukázka výstupu:**
```
Vygenerované heslo: p7m.rQa
```

```
Vygenerované heslo: Zd3a#RkL8
```

---

## 4. Pokročilé úlohy

### 4.1 Simulace pokeru
- Napiš program, který simuluje ruku pokeru.
- Vygeneruj: 2 karty na stole a 3 karty v ruce
- Zjisti, jaké je nejvyšší hodnota karet, kterou hráč má. Jaké je nejvyšší karty? Má hráč nějakou dvojici? Má hráč postupku?

### 4.2 Monte Carlo simulace
- Pomocí generování náhodných čísel odhadni hodnotu čísla π.  
- Postup: vygeneruj N náhodných bodů do čtverce 1x1 a spočítej, kolik z nich leží v kruhu o poloměru 1.  
- Využij vztah: π ≈ 4 * (počet bodů v kruhu / celkový počet bodů).  
- viz https://cs.wikipedia.org/wiki/Metoda_Monte_Carlo 

### 4.3 Generátor sudoku
Vytvoř program, která je schopna náhodně generovat zadání pro sudoku. Na základě hodnoty proměnné *komplet* má tento program dvě varianty:
- pokud *komplet=True* vypiš kompletní řešení generovaného sudoku
- pokud *komplet=False* vypiš pouze polovinu číslic ze zadání.
