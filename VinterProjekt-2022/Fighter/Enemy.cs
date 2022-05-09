
using System;
public class Enemy : Fighter
{
    private float strikeChance = 1;

    private int damageMultiplier;

    // skapar ett lista med namn samt lägger in ett par i den. 

    public static List<string> nameList = new List<string>() { "Dabe", "Choblan", "Soupman", "Jonas", "Que Pro", "Dumpas", "EmojiMan", "Widell", "Subscrib" };

    // Denna kodblock körs direkt när den här objektet skapas i Arenan
    // I princip, den tar längden på listan ovan och skapar en maxtal
    // till SetName om listan vore minskas eller förstoras i antal strings.

    public Enemy()
    {

        int nameMax = nameList.Count - 1;

        int nameNumber = random.Next(0, nameMax);

        SetName(nameList[nameNumber]);

    }


}