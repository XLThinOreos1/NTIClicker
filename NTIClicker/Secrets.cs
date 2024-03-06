using System.Numerics;

public class KonamiCodeDetector
{
    readonly List<KeyboardKey> inputs = [KeyboardKey.Up, KeyboardKey.Down, KeyboardKey.Left, KeyboardKey.Right, KeyboardKey.B, KeyboardKey.A];
    readonly List<KeyboardKey> inputList = [];
    static readonly List<KeyboardKey> konamiCodeSequence =
    [
        KeyboardKey.Up,
        KeyboardKey.Up,
        KeyboardKey.Down,
        KeyboardKey.Down,
        KeyboardKey.Left,
        KeyboardKey.Right,
        KeyboardKey.Left,
        KeyboardKey.Right,
        KeyboardKey.B,
        KeyboardKey.A
    ];

    //everything after this comment in game loop

    public bool IsKonamiActivated = false;

    public void KonamiUpdate()
    {
        foreach (KeyboardKey i in inputs)
        {
            if (Raylib.IsKeyPressed(i))
            {
                inputList.Add(i);
            }
            Console.WriteLine(i);
        }

        //while because the player could press multiple at once. but its probably fine as an if as it would fix itself after a couple frames.
        while (inputList.Count > konamiCodeSequence.Count)
        {
            inputList.RemoveAt(0);
        }

        if (inputList.SequenceEqual(konamiCodeSequence))
        {
            IsKonamiActivated = true;
        }
    }
}


public class DebugMenu : IClickable
{

    Rectangle rectangle1 = new(0, 620, 100, 100);
    Rectangle rectangle2 = new(125, 620, 100, 100);
    Rectangle rectangle3 = new(250, 620, 100, 100);
    Rectangle rectangle4 = new(375, 620, 100, 100);
    Rectangle rectangle5 = new(500, 620, 100, 100);

    public void Click()
    {
        if (Raylib.IsMouseButtonPressed(MouseButton.Left))
        {
            // Get mouse position
            Vector2 mousePosition = Raylib.GetMousePosition();

            // Check if mouse is inside any of the smaller rectangles

            if (Raylib.CheckCollisionPointRec(mousePosition, rectangle1))
            {
                GameConstants.MP *= 10;
                // Action for "x10"
            }


            if (Raylib.CheckCollisionPointRec(mousePosition, rectangle2))
            {
                GameConstants.MP *= 100;
                // Action for "x100"
            }


            if (Raylib.CheckCollisionPointRec(mousePosition, rectangle3))
            {
                GameConstants.Matkort.Amount += 100;
                GameConstants.Teacher.Amount += 100;
                GameConstants.Matsal.Amount += 100;
                GameConstants.Pendeltag.Amount += 100;
                GameConstants.Laptop.Amount += 100;
                GameConstants.Rektor.Amount += 100;
                // Action for "100 buildings"
            }


            if (Raylib.CheckCollisionPointRec(mousePosition, rectangle4))
            {
                GameConstants.MP += ulong.MaxValue;
                // Action for "inf money"
            }

            if (Raylib.CheckCollisionPointRec(mousePosition, rectangle5))
            {
                GameConstants.MP = 0;
                // Action for "reset money"
            }
        }
    }

    public static void DrawDebugMenu()
    {
        // Draw smaller rectangles with text
        Raylib.DrawRectangle(0, 620, 100, 100, Color.Orange);
        Raylib.DrawText("x10", 5, 620, 20, Color.Black);

        Raylib.DrawRectangle(125, 620, 100, 100, Color.Green);
        Raylib.DrawText("x100", 130, 620, 20, Color.Black);

        Raylib.DrawRectangle(250, 620, 100, 100, Color.Yellow);
        Raylib.DrawText("100 buildings", 255, 620, 15, Color.Black);

        Raylib.DrawRectangle(375, 620, 100, 100, Color.Blue);
        Raylib.DrawText("inf money", 380, 620, 15, Color.Black);

        Raylib.DrawRectangle(500, 620, 100, 100, Color.Gray);
        Raylib.DrawText("reset money", 505, 620, 15, Color.Black);
    }
}

public class FunEasterEggs
{
    public static void GameWindowChangeFun()
    {
        if (GameConstants.MP.ToString().Contains("666"))
        {
            Raylib.SetWindowTitle("EVIL NTI Clicker");
            Raylib.SetWindowIcon(LoadTexture.EvilNTILogoImage);
        }
        else
        {
            Raylib.SetWindowTitle("NTI Clicker");
            Raylib.SetWindowIcon(LoadTexture.NTILogoImage);
        }
    }

    public static void OpenWindow()
    {
        // idea Raylib.InitWindow fast med subway surfers gameplay för adhd barn
        Raylib.OpenURL("https://www.youtube.com/watch?v=eRXE8Aebp7s");
    }
}