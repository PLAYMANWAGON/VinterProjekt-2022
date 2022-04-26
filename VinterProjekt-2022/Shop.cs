using System.Threading;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;
using System;
using System.Linq;
public class Shop
{

    public void EnterShop()
    {

        Player player = new Player();

        Random random = new Random();

        bool inShop = true;

        List<string> shopFood = new List<string>() { "Bread", "Cheesewheel", "Cabbage", "Sweetroll", "Cabbage Stew" };

        shopFood = shopFood.ConvertAll(item => item.ToLower());

        List<string> shopPotion = new List<string>() { "Health Potion", "Stamina Potion", "Instant Death Potion" };

        shopPotion = shopPotion.ConvertAll(item => item.ToLower());

        List<string> shopWeapon = new List<string>() { "Little Sword", "Glass Sword", "Cherry Mace", "Devil's Dagger" };

        shopWeapon = shopWeapon.ConvertAll(item => item.ToLower());

        while (inShop == true)
        {

            Console.WriteLine("Here's what's for sale today:\n\nFood:");

            Thread.Sleep(500);

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

            Console.WriteLine("\n\nFoodstuffs:");
            foreach (string i in shopFood)
            {
                Console.Write(i + ", ");

            }

            Thread.Sleep(1000);

            Console.WriteLine("\n\nAnything on your mind? Type in the name of it! Type exit to exit.");

            string userInput = Console.ReadLine();
            if (shopFood.Contains(userInput) || shopPotion.Contains(userInput) || shopWeapon.Contains(userInput))
            {
                Console.WriteLine("Would you like to buy '" + userInput + "'?\nPrice: " + userInput.Length + "\n\n(jag orkar inte göra en coin system så allt är gratis)\n\n");

                string isBuying = Console.ReadLine();

                if (isBuying == "yes")
                {
                    // shopFood.RemoveAll(item => item.name == userInput);

                    // Retorisk kod som tar bort pengar från spelaren om han har råd. Orkar skriva den.

                    player.AddToInventory(userInput);

                    Thread.Sleep(500);

                    Console.WriteLine("Grat doing business with you! " + userInput + " has been added to your inventory.");

                    Console.ReadLine();
                }
            }
            else
            {
                Console.WriteLine("Sorry bub, I don't sell this " + userInput + " you speak of...");

            }
        }
    }
}