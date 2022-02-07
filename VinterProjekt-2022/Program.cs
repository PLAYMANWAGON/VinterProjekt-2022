Player player = new Player();

Console.WriteLine("Hello person, please enter a name for your FIGHTER!!!");

player.Name(Console.ReadLine());


Console.WriteLine($"Nice name, {player.getName()}!");

player.PowerCalc(player.getName().Length);

Console.WriteLine($"Our magicians back in Brampton have been\nhard at work and determined that you\nhave a power lever of {player.getPower()} points!");

Console.ReadLine();

