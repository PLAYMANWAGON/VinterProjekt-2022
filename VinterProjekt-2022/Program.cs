using System.Globalization;
using System.Net.Mime;
using System.Xml;
using System.Runtime.CompilerServices;
Player player = new Player();
ErrorCode error = new ErrorCode();
Shop shop = new Shop();
Arena arena = new Arena();

bool isReady = false;


bool isEmpty = true;

while (isReady == false)
{


    // Denna while gör att om input är tom så får man inte fortsätta förrän man 
    // har skrivit något vilket i det här fallet är namnet. 
    // Om spelaren vore inte skriva något aktiveras error.GetError vilket
    // innehåller olika errorcodes.

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



    Console.WriteLine($"Nice name, {player.GetName()}!\n");

    player.PowerCalc(player.GetName().Length);

    string input;

    // Denna kod bekräftar om spelaren vill fortsätta med sitt namn/powerpoint
    // eller börja om för att byta namn eller fuska sig fram mer powerpoints

    while (isEmpty == true)
    {

        Console.WriteLine($"Our magicians back in Brampton have been hard at work and\nhave determined that you have a power lever of {player.GetPower()} points!\n\nYou ready to go? (y/n)\n");

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

// Koden här nere skapar ett meny där spelaren får välja mellan tre olika scener
// Man tar sig till två av tre (tredje är en quit program funktion) scener genom
// ett simpellt kod som kallar till ett metod i en klass. Där körs resten av det
// kod som har något sammanhängande med klassen.

while (isEmpty == true)
{
    Console.WriteLine("Here's what you can do:\n1. Fight    2. Shop     3. Retire");

    string a = Console.ReadLine().ToLower();

    if (String.IsNullOrEmpty(a))
    {
        Console.WriteLine(error.GetError("002"));
        Console.ReadLine();
    }

    else if (a == "fight" || a == "1")
    {
        arena.EnterArena(player);
    }

    else if (a == "shop" || a == "2")
    {

        shop.EnterShop();

    }

    else if (a == "retire" || a == "3")
    {
        Environment.Exit(0);
    }
    else
    {
        // I denna else är det egentligen smartare att ha andra errorcodes istället för att ha en "något okänt hände, nu stängs allt ner". 
        // Egentligen ville jag bara ha den för att testa den samt visa att jag kan använda mig av alla instanser av strings. 

        // Här kan jag egentligen bara ha en vanlig error code men ville bara testa 
        // ett nytt sätt att stänga ner grejen. 
        Console.WriteLine(error.GetError("003"));
        Thread.Sleep(3000);
        Environment.Exit(0);
    }
}

Console.ReadLine();