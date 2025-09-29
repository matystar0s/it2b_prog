# Úloha – Simulace voleb do Poslanecké sněmovny 2025

Zkusme vytvořit program, simulující volby do Poslanecké sněmovny 2025.

## Zadání

1. Měj pole s názvy alespoň 6 politických stran, např.:

```c
{ "ANO", "SPOLU", "SPD", "STAN", "Piráti", "Motoristé", "Stačilo", "Jiné" }
```
<br>

2. Měj pole s preferencemi stran.

```c
{ 29.3, 20.5, 13.4, 11.1, 10, 6, 5.5,  4.2}
// data z průzkumu STEM 28.9.
```

- (bonus) přidej prvek náhody k těmto preferencím. Každou z preferencí např. náhodně uprav o +- 2%. Preference musí dohromady dávat 100%.
<br><br>

3. Program vygeneruje **náhodné procento voličů** v rozsahu 50% až 80%.
<br><br>

4. Simuluj hlasování do voleb
- Hlasování se simuluje tak, že pro každého voliče se náhodně vybere strana, která získá hlas.
- Hlasy generuj podle pole s preferencemi stran.
<br><br>

5. Výstup programu:
- Celkový počet hlasů každé strany.
- **Procentuální zisk** (zaokrouhlený na 2 desetinná místa).
- Informace, zda se strana dostala do sněmovny (hranice 5 %).
- Stranu s **největším počtem hlasů**.
<br><br>

6. Vypiš **histogram výsledků** voleb
- `*` odpovídá 1 % hlasů.
- Např.:

```
ANO:        32.5 %  ********************************
SPOLU:      21.3 %  *********************
SPD:        10.7 %  **********
STAN:        8.4 %  ********
Piráti:      7.8 %  *******
Motoristé:   5.6 %  *****
Stačilo:     4.1 %  ****
Jiné:        9.6 %  *********
```
<br><br>

7. Spočítej, kolik která strana dostane mandátů.
<br><br>

---

## Možná rozšíření

- Umožni uživateli zadat **počet stran**, preference stran a jejich názvy.
- Vypiš všechny možnosti **volebních koalic** – všechny minumální množiny stran, které dohromady získají většinu.
- Umožni porovnání více simulací (např. 100 běhů) a spočítej průměrné výsledky.

---
