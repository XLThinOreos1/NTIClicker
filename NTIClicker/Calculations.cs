public class computeBuildingCost : GameStats
{
    public void computeMatkortCost()
    {
        MatkortPrice = (int)(15 * Math.Pow(1.15, MatkortAmount));
    }

    public void computeTeacherCost()
    {
        TeacherPrice = (int)(15 * Math.Pow(1.15, TeacherAmount));
    }
}

public class GameTimer : GameStats
{
    public void OneSecondTimer()
    {
        if (Raylib.GetTime() % 1 < Raylib.GetFrameTime())
        {
            if (MatkortAmount > 1)
            {
                MP += MatkortMPS;
                Console.WriteLine($"{MP}");
            }
            if (TeacherAmount > 0)
            {
                MP += TeacherMPS;
                Console.WriteLine($"{MP}");
            }
        }
    }
}