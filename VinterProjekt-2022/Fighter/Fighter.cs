public class Fighter
{
    protected string name = "";
    protected int hitPoint = 20;
    private int healthPoint = 100;
    protected Random random = new Random();

    public bool isDead = false;

    public int PowerCalc(int l)
    {
        l = l * random.Next(1, 4);

        hitPoint = l;

        return l;


    }

    public int GetHealth()
    {
        return healthPoint;
    }

    public int GetPower()
    {

        return hitPoint;
    }

    public string GetName()
    {
        return name;
    }

    public void SetName(string n)
    {
        name = n;

    }

    public int TakeDamage(int damage)
    {
        healthPoint -= damage;

        return damage;
    }



}
