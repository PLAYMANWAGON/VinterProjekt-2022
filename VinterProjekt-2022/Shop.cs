using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;
using System;
using System.Linq;
public class Shop
{

    public void EnterShop(Player player)
    {
        Random random = new Random();
        ErrorCode error = new ErrorCode();

        bool inShop = true;

        bool inTransaction = true;

        /* skapar tre olika listor så att man kan lättare kategorisera vad listan innehåller */

        List<string> shopFood = new List<string>() { "Bread", "Cheesewheel", "Cabbage", "Sweetroll", "Cabbage Stew" };

        shopFood = shopFood.ConvertAll(item => item.ToLower());

        List<string> shopPotion = new List<string>() { "Health Potion", "Stamina Potion", "Instant Death Potion" };

        shopPotion = shopPotion.ConvertAll(item => item.ToLower());

        List<string> shopWeapon = new List<string>() { "Little Sword", "Glass Sword", "Cherry Mace", "Devil's Dagger" };

        shopWeapon = shopWeapon.ConvertAll(item => item.ToLower());

        /* Denna while loop ser till att spelaren stannar kvar i affären efter den har interaggerat med något */

        while (inShop == true)
        {

            Console.WriteLine("Here's what's for sale today:\n\nFoodstuffs:");

            Thread.Sleep(500);

            // denna foreach används för att skriva ner varenda string från den listan som stringen befinner sig i

            foreach (string i in shopFood)
            {
                Console.Write(i + ", ");

            }

            Thread.Sleep(500);

            Console.WriteLine("\n\nPotions:");
            foreach (string i in shopPotion)
            {
                Console.Write(i + ", ");

            }

            Thread.Sleep(500);

            Console.WriteLine("\n\nWeapons:");
            foreach (string i in shopWeapon)
            {
                Console.Write(i + ", ");

            }

            Thread.Sleep(1000);

            Console.WriteLine("\n\nAnything on your mind? Type in the name of it! Type exit to exit.");

            //  denna kod här är ett relativt dum, men effektiv sätt att kolla igenom varje lista för det string som man söker.

            string userInput = Console.ReadLine();

            if (shopFood.Contains(userInput) || shopPotion.Contains(userInput) || shopWeapon.Contains(userInput))
            {

                // denna while loop används för att se till att om spelaren skriver in något fel så avbryts inte handeln
                // utan bara får veta att den skrev fel och får fortsätta köpa bröd eller något.

                while (inTransaction == true)
                {

                    Console.WriteLine("Would you like to buy '" + userInput + "'?\nPrice: " + userInput.Length + " (y/n)\n\n(jag orkar inte göra en coin system så allt är gratis)\n\n");

                    string isBuying = Console.ReadLine();





                    if (isBuying == "yes" || isBuying == "y")
                    {
                        // shopFood.RemoveAll(item => item.name == userInput); Detta var mitt initiella sätt att ta bort det man skriver ur varenda lista som existerar, men det funkade inte. Har den kvar för att visa mig själv hur jag skulle kunna göra ett liknande kod utan Linq

                        // Retorisk kod som tar bort pengar från spelaren om han har råd. Orkar skriva den.

                        player.AddToInventory(userInput);

                        Thread.Sleep(500);

                        Console.WriteLine("Great doing business with you! " + userInput + " has been added to your inventory.");

                        inTransaction = false;

                        Console.ReadLine();
                    }
                    else if (isBuying == "no" || isBuying == "n")
                    {

                        Console.WriteLine("Alright then. Anything else on this list might interest you?");
                        inTransaction = false;
                        Console.ReadLine();

                    }
                    else
                    {
                        Console.WriteLine(error.GetError("001"));
                        Console.ReadLine();

                    }
                }
            }

            else
            {
                Console.WriteLine("Sorry bub, I don't sell this " + userInput + " you speak of...");

            }

            if (userInput == "exit")
            {
                inShop = false;
            }
        }
    }
}