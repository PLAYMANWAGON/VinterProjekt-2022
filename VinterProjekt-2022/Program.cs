Console.WriteLine("Hello, World!");

Fighter f1 = new Fighter();

f1.FighterName(Console.ReadLine());

Console.WriteLine($"The name is {f1.getName()}");

f1.powerCalc(f1.getName().Length);

Console.WriteLine(f1.getPower());

Console.ReadLine();

