using System;

public class Enemy : Player
{
    private int accuracy;

    private int chance;

    private int damageMultiplier; //Vill Impletera men orka


    // skapar ett lista med namn samt lägger in ett par i den. 

    private static List<string> nameList = new List<string>() { "Dabe", "Choblan", "Soupman", "Jonas", "Que Pro", "Dumpas", "EmojiMan", "Widell137", "Subscrib" };

    // Denna kodblock körs direkt när den här objektet skapas i Arenan
    // I princip, den tar längden på listan ovan och skapar en maxtal
    // till SetName om listan vore minskas eller förstoras i antal strings.

    public Enemy()
    {

        int nameMax = nameList.Count - 1;

        int nameNumber = random.Next(0, nameMax);

        SetName(nameList[nameNumber]);
    }

    public int GetAccuracy()
    {
        return accuracy;
    }

    public int GetChance()
    {
        return chance;
    }

    public void ResetStat()
    {
        accuracy = random.Next(0, 99);

        chance = random.Next(0, 99);

    }


}