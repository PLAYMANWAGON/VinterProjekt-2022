using System.Xml;
using System.Runtime.CompilerServices;
Player player = new Player();

bool isReady = false;

while (isReady == false)
{

    Console.WriteLine("Hello person, please enter a name for your FIGHTER!!!");

    player.Name(Console.ReadLine());

    Console.WriteLine($"Nice name, {player.getName()}!\n");

    player.PowerCalc(player.getName().Length);

    Console.WriteLine($"Our magicians back in Brampton have been hard at work and\nhave determined that you have a power lever of {player.getPower()} points!\n\nYou ready to go? (y/n)\n");

    string input = Console.ReadLine();


    if (input.ToLower() == "y" || input.ToLower() == "yes")
    {
        isReady = true;
    }

    else if (input.ToLower() == "n" || input.ToLower() == "no")
    {
        isReady = false;
    }
    else
    {
        Console.WriteLine("You'z trynna be funny? Start over...");
    }

}

Console.WriteLine("\nOKAY LETS GO21");

Console.ReadLine();

