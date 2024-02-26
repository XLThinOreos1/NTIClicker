public class GameLoop : GameTimer
{
    private static NTITexture NTI = new();
    private static Matkort matkort = new();
    private static Teacher teacher = new();
    private static MPDisplay mpdisplay = new();
    private static ClickAction click = new();

    public void RunGameLoop()
    {
        OneSecondTimer();

        // Draw game textures and text
        NTI.Draw();
        matkort.Draw();
        teacher.Draw();
        mpdisplay.Draw();

        // Check for any mouse clicks
        click.Click();

        if (Raylib.IsKeyPressed(KeyboardKey.A))
        {
            BaseMPClick++;
            Console.WriteLine($"{BaseMPClick}");
        }
    }
}