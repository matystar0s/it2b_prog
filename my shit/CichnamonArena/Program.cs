using CichnamonArena;

Console.OutputEncoding = System.Text.Encoding.UTF8;

// ── Uvítání ──────────────────────────────────────────────────────
Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("╔══════════════════════════════════════╗");
Console.WriteLine("║      Vítej v  ČICHNAMON ARÉNĚ!      ║");
Console.WriteLine("╚══════════════════════════════════════╝");
Console.ResetColor();

// ── Jména trenérů ────────────────────────────────────────────────
Console.Write("\nZadej své jméno: ");
string jmenoHrace = Console.ReadLine()?.Trim() ?? "Trenér";
if (string.IsNullOrWhiteSpace(jmenoHrace)) jmenoHrace = "Trenér";

Console.Write("Zadej jméno soupeře (počítač): ");
string jmenoPocitace = Console.ReadLine()?.Trim() ?? "Zlý trenér";
if (string.IsNullOrWhiteSpace(jmenoPocitace)) jmenoPocitace = "Zlý trenér";

Trener hrac    = new Trener(jmenoHrace);
Trener pocitac = new Trener(jmenoPocitace);
Random rnd     = new Random();

// ── Výběr startovního čichnamona ─────────────────────────────────
List<Cichnamon> startovni = CichnamonFactory.VytvorStartovni();

Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("\nVyber si svého Čichnamona:\n");
Console.ResetColor();

for (int i = 0; i < startovni.Count; i++)
{
    Console.WriteLine($"  {i + 1} - {startovni[i].Jmeno}");
    startovni[i].VypisInfo();
}

int volba = ZiskejVolbu(1, startovni.Count, "Tvoje volba");
Cichnamon vybrany = startovni[volba - 1];
hrac.PridejCichnamona(vybrany);
hrac.VyberCichnamona(0);

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"\n  ✔ Vybral sis: {vybrany.Jmeno}");
Console.ResetColor();

// ── Herní smyčka ─────────────────────────────────────────────────
bool hraBeží = true;
int soubojCislo = 0;
List<Cichnamon> souperiPool = CichnamonFactory.VytvorProtivniky();

while (hraBeží && hrac.MaCichnamony())
{
    soubojCislo++;

    // Každý 2. souboj dostane hráč nového čichnamona
    if (soubojCislo > 1 && soubojCislo % 2 == 0)
    {
        List<Cichnamon> noviC = CichnamonFactory.VytvorStartovni();
        Cichnamon novy = noviC[rnd.Next(noviC.Count)];
        hrac.PridejCichnamona(novy);
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine($"\n  🎁 Za věrnost ti přibyl nový čichnamon: {novy.Jmeno}!");
        Console.ResetColor();
    }

    // Výběr soupeřova čichnamona
    pocitac = new Trener(jmenoPocitace);
    Cichnamon souper = souperiPool[rnd.Next(souperiPool.Count)];
    // Reset soupeřova zdraví (nový souboj = nový čichnamon)
    Cichnamon souperKopie = CichnamonFactory.VytvorProtivniky()
        .First(c => c.Jmeno == souper.Jmeno);
    pocitac.PridejCichnamona(souperKopie);
    pocitac.VyberNahodneho(rnd);

    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine($"\n  Protivník je: {pocitac.AktualniCichnamon!.Jmeno}");
    Console.ResetColor();

    // Pokud má hráč více čichnamonů, vybere si
    if (hrac.Cichnamoni.Count > 1)
    {
        Console.WriteLine("\nVyber svého čichnamona do souboje:");
        for (int i = 0; i < hrac.Cichnamoni.Count; i++)
        {
            Cichnamon c = hrac.Cichnamoni[i];
            Console.WriteLine($"  {i + 1} - {c.Jmeno}  (HP: {c.AktualniZdravi}/{c.MaximalniZdravi})");
        }
        int vi = ZiskejVolbu(1, hrac.Cichnamoni.Count, "Tvoje volba");
        hrac.VyberCichnamona(vi - 1);
    }
    else
    {
        hrac.VyberCichnamona(0);
    }

    // Spuštění souboje
    Souboj souboj = new Souboj(hrac, pocitac);
    bool vitez = souboj.Spustit();

    if (vitez)
    {
        hrac.ZvysLevel();
    }
    else
    {
        hrac.OdebratPorazeného();
        if (!hrac.MaCichnamony())
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n  💀 Nemáš žádné čichnamony! Hra končí.");
            Console.ResetColor();
            break;
        }
    }

    // Hrát dál?
    Console.WriteLine("\nChceš hrát další souboj?");
    Console.WriteLine("  1 - Ano, do boje!");
    Console.WriteLine("  2 - Ne, skončit hru.");
    int dalsi = ZiskejVolbu(1, 2, "Tvoje volba");
    if (dalsi == 2) hraBeží = false;
}

// ── Konec hry ────────────────────────────────────────────────────
Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("\n╔══════════════════════════════════════╗");
Console.WriteLine("║           KONEC HRY                  ║");
Console.WriteLine($"║  Trenér {hrac.Jmeno,-28}║");
Console.WriteLine($"║  Dosažený level: {hrac.Level,-19}║");
Console.WriteLine("╚══════════════════════════════════════╝");
Console.ResetColor();
Console.WriteLine("\nDíky za hru! Stiskni Enter pro ukončení...");
Console.ReadLine();

// ── Pomocná funkce ────────────────────────────────────────────────
static int ZiskejVolbu(int min, int max, string prompt)
{
    while (true)
    {
        Console.Write($"\n  {prompt}: ");
        string? vstup = Console.ReadLine();
        if (int.TryParse(vstup, out int v) && v >= min && v <= max)
            return v;
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"  Neplatná volba. Zadej číslo {min}–{max}.");
        Console.ResetColor();
    }
}
