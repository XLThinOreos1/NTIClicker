public class LoadTexture
{
    public static Texture2D Background = Raylib.LoadTexture("textures/background.png");
    public static Texture2D NTILogo = Raylib.LoadTexture("textures/NTI.png");
    public static Rectangle NTIrect = new(1280 / 8 - 50, 720 / 2 - 25, NTILogo.Width, NTILogo.Height);

    public static Texture2D MatkortBuilding = Raylib.LoadTexture("textures/matkort.png");
    public static Rectangle MatkortRect = new(1010, 10, MatkortBuilding.Width, MatkortBuilding.Height);

    public static Texture2D TeacherBuilding = Raylib.LoadTexture("textures/teacher.png");
    public static Rectangle TeacherRect = new(1010, 80, TeacherBuilding.Width, TeacherBuilding.Height);
}

public class MPDisplay : GameStats, IDrawable
{
    public void Draw()
    {
        Raylib.DrawText($"{MP} Meritpoäng", (int)LoadTexture.NTIrect.X - 15, (int)LoadTexture.NTIrect.Y - 50, 30, Color.Black);
        Raylib.DrawText($"{MP} Meritpoäng", (int)LoadTexture.NTIrect.X - 15, (int)LoadTexture.NTIrect.Y - 49, 30, Color.Black);
        Raylib.DrawText($"{MP} Meritpoäng", (int)LoadTexture.NTIrect.X - 15, (int)LoadTexture.NTIrect.Y - 48, 30, Color.Black);
        Raylib.DrawText($"{MP} Meritpoäng", (int)LoadTexture.NTIrect.X - 15, (int)LoadTexture.NTIrect.Y - 51, 30, Color.White);
    }
}

public class BlueBG : IDrawable
{
    public void Draw()
    {
        // Draw BG
        Raylib.DrawTexture(LoadTexture.Background, 0, 0, Color.White);
    }
}

public class NTITexture : IDrawable
{
    public void Draw()
    {
        // NTI Logo
        Raylib.DrawRectangleRec(LoadTexture.NTIrect, Color.White);
        Raylib.DrawTexture(LoadTexture.NTILogo, (int)LoadTexture.NTIrect.X, (int)LoadTexture.NTIrect.Y, Color.White);
    }
}

public class Matkort : IDrawable
{
    public void Draw()
    {
        // Draw Matkort
        Raylib.DrawRectangleRec(LoadTexture.MatkortRect, Color.White);
        Raylib.DrawTexture(LoadTexture.MatkortBuilding, (int)LoadTexture.MatkortRect.X, (int)LoadTexture.MatkortRect.Y, Color.White);
    }
}

public class Teacher : IDrawable
{
    public void Draw()
    {
        // Draw Teacher
        Raylib.DrawRectangleRec(LoadTexture.TeacherRect, Color.White);
        Raylib.DrawTexture(LoadTexture.TeacherBuilding, (int)LoadTexture.TeacherRect.X, (int)LoadTexture.TeacherRect.Y, Color.White);
    }
}

