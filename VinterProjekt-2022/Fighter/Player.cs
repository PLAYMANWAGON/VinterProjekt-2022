public class Player : Fighter
{

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


}