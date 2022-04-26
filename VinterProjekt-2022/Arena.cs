using System;

public class Arena
{
    public void EnterArena()
    {


        Enemy enemy = new Enemy();

        Random random = new Random();

        Console.WriteLine("Welcome to the arena, your enemy of the day is " + enemy.GetName() + ".\nReady to fight?");

        string input = Console.ReadLine();

        if (input == "y")
        {
            // SKRIV HELA SKITEN HÄR



        }
        else
        {
            Environment.Exit(0);
        }

    }


}
