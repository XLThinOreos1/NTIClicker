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
    public void Timer(float duration)
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
        if (number >= 1000000000000000000)
            return "Infinity";
        if (number >= 1000000000000000)
            return (number / 1000000000000000).ToString("0.##") + "Qd";
        if (number >= 1000000000000)
            return (number / 1000000000000).ToString("0.##") + "T";
        if (number >= 1000000000)
            return (number / 1000000000).ToString("0.##") + "B";
        if (number >= 1000000)
            return (number / 1000000).ToString("0.##") + "M";

        return number.ToString();
    }
}

// egil testa hitta en mer effektiv sätt
// List<string> suffix = ["asd", "burger", " Million", " Billion", " Trillion", " Quadrillion", " Quintillion", " Sextillion", " Septillion", " Octillion", " Nonillion", " Decillion", " Undecillion", " Duodecillion", "Infinity"];

// string val = number.ToString("G41");
// int suffixNum = (val.Length - 1) / 3;
// val = val[0..(val.Length - 3 * suffixNum)];
// if (suffixNum > 2)
// {
//     val = val + "." + number.ToString("G41")[val.Length..(val.Length + 2)];
// }
// string bigNum = val + suffix[suffixNum];

// return bigNum;