namespace CichnamonArena
{
    class Trener
    {
        public string Jmeno { get; private set; }
        public int Level { get; private set; }
        public List<Cichnamon> Cichnamoni { get; private set; }
        public Cichnamon? AktualniCichnamon { get; private set; }

        public Trener(string jmeno)
        {
            Jmeno = jmeno;
            Level = 1;
            Cichnamoni = new List<Cichnamon>();
        }

        public void PridejCichnamona(Cichnamon cichnamon)
        {
            Cichnamoni.Add(cichnamon);
        }

        public void VyberCichnamona(int index)
        {
            if (index >= 0 && index < Cichnamoni.Count)
                AktualniCichnamon = Cichnamoni[index];
        }

        public void VyberNahodneho(Random rnd)
        {
            int index = rnd.Next(Cichnamoni.Count);
            AktualniCichnamon = Cichnamoni[index];
        }

        public void ZvysLevel()
        {
            Level++;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\n  🎉 {Jmeno} postoupil na level {Level}!");
            Console.ResetColor();
        }

        public bool MaCichnamony()
        {
            return Cichnamoni.Any(c => c.JeNazivu());
        }

        public void OdebratPorazeného()
        {
            if (AktualniCichnamon != null && !AktualniCichnamon.JeNazivu())
            {
                Cichnamoni.Remove(AktualniCichnamon);
                AktualniCichnamon = null;
            }
        }
    }
}
