public class BuildingCalculators
{
    static GameAudio audio = new();

    public static long ComputeCost(Building building)
    {
        return building.Price = (long)(building.BasePrice * Math.Pow(1.15, building.Amount));
    }

    public static void BuyBuilding(Building building)
    {
        building.Amount++;
        building.MPS += building.BaseMPS;
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
            if (GameConstants.Matkort.Amount > 0)
            {
                GameConstants.MP += GameConstants.Matkort.MPS;
            }
            if (GameConstants.Teacher.Amount > 0)
            {
                GameConstants.MP += GameConstants.Teacher.MPS;
            }
            if (GameConstants.Matsal.Amount > 0)
            {
                GameConstants.MP += GameConstants.Matsal.MPS;
            }
            if (GameConstants.Pendeltag.Amount > 0)
            {
                GameConstants.MP += GameConstants.Pendeltag.MPS;
            }
            if (GameConstants.Laptop.Amount > 0)
            {
                GameConstants.MP += GameConstants.Laptop.MPS;
            }
            if (GameConstants.Rektor.Amount > 0)
            {
                GameConstants.MP += GameConstants.Rektor.MPS;
            }
        }
    }
}

public class MPSCalculator
{
    public static int TotalMPS;

    public static int UpdateMPS()
    {
        return TotalMPS = GameConstants.Matkort.MPS + GameConstants.Teacher.MPS +
                            GameConstants.Matsal.MPS + GameConstants.Pendeltag.MPS +
                                GameConstants.Laptop.MPS + GameConstants.Rektor.MPS;
    }
}

public static class NumberFormatter
{
    public static string ShortenNumber(long number)
    {
        if (number >= 1000000000000)
            return (number / 1000000000000D).ToString("0.##") + "T";
        if (number >= 1000000000)
            return (number / 1000000000D).ToString("0.##") + "B";
        if (number >= 1000000)
            return (number / 1000000D).ToString("0.##") + "M";

        return number.ToString();
    }
}