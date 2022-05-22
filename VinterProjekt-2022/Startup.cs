using System;

public class Startup
{
    public void Setup()
    {

        Player player = new Player();
        ErrorCode error = new ErrorCode();
        Shop shop = new Shop();
        Arena arena = new Arena();
        Main main = new Main();

        bool isReady = false;

        while (isReady == false)
        {

            bool isEmpty = true;

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
                    isEmpty = false;
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
        main.Menu(player);
    }
}