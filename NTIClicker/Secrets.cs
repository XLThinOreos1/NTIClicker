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
    private Rectangle _rectangle1 = new(0, 620, 100, 100);
    private Rectangle _rectangle2 = new(125, 620, 100, 100);
    private Rectangle _rectangle3 = new(250, 620, 100, 100);
    private Rectangle _rectangle4 = new(375, 620, 100, 100);
    private Rectangle _rectangle5 = new(500, 620, 100, 100);
    private Rectangle _rectangle6 = new(625, 620, 100, 100);
    private Rectangle _rectangle7 = new(750, 620, 100, 100);

    public void Click()
    {
        if (Raylib.IsMouseButtonPressed(MouseButton.Left))
        {
            // Get mouse position
            Vector2 mousePosition = Raylib.GetMousePosition();

            // Check if mouse is inside any of the debug rectangles

            // Action for x10
            if (Raylib.CheckCollisionPointRec(mousePosition, _rectangle1))
            {
                GameConstants.MP *= 10;
            }

            // Action for x100
            if (Raylib.CheckCollisionPointRec(mousePosition, _rectangle2))
            {
                GameConstants.MP *= 100;
            }

            // Action for 100 buildings
            if (Raylib.CheckCollisionPointRec(mousePosition, _rectangle3))
            {
                foreach (Building b in GameConstants.buildings)
                {
                    b.Amount += 100;
                }
            }

            // Action for infinite money
            if (Raylib.CheckCollisionPointRec(mousePosition, _rectangle4))
            {
                GameConstants.MP = ulong.MaxValue;
            }

            // Action for "reset money"
            if (Raylib.CheckCollisionPointRec(mousePosition, _rectangle5))
            {
                GameConstants.MP = 0;
            }

            // Action for reset buildings
            if (Raylib.CheckCollisionPointRec(mousePosition, _rectangle6))
            {
                foreach (Building b in GameConstants.buildings)
                {
                    b.Amount = 0;
                    b.Price = b.BasePrice;
                }
            }

            // Action for full wipe
            if (Raylib.CheckCollisionPointRec(mousePosition, _rectangle7))
            {
                foreach (Building b in GameConstants.buildings)
                {
                    b.Amount = 0;
                    b.Price = b.BasePrice;
                }
                GameConstants.MP = 0;
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

        Raylib.DrawRectangle(625, 620, 100, 100, Color.LightGray);
        Raylib.DrawText("reset \nbuildings", 630, 620, 15, Color.Black);

        Raylib.DrawRectangle(750, 620, 100, 100, Color.Red);
        Raylib.DrawText("full wipe", 755, 620, 15, Color.Black);
    }
}

public class FunEasterEggs
{
    public static void ChangeGameName()
    {
        if (GameConstants.MP.ToString().Contains("666"))
        {
            Raylib.SetWindowTitle("EVIL NTI Clicker");
            Raylib.SetWindowIcon(LoadTexture.EvilNTILogoImage);
        }
        // Reference to Dragon Ball meme
        else if (GameConstants.MP >= 9000 && GameConstants.MP < 9002)
        {
            Raylib.SetWindowTitle("It's over 9000!");
        }
        else
        {
            Raylib.SetWindowTitle("NTI Clicker");
            Raylib.SetWindowIcon(LoadTexture.NTILogoImage);
        }
    }
}