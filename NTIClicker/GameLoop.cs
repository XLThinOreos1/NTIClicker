public class GameLoop : GameStats
{
    private static BlueBG Background = new();
    private static NTITexture NTI = new();
    private static Matkort matkort = new();
    private static Teacher teacher = new();
    private static MPDisplay mpdisplay = new();
    private static ClickAction click = new();

    public void RunGameLoop()
    {
        Raylib.BeginDrawing();

        click.Click();

        // Draw
        Background.Draw();
        mpdisplay.Draw();
        NTI.Draw();
        matkort.Draw();
        teacher.Draw();

        Raylib.EndDrawing();
    }
}