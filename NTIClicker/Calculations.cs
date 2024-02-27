
public class BuildingCalculators
{
    static GameAudio audio = new();

    public static int ComputeCost(Building building)
    {
        return building.Price = (int)(building.BasePrice * Math.Pow(1.15, building.Amount));
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
            if (GameConstants.Matsal.Amount > 0)
            {
                GameConstants.MP += GameConstants.Matsal.MPS;
            }
            if (GameConstants.Pendeltag.Amount > 0)
            {
                GameConstants.MP += GameConstants.Pendeltag.MPS;
            }
        }
    }
}

public class MPSCalculator
{
    public static int TotalMPS;

    public static int UpdateMPS()
    {
        return TotalMPS = GameConstants.Matkort.MPS + GameConstants.Teacher.MPS + GameConstants.Matsal.MPS + GameConstants.Pendeltag.MPS;
    }
}

// public class DrawTextClass
// {
//     public static void DrawBuilding(Building building)
//     {
//         Raylib.DrawText($"{building.Price} MP", (int)LoadTexture.TeacherRect.X + 75, (int)LoadTexture.TeacherRect.Y + 34, 20, Color.Black);
//         Raylib.DrawText($"{building.Price} MP", (int)LoadTexture.TeacherRect.X + 75, (int)LoadTexture.TeacherRect.Y + 33, 20, Color.Black);
//         Raylib.DrawText($"{building.Price} MP", (int)LoadTexture.TeacherRect.X + 75, (int)LoadTexture.TeacherRect.Y + 32, 20, Color.White);

//         Raylib.DrawText($"{building.Amount}", (int)LoadTexture.TeacherRect.X + 200, (int)LoadTexture.TeacherRect.Y + 12, 50, Color.Black);
//         Raylib.DrawText($"{building.Amount}", (int)LoadTexture.TeacherRect.X + 200, (int)LoadTexture.TeacherRect.Y + 11, 50, Color.Black);
//         Raylib.DrawText($"{building.Amount}", (int)LoadTexture.TeacherRect.X + 200, (int)LoadTexture.TeacherRect.Y + 10, 50, Color.White);
//     }
// }