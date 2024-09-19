using System.Runtime.InteropServices.Marshalling;

System.Console.WriteLine("Welcome to Tamagochi");
System.Console.WriteLine("Name your new Tamagochi");

Tamagochi Tama = new Tamagochi();
Tama.Name = Console.ReadLine();
while(string.IsNullOrEmpty(Tama.Name))
{
    System.Console.WriteLine("Please give me a name");
    Tama.Name = Console.ReadLine();
}

System.Console.WriteLine($"Wow, {Tama.Name} is a great name");

while(Tama.GetAlive() == true)
{
    Console.Clear();
    Tama.PrintStats();
    System.Console.WriteLine("What do you want to do?\n");
    System.Console.WriteLine($"1. Teach {Tama.Name} a new word.");
    System.Console.WriteLine($"2. Talk to {Tama.Name}.");
    System.Console.WriteLine($"3. Feed {Tama.Name}.");
    System.Console.WriteLine($"4. Do nothing :(");
    System.Console.WriteLine($"5. Play a game with {Tama.Name}.");

    string action = Console.ReadLine();

    if (action == "1")
    {
        System.Console.WriteLine("Which word do you want to teach me?");
        string word = Console.ReadLine();
        while (string.IsNullOrEmpty(word))
        {
            System.Console.WriteLine("Don't you wnat to teach me a new word :(");
            word = Console.ReadLine();
        }
        Tama.Teach(word);
    }

    if (action == "2")
    {
        Tama.Hi();
    }

    if (action == "3")
    {
        Tama.Feed();
    }

    if (action == "4" || string.IsNullOrEmpty(action))
    {
        System.Console.WriteLine("Not doing anything :(");
    }

    if (action == "5")
    {
        System.Console.WriteLine("Let's play a game of Rock, Paper, Scissors");
        Tama.Play();
    }





    Tama.Tick();
    Thread.Sleep(400);
    System.Console.WriteLine("\nPress enter to continue");
    Console.ReadLine();
}

System.Console.WriteLine($"OH NO, {Tama.Name} died");
System.Console.WriteLine("Press Enter to quit the game");


Console.ReadLine();