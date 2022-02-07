public class Fighter
{
    protected string name = "";
    protected int hitPoint;
    private int healthPoint = 100;
    private Random random = new Random();

    public int PowerCalc(int l)
    {
        l = l * random.Next(1, 4);

        hitPoint = l;

        return l;


    }

    public int getPower()
    {

        return hitPoint;
    }

    public string getName()
    {
        return name;
    }


}
