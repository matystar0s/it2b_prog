# Úlohy – Práce s poli a náhodou v jazyce C

## 1. Náhodný prvek z pole
Mějme pole s 5 libovolnými písmeny, např.:

```c
{ 'a', 'b', 'c', 'd', 'e' }
```

Úkolem je **vypsat náhodný prvek** tohoto pole.

---

## 2. Simulace známek studenta
Vytvoř program, který bude simulovat známky studenta.

1. Do pole o délce 10 vygeneruj náhodné známky (např. 1–5).
2. Program následně vypíše:
   - průměr známek studenta,
   - nejlepší známku,
   - nejhorší známku.
3. Zjisti a vypiš:
   - **nejčastější hodnotu** v poli,
   - **známku, kterou dostane student na vysvědčení** (zaokrouhlený průměr).
4. (Bonus) Pokud dovedeš, vypiš **histogram** známek.

---

## 3. Generátor hesla
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

