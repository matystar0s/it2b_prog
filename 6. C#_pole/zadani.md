
# Úlohy – C#: pole a stringy (IT2)

---

## Úlohy – Průchod polem

### 1. Součet prvků v poli
Vytvoř pole čísel (např. desetinných) a spočítej součet všech jeho prvků.

- použij cyklus `foreach` (nebo `for`)
- vypiš výslednou sumu

---

## Úlohy – Statistika nad polem

### 2. Statistika z 10 hodnot
Zkuste si vytvořit pole o délce **10**.

Uživatel zadá **10 desetinných čísel**.

Zjisti a vypiš:
1. **maximum**
2. **rozdíl mezi minimem a maximem**
3. **tři nejnižší hodnoty**
4. **medián**

---

## Úlohy – Procvičení (C#: pole)

### 3. Seřazení a výpis
Vypiš prvky libovolného pole **od největšího po nejmenší**.

---

### 4. Anomálie
Vytvoř funkci, která spočítá, **kolik hodnot v poli jsou anomálie**.

- anomálie je prvek, který je **menší / větší než oba jeho sousedé**
- **okraje pole nejsou anomálie**

#### Příklad:
`{0, 20, 55, 40, 11, 15, 28, 55, 4}` → `2`  
(anomálie: `55`, `11`, `55`)

---

### 5. Hodnota akcií (2 funkce)
Máš pole reprezentující **akcie firmy v čase**.

Vytvoř dvě funkce:

#### 5.1 Akcie nad průměrem
Vrátí **procento**, kolik procent času jsou akcie **nad průměrem**.

- výsledek jako číslo v intervalu `<0; 1>`

**Příklad:**  
`{0, 100, 100}` → `0.66666`

#### 5.2 Délka růstu firmy
Vrátí **největší počet narůstajících hodnot za sebou** (nejdelší souvislý rostoucí úsek).

**Příklad:**  
`{0, 20, 55, 40, 11, 15, 28, 55, 4}` → `4`  
(úsek: `11, 15, 28, 55`)

---

## Úlohy – Predikáty nad polem

Vytvoř **řadu funkcí**, které mají na vstupu pole čísel.  
Funkce vrací vždy jen **booleovskou hodnotu `true` / `false`**.

Vymysli vhodný název funkce.

### 6. Všechny prvky jsou kladné
Vrať `true`, pokud jsou **všechny prvky pole kladné**.

### 7. Pole je seřazené
Vrať `true`, pokud je **pole seřazené od nejmenšího po největší**.

### 8. Pole obsahuje duplicitu
Vrať `true`, pokud pole obsahuje **alespoň dva stejné prvky**.

### 9. Pole obsahuje pouze prvočísla
Vrať `true`, pokud pole obsahuje **jen prvočísla**.

### 10. Společný dělitel
Vrať `true`, pokud všechny prvky mají **stejného dělitele většího než 1**.

---

## Úlohy – Stringy

### 11. Korektní login
Vytvoř proměnné:

- `login`
- `heslo`
- `message`

Program:

- vypíše `message` jen pokud uživatel zadá **správné přihlašovací údaje**
- v případě chyby vypíše, zda je chyba **v loginu nebo v heslu**

---

### 12. Cenzura znaku
Uživatel zadá:

- `string`
- `char`

Vypiš nový string, ve kterém **nahradíš všechny výskyty znaku `char` znakem `*`**.

#### Příklad

`"shot", 'o'` → `"sh*t"`

---

### 13. Kvíz
Vytvoř **malý kvíz**.

- do pole `string[]` zadej **5 kvízových otázek**
- vytvoř druhé pole se **správnými odpověďmi**
- postupně zobraz otázky uživateli
- počítej **počet správných odpovědí**

---

## Úlohy – Metody stringů

### 14. Validace emailu
Vytvoř funkci, která **ověří správnost emailové adresy**.

Podmínky:

- email obsahuje **právě jeden znak `@`**
- `@` **není první znak**
- za `@` se nachází **alespoň jedna tečka `.`**

---

### 15. Velká vs malá písmena
Na vstupu dostaneš:

- zprávu
- písmeno

Rozhodni, zda se ve zprávě dané písmeno **častěji vyskytuje jako malé nebo velké**.

#### Příklad

`"CIA ma znamku AAA", "a"` → **velké**  
(4 × `A`, 2 × `a`)

---

### 16. Síla signálu
Simuluj změnu **síly signálu** podle znaků ve stringu.

- `s` → sníží signál o **1**
- `w` → zvýší signál o **1**
- `S` → sníží signál o **3**
- `W` → zvýší signál o **3**

Úkol:

1. spočítej **konečnou hodnotu signálu**
2. zkus **vykreslit průběh změny signálu**

#### Příklad:

Mějme na vstupu: wsSWs
Konečná hodnota: -1
Průběh: 0 → 1 → 0 → -3 → 0 → -1
Vykreslení:
```
 X
X  X
    X
  X
  ```

---

## Úlohy – Listy

### 17. Odstranění hodnoty
Vytvoř funkci, která na vstupu dostane list a hodnotu listu. Následně z listu odstranění veškeré výskyty této hodnoty.

### 18. Databáze filmů (List)
Vytvoř aplikaci:

Použij dva listy:
- názvy filmů (`List<string>`)
- hodnocení (`List<double>`)

Program musí umět:
- přidat film
- vypsat filmy podle roku / názvu
- spočítat průměrné hodnocení
- smazat film podle názvu
  
---

K přepisu úloh z prezentace do markdownu byl využit ChatGPT-5.2
