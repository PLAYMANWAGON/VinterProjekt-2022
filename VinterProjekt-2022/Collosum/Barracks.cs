using System;
public class Barracks
{
    private bool inBarracks = true;

    Enemy enemy = new Enemy();
    Arena arena = new Arena();
    ErrorCode error = new ErrorCode();

    public void EnterBarracks(Player player)
    {

        while (inBarracks == true)
        {
            Console.WriteLine("Welcome to the arena, your enemy of the day is " + enemy.GetName() + ".\n\n1. Ready  2. Leave");

            string input = Console.ReadLine().ToLower();

            if (input == "ready" || input == "r")
            {
                arena.EnterArena(player, enemy);
            }

            else if (input == "leave" || input == "no")
            {
                Console.WriteLine("Alright, see you next time at the Arena!");
                inBarracks = false;
                Console.ReadLine();
                Console.Clear();
            }

            else
            {
                Console.WriteLine(error.GetError("004"));
            }
        }
    }
}
