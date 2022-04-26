using System;
public class Enemy : Fighter
{
    private float strikeChance = 1;

    private int damageMultiplier;
    Random generator = new Random(); //generatorn som ärvs från fighter vill inte funka så detta är min dumma lösning

    public static List<string> nameList = new List<string>() { "Dabe", "Choblan", "Soupman", "Jonas", "Que Pro", "Dumpas", "EmojiMan", "Widell", "Subscrib" };

    public void EnemyNameGenerator()
    {

        int nameMax = nameList.Count - 1;

        int nameNumber = generator.Next(0, nameMax);

        Enemy.SetName(nameList[nameNumber]);

    }


}