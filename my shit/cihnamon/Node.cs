class Node
{ 
    double[] inputs;
    double[] outputs;

    public Node (Cichnamon a, Cichnamon b)
    {
        this.inputs = [a.CurrentHealth / a.MaxHealth,  b.CurrentHealth / b.MaxHealth];
        this.outputs = [0, 0, 0];
    }

    public double[] DoStuff()
    {

    }
}