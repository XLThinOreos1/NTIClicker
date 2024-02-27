public class GameLoop : GameTimer
{
    private readonly static NTITexture NTI = new();
    private readonly static Matkort matkort = new();
    private readonly static Teacher teacher = new();
    private readonly static Matsal matsal = new();
    private readonly static Pendeltag pendeltag = new();
    private readonly static Laptop laptop = new();
    private readonly static MPDisplay mpdisplay = new();
    private readonly static MPSText mpstext = new();
    private readonly static ClickAction click = new();
    private readonly static BlueBG Background = new();

    public void RunGameLoop()
    {
        OneSecondTimer();
        MPSCalculator.UpdateMPS();

        // Draw game textures and text
        Background.Draw();
        NTI.Draw();
        matkort.Draw();
        teacher.Draw();
        matsal.Draw();
        pendeltag.Draw();
        laptop.Draw();
        mpdisplay.Draw();
        mpstext.Draw();

        // Check for any mouse clicks
        click.Click();

        if (Raylib.IsKeyPressed(KeyboardKey.A))
        {
            GameConstants.Teacher.Amount += 10;
        }
        if (Raylib.IsKeyPressed(KeyboardKey.B))
        {
            GameConstants.MP += 1000000;
        }
    }
}