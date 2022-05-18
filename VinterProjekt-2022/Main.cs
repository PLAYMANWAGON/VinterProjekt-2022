using System;

public class Main
{

    public void Menu()
    {


        Player player = new Player();
        ErrorCode error = new ErrorCode();
        Shop shop = new Shop();
        Arena arena = new Arena();

        bool isEmpty = true;

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

                shop.EnterShop(player);

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
    }
}

