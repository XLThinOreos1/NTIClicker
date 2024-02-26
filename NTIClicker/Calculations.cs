public class BuildingCostCalculator
{
    public static int ComputeCost(Building building)
    {
        return building.Price = (int)(building.BasePrice * Math.Pow(1.15, building.Amount));
    }
}

public class GameTimer
{
    public void OneSecondTimer()
    {
        if (Raylib.GetTime() % 1 < Raylib.GetFrameTime())
        {
            if (GameConstants.Matkort.Amount > 0)
            {
                GameConstants.MP += GameConstants.Matkort.MPS;
            }
            if (GameConstants.Teacher.Amount > 0)
            {
                GameConstants.MP += GameConstants.Teacher.MPS;
            }
        }
    }
}

public class MPSCalculator
{
    public static int TotalMPS;

    public static int UpdateMPS()
    {
        return TotalMPS = GameConstants.Matkort.MPS + GameConstants.Teacher.MPS;
    }
}