namespace CichnamonArena
{
    class Utok
    {
        public string Nazev { get; private set; }
        public int Poskozeni { get; private set; }
        public string Popis { get; private set; }

        public Utok(string nazev, int poskozeni, string popis)
        {
            Nazev = nazev;
            Poskozeni = poskozeni;
            Popis = popis;
        }

        public int ZiskejPoskozeni()
        {
            return Poskozeni;
        }

        public void VypisInfo()
        {
            Console.WriteLine($"  ⚔  {Nazev} (poškození: {Poskozeni}) – {Popis}");
        }
    }
}
