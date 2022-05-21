public class Player : Fighter
{

    private static List<string> inventory = new List<string>() { "TestItem", "TestItem2", "TestItem3" };

    private int winAmount = 0;


    /* kod som ser till att spelarens namn har minst ett bokstav för att kunna
    kategoriseras som ett namn enligt mig*/

    public string Name(string n)
    {
        int x;
        while (Int32.TryParse(n, out x))
        {
            Console.WriteLine("Enter a NAME, not a number...\n");

            n = Console.ReadLine();
        }

        name = n;
        return n;

    }

    /* simpel kod som slumpar ett antal kronor som spelaren får ha. */

    public int CoinGenerator(int n)
    {
        coin = random.Next(95, 101);
        coin = n;
        return n;

    }

    public int GetCoin()
    {
        return coin;
    }

    /* ett enkelt metod som används främst inom shoppen där ett ord (vilket i slutändan skulle ha ett
    dictionary för varje ord som exempelvis att cabbage ger 2 hp) läggs till i inventoryt */

    public void AddToInventory(string item)
    {
        inventory.Add(item);
    }

    public void GetInventory()
    {
        Console.WriteLine("Here's what's in your backpack:\n");

        foreach (var item in inventory)
        {
            Console.WriteLine(item + ",");

        }

        Console.WriteLine();

    }

    public void WinAmount()
    {
        Console.WriteLine(winAmount);
    }

    public void SetWinAmount()
    {
        winAmount++;
    }


}