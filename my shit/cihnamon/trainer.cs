
public class Trainer
{
    public string Name { get; set; }
    public int Level { get; set; }
    public List<Cichnamon> Cichnamons { get; set; }
    public Cichnamon ActiveCichnamon { get; set; }

    public Trainer(string name)
    {
        Name = name;
        Level = 1;
        Cichnamons = new List<Cichnamon>();
    }

    public void ChooseActiveCichnamon(int index)
    {
        if (index >= 0 && index < Cichnamons.Count)
        {
            ActiveCichnamon = Cichnamons[index];
        }
    }

    public void turn()
    {

    }

    public void AddCichnamon(Cichnamon cichnamon)
    {
        Cichnamons.Add(cichnamon);
    }

    public bool HasAliveCichnamons()
    {
        return Cichnamons.Any(c => c.IsAlive());
    }
}