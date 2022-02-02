public class Fighter
{
    protected string name = "";
    protected int powerPoint;
    private int healthPoint = 100;
    private Random random = new Random();

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
