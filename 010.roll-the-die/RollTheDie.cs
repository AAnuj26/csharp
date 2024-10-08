using System;

public class Player
{
    public int RollDie()
    {
        Random random = new Random();
        return random.Next(1, 7);
    }

    public double GenerateSpellStrength()
    {
        Random random = new Random();
        return random.NextDouble() * 100;
    }
}
