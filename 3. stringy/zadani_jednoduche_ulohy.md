# Úlohy – Stringy

### 1. Výpis znaků
- Nech uživatele zadat libovolný string (max. délka 20).
- Pomocí cyklu vypiš všechny znaky tohoto stringu.

**Ukázka výstupu:**
```
Zadej string: ahoj
a
h
o
j
```

---

### 2. Je znak ve stringu?
- Uživatel zadá libovolné slovo.
- Uživatel zadá libovolný znak (char).
- Rozhodni, jestli se tento znak nachází v daném stringu.

**Ukázka vstupu/výstupu:**
```
Zadej text: voda
Zadej znak: d
Znak 'd' se ve stringu nachází.
```

```
Zadej text: voda
Zadej znak: x
Znak 'x' se ve stringu nenachází.
```

---

### 3. Délka stringu
- Vytvoř libovolný string.
- Pomocí cyklu `while` a koncové nuly zjisti délku stringu.

**Ukázka výstupu:**
```
Zadej string: ahoj
Délka stringu je: 4
```

---

### 4. Cenzura
- Načti string od uživatele.
- Vypiš vycezurovaný string → každý druhý znak nahraď křížkem `#`.

**Ukázka výstupu:**
```
Zadej text: doslova1984
Výsledek: d#s#o#a#9#4
```

---

### 5. Samohlásky
- Načti string od uživatele.
- Vypiš, kolik malých samohlásek obsahuje (a, e, i, o, u, y).

**Ukázka výstupu:**
```
Zadej text: matematika
Počet samohlásek: 5
```

---

### 6. Substring
- Načti dva stringy – `str` a `substr`.
- Rozhodni, jestli je `substr` součástí `str`.

**Ukázka výstupu:**
```
Zadej text: vodnik
Zadej podřetězec: vod
Podřetězec nalezen!
```

```
Zadej text: team
Zadej podřetězec: i
Podřetězec nenalezen.
```

---

### 7. Palindrom
- Načti string od uživatele.
- Rozhodni, zda je daný string palindrom.

**Ukázka výstupu:**
```
Zadej text: oko
Je to palindrom.
```

```
Zadej text: voda
Není to palindrom.
```

---

### 8. Stejná předpona
- Načti dva stringy.
- Vypiš jejich společnou předponu (shodné znaky na začátku).

**Ukázka výstupu:**
```
Zadej první text: podnik
Zadej druhý text: podchod
Společná předpona: pod
```

---

### 9. Anagram
- Načti dva stringy – `str1` a `str2`.
- Rozhodni, jestli lze `str2` vytvořit ze znaků `str1`.

**Ukázka výstupu:**
```
Zadej první text: lalok
Zadej druhý text: kola
Jde o anagram.
```

```
Zadej první text: jelen
Zadej druhý text: lejno
Nejde o anagram.
```

---

## 10. Bonusové úlohy

### 10.1 Počet slov
- Načti větu a spočítej, kolik obsahuje slov (oddělených mezerou).

**Ukázka výstupu:**
```
Zadej větu: Toto je testovací věta.
Počet slov: 4
```

---

### 10.2 Obrácený text
- Načti libovolný string a vypiš ho obráceně.

**Ukázka výstupu:**
```
Zadej text: program
Obráceně: margorp
```

---

### 10.3 Velká a malá písmena
- Načti libovolný string.
- Vypiš jej s opačnou velikostí písmen (malá → velká, velká → malá).

**Ukázka výstupu:**
```
Zadej text: AhojSvete
Výsledek: aHOJsVETE
```

---

### 10.4 Kryptografie – Caesarova šifra
- Načti text a posuň každé písmeno o 3 pozice v abecedě.
- Např. A → D, B → E, …, X → A.

**Ukázka výstupu:**
```
Zadej text: abcxyz
Výsledek: defabc
```

---

### 10.5 Statistika znaků
- Načti libovolný string a spočítej, kolikrát se v něm vyskytují jednotlivé znaky.

**Ukázka výstupu:**
```
Zadej text: mama
m: 2
a: 2
```
