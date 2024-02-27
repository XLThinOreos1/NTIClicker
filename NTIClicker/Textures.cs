public class LoadTexture
{
    public static Texture2D Background = Raylib.LoadTexture("textures/background.png");

    public static Texture2D NTILogo = Raylib.LoadTexture("textures/NTI.png");
    public static Rectangle NTIrect = new(1280 / 8 - 50, 720 / 3 - 25, NTILogo.Width, NTILogo.Height);

    public static Texture2D MatkortBuilding = Raylib.LoadTexture("textures/matkort.png");
    public static Rectangle MatkortRect = new(1010, 10, MatkortBuilding.Width, MatkortBuilding.Height);

    public static Texture2D TeacherBuilding = Raylib.LoadTexture("textures/teacher.png");
    public static Rectangle TeacherRect = new(1010, 80, TeacherBuilding.Width, TeacherBuilding.Height);

    public static Texture2D MatsalBuilding = Raylib.LoadTexture("textures/matsal.png");
    public static Rectangle MatsalRect = new(1010, 150, MatsalBuilding.Width, MatsalBuilding.Height);

    public static Texture2D PendeltagBuilding = Raylib.LoadTexture("textures/pendeltag.png");
    public static Rectangle PendeltagRect = new(1010, 220, PendeltagBuilding.Width, PendeltagBuilding.Height);
}

