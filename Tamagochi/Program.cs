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
}




Console.ReadLine();