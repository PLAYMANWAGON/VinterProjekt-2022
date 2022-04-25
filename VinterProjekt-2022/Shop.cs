using System.Threading;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;
using System;
public class Shop
{



    public void EnterShop()
    {

        Random random = new Random();

        List<string> shopFood = new List<string>() { "Bread", "Cheesewheel", "Cabbage", "Sweetroll", "Cabbage Stew" };

        List<string> shopPotion = new List<string>() { "Health Potion", "Stamina Potion", "Instant Death Potion" };

        List<string> shopWeapon = new List<string>() { "Little Sword", "Glass Sword", "Cherry Mace", "Devil's Dagger" };



        Console.WriteLine("Here's what's for sale today:\n\nFood:");

        foreach (string i in shopFood)
        {
            Console.Write(i + ", ");

        }
        Console.WriteLine("\n\nPotions:");
        foreach (string i in shopPotion)
        {
            Console.Write(i + ", ");

        }
        Console.WriteLine("\n\nFoodstuffs:");
        foreach (string i in shopFood)
        {
            Console.Write(i + ", ");

        }

        Thread.Sleep(1000);

        Console.WriteLine("\n\nAnything on your mind? Type in the name of it!");

        string userInput = Console.ReadLine();
        if (shopFood.Contains(userInput) || shopPotion.Contains(userInput) || shopWeapon.Contains(userInput))
        {
            Console.WriteLine("Would you like to buy '" + userInput + "'?\nPrice: " + userInput.Length);


        }
    }

}