using System;

public class Arena
{
    private bool inArena = false;

    public void EnterArena(Player player, Enemy enemy)
    {
        ErrorCode error = new ErrorCode();
        Barracks barracks = new Barracks();

        inArena = true;

        while (inArena == true)
        {
            Console.WriteLine("Press enter to partake in the battle.");
            // Simpel kod där medans spelaren och fienden är vid liv så körs fighten
            // om och om igen tills någon dör.

            while (!player.GetIsDead() && !enemy.GetIsDead())
            {
                enemy.TakeDamage(player.GetPower());
                Console.WriteLine("You deal " + player.GetPower() + " damage to " + enemy.GetName());

                Console.ReadLine();

                // Basically när fienden har över 0 hp så kan den attackera
                // Annars är den garanterat död och har inget jäkla martyrdom perk
                // som i cod.

                if (enemy.GetHealth() > 0)
                {

                    enemy.ResetStat();

                    if (enemy.GetAccuracy() >= enemy.GetChance())
                    {
                        player.TakeDamage(enemy.GetPower());
                        Console.WriteLine("You take " + enemy.GetPower() + " damage from " + enemy.GetName() + " with an accuracy of " + enemy.GetAccuracy() + "\n----------------------------------------");
                        Console.ReadLine();

                    }
                    else
                    {
                        System.Console.WriteLine("The enemy missed lmao\n----------------------------------------");
                    }
                }


                if (player.GetHealth() <= 0)
                {
                    player.SetIsDead(true);
                    Console.WriteLine("You have died! " + enemy.GetName() + " has won the game!\n\n The game will now turn off because you're obviously dead and have no way to\ncome back to life!");
                    Console.ReadLine();
                    Environment.Exit(0);
                }

                if (enemy.GetHealth() <= 0)
                {
                    enemy.SetIsDead(true);
                    inArena = false;
                    Console.WriteLine("You have killed " + enemy.GetName() + "! Congratulations, your spoils of the battle are now\nin your hands...");
                    Console.ReadLine();
                    Console.Clear();
                    barracks.EnterBarracks(player);

                }
            }
        }
    }
}
