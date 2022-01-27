public class Fighter
{
    private string name = "";
    private int powerPoint;
    private int healthPoint = 100;
    private Random random = new Random();

    public string FighterName(string n)
    {
        name = n;
        return n;

    }

    public int powerCalc(int l)
    {
        l = l * random.Next(1, 4);

        powerPoint = l;

        return l;


    }

    public int getPower()
    {

        return powerPoint;
    }

    public string getName()
    {
        return name;
    }


}
