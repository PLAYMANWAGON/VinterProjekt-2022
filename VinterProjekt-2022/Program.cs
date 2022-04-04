using System.Globalization;
using System.Net.Mime;
using System.Xml;
using System.Runtime.CompilerServices;
Player player = new Player();
ErrorCode error = new ErrorCode();

bool isReady = false;


bool isEmpty = true;

while (isReady == false)
{

    while (isEmpty == true)
    {
        Console.WriteLine("Hello person, please enter a name for your FIGHTER!!!");

        string value = Console.ReadLine();

        if (String.IsNullOrEmpty(value))
        {
            Console.WriteLine(error.GetError("002"));
            Console.ReadLine();
        }
        else
        {
            player.Name(value);
            isEmpty = false;
        }


    }

    isEmpty = true;



    Console.WriteLine($"Nice name, {player.getName()}!\n");

    player.PowerCalc(player.getName().Length);

    string input;

    while (isEmpty == true)
    {

        Console.WriteLine($"Our magicians back in Brampton have been hard at work and\nhave determined that you have a power lever of {player.getPower()} points!\n\nYou ready to go? (y/n)\n");

        input = Console.ReadLine();
        if (String.IsNullOrEmpty(input))
        {
            Console.WriteLine(error.GetError("002"));
            Console.ReadLine();
        }
        else
        {
            isEmpty = false;
        }




        if (input.ToLower() == "y" || input.ToLower() == "yes")
        {
            isReady = true;
            Console.Clear();
        }

        else if (input.ToLower() == "n" || input.ToLower() == "no")
        {
            isReady = false;
            Console.Clear();
        }
        else
        {

            Console.WriteLine(error.GetError("001"));
            Console.ReadLine();
            Console.Clear();

        }
    }

}

isEmpty = true;

string a = Console.ReadLine().ToLower();

while (isEmpty == true)
{
    Console.WriteLine("Here's what you can do:\n1. Fight    2. Shop     3. Retire");

    string value = Console.ReadLine();

    if (String.IsNullOrEmpty(value))
    {
        Console.WriteLine(error.GetError("002"));
        Console.ReadLine();
    }

    else if (a == "fight" || a == "1")
    {
        // LÄGG TILL SKIT HÄR SOM LEDER SPELAREN TILL "ARENAN"
    }

    else if (a == "shop" || a == "2")
    {

    }

    else if (a == "retire" || a == "3")
    {
        Environment.Exit(0);
    }
    else
    {
        Console.WriteLine(error.GetError("003"));
        Thread.Sleep(3000);
    }
}

Console.ReadLine();