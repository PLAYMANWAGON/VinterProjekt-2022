using System;

public class Arena
{
    public void EnterArena(Player player)
    {
        Enemy enemy = new Enemy();
        ErrorCode error = new ErrorCode();

        bool inArena = true;

        while (inArena == true)
        {
            Console.WriteLine("Welcome to the arena, your enemy of the day is " + enemy.GetName() + ".\nReady to fight? (y/n)");

            string input = Console.ReadLine();






            if (input == "y")
            {
                // Simpel kod där medans spelaren och fienden är vid liv så körs fighten
                // om oh om igen tills någon dör.

                while (!player.isDead && !enemy.isDead)
                {
                    Console.WriteLine("Press enter to partake in the battle.");
                    enemy.TakeDamage(player.GetPower());
                    Console.WriteLine("You deal " + player.GetPower() + " damage to " + enemy.GetName());

                    Console.ReadLine();

                    // Basically när fienden har över 0 hp så kan den attackera
                    // Annars är den garanterat död och har inget jäkla martyrdom perk
                    // som i cod.

                    if (enemy.GetHealth() > 0)
                    {

                        player.TakeDamage(enemy.GetPower());
                        Console.WriteLine("You take " + enemy.GetPower() + " damage from " + enemy.GetName());
                        Console.ReadLine();
                    }


                    if (player.GetHealth() <= 0)
                    {
                        player.isDead = true;
                        Console.WriteLine("You have died! " + enemy.GetName() + " has won the game!\n\n The game will now turn off because you're obviously dead and have no way to\ncome back to life!");
                        Console.ReadLine();
                        Environment.Exit(0);
                    }

                    if (enemy.GetHealth() <= 0)
                    {
                        enemy.isDead = true;
                        Console.WriteLine("You have killed " + enemy.GetName() + "! Congratulations, your spoils of the battle are now\nin your hands...");
                        Console.ReadLine();
                    }


                }

            }

            else if (input == "n" || input == "no")
            {
                Console.WriteLine("Alright, see you next time at the Arena!");
                inArena = false;
                Console.ReadLine();
                Console.Clear();



            }

            else
            {
                Console.WriteLine(error.GetError("001"));
                Console.ReadLine();

            }
        }

    }


}
