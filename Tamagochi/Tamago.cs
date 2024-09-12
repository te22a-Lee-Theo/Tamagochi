using System.IO.Pipes;

public class Tamagochi
{
    private int Hunger;
    private int Boredom;
    private List<string> words = new List<string>() {"Hallo"};
    private bool isAlive = true;
    public string Name;


    public void Feed()
    {
        System.Console.WriteLine($"{Name} is being fed and becomes less hungry");
        Hunger -= Random.Shared.Next(2,5);
        if (Hunger < 0 )
        {
            Hunger = 0;
        }
    }

    public void Hi()
    {
        int wordnum = Random.Shared.Next(words.Count);
        System.Console.WriteLine($"[{Name}] says: {words[wordnum]}");
        ReduceBoredom();
    }

    public void Teach(string word)
    {
        Thread.Sleep(400);
        System.Console.WriteLine($"{Name} is learning a new word. Your Tama learned the word: {word}");
        words.Add(word);
        ReduceBoredom();
    }

    public void Tick()
    {
        Boredom ++;
        Hunger ++;

        if (Hunger > 10 || Boredom > 10)
        {
            isAlive = false;
        }
    }

    public void PrintStats()
    {
        System.Console.WriteLine($"Name: {Name} || Hunger: {Hunger} || Boredom: {Boredom} || Vocabulary: {words.Count}\n\n");
    }

    public bool GetAlive()
    {
        return isAlive;
    }

    private void ReduceBoredom()
    {
        System.Console.WriteLine("Your Tama becomes less bored");

        Boredom -= 2;
        if (Boredom < 0)
        {
            Boredom = 0;
        }
    }
}
