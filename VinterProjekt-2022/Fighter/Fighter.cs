public class Fighter
{
    protected string name = "";
    protected int hitPoint;
    private int healthPoint = 100;
    protected Random random = new Random();

    public int PowerCalc(int l)
    {
        l = l * random.Next(1, 4);

        hitPoint = l;

        return l;


    }

    public int GetPower()
    {

        return hitPoint;
    }

    public string GetName()
    {
        return name;
    }

    public string SetName(string n)
    {
        n = name;

        return n;

    }



}