public class MPDisplay : IDrawable
{
    public void Draw()
    {
        // Text shadow (makes it look nicer)
        Raylib.DrawText($"{GameConstants.MP} Meritpoäng", (int)LoadTexture.NTIrect.X - 15, (int)LoadTexture.NTIrect.Y - 60, 30, Color.Black);
        Raylib.DrawText($"{GameConstants.MP} Meritpoäng", (int)LoadTexture.NTIrect.X - 15, (int)LoadTexture.NTIrect.Y - 59, 30, Color.Black);
        Raylib.DrawText($"{GameConstants.MP} Meritpoäng", (int)LoadTexture.NTIrect.X - 15, (int)LoadTexture.NTIrect.Y - 58, 30, Color.Black);

        // Main text
        Raylib.DrawText($"{GameConstants.MP} Meritpoäng", (int)LoadTexture.NTIrect.X - 15, (int)LoadTexture.NTIrect.Y - 61, 30, Color.White);
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

public class Matkort : GameConstants, IDrawable
{
    public void Draw()
    {
        // Draw Matkort
        Raylib.DrawRectangleRec(LoadTexture.MatkortRect, Color.White);
        Raylib.DrawTexture(LoadTexture.MatkortBuilding, (int)LoadTexture.MatkortRect.X, (int)LoadTexture.MatkortRect.Y, Color.White);

        Raylib.DrawText($"{Matkort.Price} MP", (int)LoadTexture.MatkortRect.X + 75, (int)LoadTexture.MatkortRect.Y + 34, 20, Color.Black);
        Raylib.DrawText($"{Matkort.Price} MP", (int)LoadTexture.MatkortRect.X + 75, (int)LoadTexture.MatkortRect.Y + 33, 20, Color.Black);
        Raylib.DrawText($"{Matkort.Price} MP", (int)LoadTexture.MatkortRect.X + 75, (int)LoadTexture.MatkortRect.Y + 32, 20, Color.White);

        Raylib.DrawText($"{Matkort.Amount}", (int)LoadTexture.MatkortRect.X + 200, (int)LoadTexture.MatkortRect.Y + 12, 50, Color.Black);
        Raylib.DrawText($"{Matkort.Amount}", (int)LoadTexture.MatkortRect.X + 200, (int)LoadTexture.MatkortRect.Y + 11, 50, Color.Black);
        Raylib.DrawText($"{Matkort.Amount}", (int)LoadTexture.MatkortRect.X + 200, (int)LoadTexture.MatkortRect.Y + 10, 50, Color.White);
    }
}

public class Teacher : GameConstants, IDrawable
{
    public void Draw()
    {
        // Draw Teacher
        Raylib.DrawRectangleRec(LoadTexture.TeacherRect, Color.White);
        Raylib.DrawTexture(LoadTexture.TeacherBuilding, (int)LoadTexture.TeacherRect.X, (int)LoadTexture.TeacherRect.Y, Color.White);

        Raylib.DrawText($"{Teacher.Price} MP", (int)LoadTexture.TeacherRect.X + 75, (int)LoadTexture.TeacherRect.Y + 34, 20, Color.Black);
        Raylib.DrawText($"{Teacher.Price} MP", (int)LoadTexture.TeacherRect.X + 75, (int)LoadTexture.TeacherRect.Y + 33, 20, Color.Black);
        Raylib.DrawText($"{Teacher.Price} MP", (int)LoadTexture.TeacherRect.X + 75, (int)LoadTexture.TeacherRect.Y + 32, 20, Color.White);

        Raylib.DrawText($"{Teacher.Amount}", (int)LoadTexture.TeacherRect.X + 200, (int)LoadTexture.TeacherRect.Y + 12, 50, Color.Black);
        Raylib.DrawText($"{Teacher.Amount}", (int)LoadTexture.TeacherRect.X + 200, (int)LoadTexture.TeacherRect.Y + 11, 50, Color.Black);
        Raylib.DrawText($"{Teacher.Amount}", (int)LoadTexture.TeacherRect.X + 200, (int)LoadTexture.TeacherRect.Y + 10, 50, Color.White);
    }
}

public class Matsal : GameConstants, IDrawable
{
    public void Draw()
    {
        // Draw Teacher
        Raylib.DrawRectangleRec(LoadTexture.MatsalRect, Color.White);
        Raylib.DrawTexture(LoadTexture.MatsalBuilding, (int)LoadTexture.MatsalRect.X, (int)LoadTexture.MatsalRect.Y, Color.White);

        Raylib.DrawText($"{Matsal.Price} MP", (int)LoadTexture.MatsalRect.X + 75, (int)LoadTexture.MatsalRect.Y + 34, 20, Color.Black);
        Raylib.DrawText($"{Matsal.Price} MP", (int)LoadTexture.MatsalRect.X + 75, (int)LoadTexture.MatsalRect.Y + 33, 20, Color.Black);
        Raylib.DrawText($"{Matsal.Price} MP", (int)LoadTexture.MatsalRect.X + 75, (int)LoadTexture.MatsalRect.Y + 32, 20, Color.White);

        Raylib.DrawText($"{Matsal.Amount}", (int)LoadTexture.MatsalRect.X + 200, (int)LoadTexture.MatsalRect.Y + 12, 50, Color.Black);
        Raylib.DrawText($"{Matsal.Amount}", (int)LoadTexture.MatsalRect.X + 200, (int)LoadTexture.MatsalRect.Y + 11, 50, Color.Black);
        Raylib.DrawText($"{Matsal.Amount}", (int)LoadTexture.MatsalRect.X + 200, (int)LoadTexture.MatsalRect.Y + 10, 50, Color.White);
    }
}

public class Pendeltag : GameConstants, IDrawable
{
    public void Draw()
    {
        // Draw Teacher
        Raylib.DrawRectangleRec(LoadTexture.PendeltagRect, Color.White);
        Raylib.DrawTexture(LoadTexture.PendeltagBuilding, (int)LoadTexture.PendeltagRect.X, (int)LoadTexture.PendeltagRect.Y, Color.White);

        Raylib.DrawText($"{Pendeltag.Price} MP", (int)LoadTexture.PendeltagRect.X + 75, (int)LoadTexture.PendeltagRect.Y + 34, 20, Color.Black);
        Raylib.DrawText($"{Pendeltag.Price} MP", (int)LoadTexture.PendeltagRect.X + 75, (int)LoadTexture.PendeltagRect.Y + 33, 20, Color.Black);
        Raylib.DrawText($"{Pendeltag.Price} MP", (int)LoadTexture.PendeltagRect.X + 75, (int)LoadTexture.PendeltagRect.Y + 32, 20, Color.White);

        Raylib.DrawText($"{Pendeltag.Amount}", (int)LoadTexture.PendeltagRect.X + 200, (int)LoadTexture.PendeltagRect.Y + 12, 50, Color.Black);
        Raylib.DrawText($"{Pendeltag.Amount}", (int)LoadTexture.PendeltagRect.X + 200, (int)LoadTexture.PendeltagRect.Y + 11, 50, Color.Black);
        Raylib.DrawText($"{Pendeltag.Amount}", (int)LoadTexture.PendeltagRect.X + 200, (int)LoadTexture.PendeltagRect.Y + 10, 50, Color.White);
    }
}

public class MPSText : IDrawable
{
    public void Draw()
    {
        Raylib.DrawText($"{MPSCalculator.TotalMPS} MPS", (int)LoadTexture.NTIrect.X + 55, (int)LoadTexture.NTIrect.Y - 24, 15, Color.Black);
        Raylib.DrawText($"{MPSCalculator.TotalMPS} MPS", (int)LoadTexture.NTIrect.X + 55, (int)LoadTexture.NTIrect.Y - 23, 15, Color.Black);

        Raylib.DrawText($"{MPSCalculator.TotalMPS} MPS", (int)LoadTexture.NTIrect.X + 55, (int)LoadTexture.NTIrect.Y - 25, 15, Color.White);
    }
}