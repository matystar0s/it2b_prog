namespace CichnamonArena
{
    class Souboj
    {
        private Trener hrac;
        private Trener pocitac;
        private Random rnd;
        private bool specialniPouzit;
        private bool leceniPouzito;
        private int tahCislo;

        public Souboj(Trener hrac, Trener pocitac)
        {
            this.hrac = hrac;
            this.pocitac = pocitac;
            rnd = new Random();
            specialniPouzit = false;
            leceniPouzito = false;
            tahCislo = 1;
        }

        public bool Spustit()
        {
            Cichnamon hracuvC = hrac.AktualniCichnamon!;
            Cichnamon pocitacuvC = pocitac.AktualniCichnamon!;

            VypisSoubojHlavicka(hracuvC, pocitacuvC);

            while (hracuvC.JeNazivu() && pocitacuvC.JeNazivu())
            {
                VypisStav(hracuvC, pocitacuvC);
                Console.WriteLine($"\n--- TAH {tahCislo} ---");

                // Hráčův tah
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n  >> TVŮJ TAH <<");
                Console.ResetColor();
                TahHrace(hracuvC, pocitacuvC);

                if (!pocitacuvC.JeNazivu()) break;

                // Počítačův tah
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n  >> TAH PROTIVNÍKA <<");
                Console.ResetColor();
                TahPocitace(pocitacuvC, hracuvC);

                tahCislo++;
                CekejNaEnter();
            }

            return VyhodnotSouboj(hracuvC, pocitacuvC);
        }

        private void TahHrace(Cichnamon muj, Cichnamon protivnik)
        {
            Console.WriteLine();
            Console.WriteLine($"  1 - Základní útok: {muj.ZakladniUtok.Nazev} ({muj.ZakladniUtok.ZiskejPoskozeni() + muj.BonusSila} poš.)");

            bool muzePouzitSpecialni = !specialniPouzit || tahCislo % 2 == 0;
            if (muzePouzitSpecialni)
                Console.WriteLine($"  2 - Speciální útok: {muj.SpecialniUtok.Nazev} ({muj.SpecialniUtok.ZiskejPoskozeni() + muj.BonusSila} poš.)");
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine($"  2 - Speciální útok: {muj.SpecialniUtok.Nazev} (nedostupný – počkej kolo)");
                Console.ResetColor();
            }

            if (!leceniPouzito)
                Console.WriteLine($"  3 - Léčení (+20 HP)");
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine($"  3 - Léčení (již použito)");
                Console.ResetColor();
            }

            int volba = ZiskejVolbu(1, 3);

            switch (volba)
            {
                case 1:
                    muj.ProvedZakladniUtok(protivnik);
                    break;
                case 2:
                    if (muzePouzitSpecialni)
                    {
                        muj.ProvedSpecialniUtok(protivnik);
                        specialniPouzit = true;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("  Speciální útok ještě není dostupný! Provedl se základní útok.");
                        Console.ResetColor();
                        muj.ProvedZakladniUtok(protivnik);
                    }
                    break;
                case 3:
                    if (!leceniPouzito)
                    {
                        muj.Uzdravi(20);
                        leceniPouzito = true;
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"\n  {muj.Jmeno} se vyléčil o 20 HP!");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("  Léčení již bylo použito! Provedl se základní útok.");
                        Console.ResetColor();
                        muj.ProvedZakladniUtok(protivnik);
                    }
                    break;
            }
        }

        private void TahPocitace(Cichnamon muj, Cichnamon protivnik)
        {
            // Počítač střídá nebo náhodně volí útok
            bool pouzijSpecialni = tahCislo % 2 == 0 || rnd.Next(3) == 0;

            if (pouzijSpecialni)
                muj.ProvedSpecialniUtok(protivnik);
            else
                muj.ProvedZakladniUtok(protivnik);
        }

        private bool VyhodnotSouboj(Cichnamon hracuvC, Cichnamon pocitacuvC)
        {
            Console.WriteLine("\n════════════════════════════════");
            if (hracuvC.JeNazivu())
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"\n  🏆 VYHRÁLS! {hracuvC.Jmeno} zvítězil!");
                Console.ResetColor();
                VypisStavCichnamona(hracuvC);
                NabidniUpgrade(hracuvC);
                return true;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"\n  💀 PROHRÁLS! {hracuvC.Jmeno} byl poražen.");
                Console.ResetColor();
                return false;
            }
        }

        private void NabidniUpgrade(Cichnamon vitez)
        {
            Console.WriteLine("\n  Vítěz si vybere odměnu:");
            Console.WriteLine("  1 - Zvýšit maximální zdraví (+15 HP)");
            Console.WriteLine("  2 - Zvýšit bonus k útoku (+3)");
            int volba = ZiskejVolbu(1, 2);
            if (volba == 1)
            {
                vitez.NavysMaxZdravi(15);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"  {vitez.Jmeno} má nyní {vitez.MaximalniZdravi} max HP!");
            }
            else
            {
                vitez.NavysBonusSilu(3);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"  {vitez.Jmeno} má nyní +{vitez.BonusSila} bonus k útoku!");
            }
            Console.ResetColor();
        }

        private void VypisSoubojHlavicka(Cichnamon hracuvC, Cichnamon pocitacuvC)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("════════════════════════════════");
            Console.WriteLine($"  ⚔  SOUBOJ ZAČÍNÁ!");
            Console.WriteLine($"  {hrac.Jmeno} (Lv.{hrac.Level}) vs {pocitac.Jmeno}");
            Console.WriteLine("════════════════════════════════");
            Console.ResetColor();
            Console.WriteLine($"\n  Tvůj čichnamon:      {hracuvC.Jmeno}");
            Console.WriteLine($"  Protivníkův čichnamon: {pocitacuvC.Jmeno}");
            Console.WriteLine("\n  Stiskni Enter pro zahájení...");
            Console.ReadLine();
        }

        private void VypisStav(Cichnamon hracuvC, Cichnamon pocitacuvC)
        {
            Console.WriteLine("\n  ── Stav bojovníků ──");
            Console.Write($"  {hracuvC.Jmeno,-20} ");
            hracuvC.VypisZdravi();
            Console.Write($"  {pocitacuvC.Jmeno,-20} ");
            pocitacuvC.VypisZdravi();
        }

        private void VypisStavCichnamona(Cichnamon c)
        {
            Console.WriteLine();
            c.VypisInfo();
        }

        private int ZiskejVolbu(int min, int max)
        {
            while (true)
            {
                Console.Write("\n  Tvoje volba: ");
                string? vstup = Console.ReadLine();
                if (int.TryParse(vstup, out int volba) && volba >= min && volba <= max)
                    return volba;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"  Neplatná volba. Zadej číslo {min}–{max}.");
                Console.ResetColor();
            }
        }

        private void CekejNaEnter()
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("\n  [Stiskni Enter pro pokračování...]");
            Console.ResetColor();
            Console.ReadLine();
        }
    }
}
