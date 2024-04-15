public class BuildingCalculators
{
    static GameAudio audio = new();

    public static ulong ComputeCost(Building building)
    {
        return building.Price = (ulong)(building.BasePrice * Math.Pow(1.15, building.Amount));
    }

    public static void BuyBuilding(Building building)
    {
        building.Amount++;
        GameConstants.MP -= building.Price;

        ComputeCost(building);

        Raylib.PlaySound(audio.buyBuilding);
    }
}


public class GameTimer
{
    public static void Timer(float duration)
    {
        if (Raylib.GetTime() % duration < Raylib.GetFrameTime())
        {
            GameConstants.MP += MPSCalculator.TotalMPS;
        }
    }
}

public class MPSCalculator
{
    public static ulong TotalMPS;

    public static void UpdateMPS()
    {
        ulong AmountThatMPSShouldIncreaseWith = 0;
        foreach (Building b in GameConstants.buildings)
        {
            AmountThatMPSShouldIncreaseWith += b.BaseMPS * b.Amount;
        }
        TotalMPS = AmountThatMPSShouldIncreaseWith;
    }
}

public class NumberFormatter
{
    public static string ShortenNumber(ulong number)
    {
        if (number >= 1000000000000000000F)
            return "a lot of";
        if (number >= 1000000000000000F)
            return (number / 1000000000000000F).ToString("0.##") + "Qd";
        if (number >= 1000000000000F)
            return (number / 1000000000000F).ToString("0.##") + "T";
        if (number >= 1000000000F)
            return (number / 1000000000F).ToString("0.##") + "B";
        if (number >= 1000000F)
            return (number / 1000000F).ToString("0.##") + "M";

        return number.ToString();
    }
}