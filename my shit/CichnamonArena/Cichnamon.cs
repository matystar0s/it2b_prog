namespace CichnamonArena
{
    class Cichnamon
    {
        public string Jmeno { get; private set; }
        public int AktualniZdravi { get; private set; }
        public int MaximalniZdravi { get; private set; }
        public int BonusSila { get; private set; }
        public Utok ZakladniUtok { get; private set; }
        public Utok SpecialniUtok { get; private set; }

        public Cichnamon(string jmeno, int maxZdravi, int bonusSila, Utok zakladniUtok, Utok specialniUtok)
        {
            Jmeno = jmeno;
            MaximalniZdravi = maxZdravi;
            AktualniZdravi = maxZdravi;
            BonusSila = bonusSila;
            ZakladniUtok = zakladniUtok;
            SpecialniUtok = specialniUtok;
        }

        public bool JeNazivu()
        {
            return AktualniZdravi > 0;
        }

        public void SnizZdravi(int poskozeni)
        {
            AktualniZdravi -= poskozeni;
            if (AktualniZdravi < 0)
                AktualniZdravi = 0;
        }

        public void Uzdravi(int pocetZivotu)
        {
            AktualniZdravi += pocetZivotu;
            if (AktualniZdravi > MaximalniZdravi)
                AktualniZdravi = MaximalniZdravi;
        }

        public void NavysMaxZdravi(int hodnota)
        {
            MaximalniZdravi += hodnota;
            AktualniZdravi += hodnota;
        }

        public void NavysBonusSilu(int hodnota)
        {
            BonusSila += hodnota;
        }

        public int ProvedZakladniUtok(Cichnamon protivnik)
        {
            int poskozeni = ZakladniUtok.ZiskejPoskozeni() + BonusSila;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"\n  {Jmeno} použil {ZakladniUtok.Nazev}!");
            Console.ResetColor();
            Console.WriteLine($"  {ZakladniUtok.Popis}");
            protivnik.SnizZdravi(poskozeni);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"  {protivnik.Jmeno} utrpěl {poskozeni} poškození!");
            Console.ResetColor();
            return poskozeni;
        }

        public int ProvedSpecialniUtok(Cichnamon protivnik)
        {
            int poskozeni = SpecialniUtok.ZiskejPoskozeni() + BonusSila;
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"\n  {Jmeno} použil {SpecialniUtok.Nazev}!");
            Console.ResetColor();
            Console.WriteLine($"  {SpecialniUtok.Popis}");
            protivnik.SnizZdravi(poskozeni);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"  {protivnik.Jmeno} utrpěl {poskozeni} poškození!");
            Console.ResetColor();
            return poskozeni;
        }

        public void VypisInfo()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"\n=== {Jmeno} ===");
            Console.ResetColor();
            Console.WriteLine($"  Zdraví:    {AktualniZdravi}/{MaximalniZdravi}");
            Console.WriteLine($"  Bonus síla: +{BonusSila}");
            Console.Write("  Základní útok:  "); ZakladniUtok.VypisInfo();
            Console.Write("  Speciální útok: "); SpecialniUtok.VypisInfo();
        }

        public void VypisZdravi()
        {
            int sirka = 20;
            int plne = (int)((double)AktualniZdravi / MaximalniZdravi * sirka);
            string bar = "[" + new string('█', plne) + new string('░', sirka - plne) + "]";

            ConsoleColor barva = AktualniZdravi > MaximalniZdravi / 2
                ? ConsoleColor.Green
                : AktualniZdravi > MaximalniZdravi / 4
                    ? ConsoleColor.Yellow
                    : ConsoleColor.Red;

            Console.ForegroundColor = barva;
            Console.Write($"  {bar}");
            Console.ResetColor();
            Console.WriteLine($" {AktualniZdravi}/{MaximalniZdravi} HP");
        }
    }
}
