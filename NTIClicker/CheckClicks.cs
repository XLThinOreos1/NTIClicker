public class ClickAction : GameStats, IClickable
{
    static GameAudio audio = new();

    public void Click()
    {
        if (Raylib.IsMouseButtonPressed(MouseButton.Left))
        {
            // Check if the mouse click is within the button rectangle
            if (Raylib.CheckCollisionPointRec(Raylib.GetMousePosition(), LoadTexture.NTIrect))
            {
                Raylib.PlaySound(audio.clickNTI);
                MP += BaseMPClick;

                if (MP == 5)
                {
                    Console.WriteLine("Hello this works!");
                }
            }
        }
    }
}