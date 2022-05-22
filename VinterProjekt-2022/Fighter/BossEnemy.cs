using System;

public class BossEnemy : Enemy
{

    private static List<string> nameList = new List<string>() { "Fortnite", "Razer Keyboard", "idk", "Chilli Con Carne" };

    public BossEnemy()
    {
        int nameMax = nameList.Count - 1;

        int nameNumber = random.Next(0, nameMax);

        SetName(nameList[nameNumber]);

        damageMultiplier = (winAmount / 2 + 1);

        hitPoint = (int)((hitPoint * damageMultiplier));

    }
}
