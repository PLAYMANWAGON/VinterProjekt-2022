using System;
public class Barracks
{
    private bool inBarracks = true;

    // Enemy enemy = new Enemy();
    // BossEnemy boss = new BossEnemy();
    Arena arena = new Arena();
    ErrorCode error = new ErrorCode();
    Random random = new Random();

    public void EnterBarracks(Player player)
    {
        int enemyGen = random.Next(2); // 0 = normal Enemy, 1 = boss enemy

        string input;

        while (inBarracks == true)
        {

            if (enemyGen == 0)
            {
                Enemy enemy = new Enemy();


                Console.WriteLine("Welcome to the arena, your enemy of the day is " + enemy.GetName() + ".\n\n1. Ready  2. Leave");

                input = Console.ReadLine().ToLower();

                if (input == "ready" || input == "r" || input == "1")
                {
                    arena.EnterArena(player, enemy);
                }

                else if (input == "leave" || input == "no" || input == "2")
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

            else
            {
                BossEnemy enemy = new BossEnemy();

                Console.WriteLine("Welcome to the arena, your enemy of the day is " + enemy.GetName() + ".\n\n1. Ready  2. Leave");
                input = Console.ReadLine();

                if (input == "ready" || input == "r" || input == "1")
                {
                    arena.EnterArena(player, enemy);
                }

                else if (input == "leave" || input == "no" || input == "2")
                {
                    Console.WriteLine("Alright, see you next time at the Arena!");
                    inBarracks = false;
                    Console.ReadLine();
                    Console.Clear();
                }


            }
        }
    }
}
