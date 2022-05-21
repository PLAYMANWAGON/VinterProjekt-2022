public class Fighter
{
    protected string name = "";

    protected int hitPoint = 20;
    private int healthPoint = 100;
    protected int coin = 50;

    protected Random random = new Random();

    private bool isDead = false;

    public bool GetIsDead()
    {
        return isDead;
    }

    public bool SetIsDead(bool b)
    {
        isDead = b;
        return b;

    }

    /* enkel kod som dumt beräknar spelarens hitpoints genom att 
    ta längden av spelarens namn och gångra det med ett slumpat tal
    mellan 1 och 4. */

    public int PowerCalc(int l)
    {
        l = l * random.Next(1, 4);

        hitPoint = l;

        return l;


    }


    /* basically allt här under är en hel del olika get metoder
    för att hämta in värdet från olika variabler */


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

    // ett metod som tar in ett variabel, damage, och sedan sänker healthpoint
    // med antal damage. Detta funkar i två led genom att det funkar både
    // både spelaren och fienden. 

    public int TakeDamage(int damage)
    {
        healthPoint -= damage;

        return damage;
    }



}
