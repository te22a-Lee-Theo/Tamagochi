using System.IO.Pipes;

public class Tamagochi
{
    private int Hunger;
    private int Boredom;
    private List<string> words;
    private bool isAlive = true;
    public string Name;

    // public Tamagochi()
    // {
    //     isAlive = true;
    // }

    public void Feed()
    {}

    public void Hi()
    {}

    public void Teach(string words)
    {}

    public void Tick()
    {}

    public void PrintStats()
    {}

    public bool GetAlive()
    {
        return isAlive;
    }

    private void ReduceBoredom()
    {}
}
