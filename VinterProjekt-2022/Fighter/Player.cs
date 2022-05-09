public class Player : Fighter
{

    public static List<string> inventory = new List<string>();


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

    public int Coins(int n)
    {
        int coins = random.Next(95, 101);
        coins = n;
        return n;

    }

    /* ett enkelt metod som används främst inom shoppen där ett ord (vilket i slutändan skulle ha ett
    dictionary för varje ord som exempelvis att cabbage ger 2 hp) läggs till i inventoryt */

    public void AddToInventory(string item)
    {
        inventory.Add(item);
    }


}