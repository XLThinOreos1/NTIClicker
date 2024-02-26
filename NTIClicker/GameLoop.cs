public class GameLoop : GameTimer
{
    private static NTITexture NTI = new();
    private static Matkort matkort = new();
    private static Teacher teacher = new();
    private static MPDisplay mpdisplay = new();
    private static MPSText mpstext = new();
    private static ClickAction click = new();
    private static BlueBG Background = new();

    public void RunGameLoop()
    {
        OneSecondTimer();
        MPSCalculator.UpdateMPS();

        // Draw game textures and text
        Background.Draw();
        NTI.Draw();
        matkort.Draw();
        teacher.Draw();
        mpdisplay.Draw();
        mpstext.Draw();

        // Check for any mouse clicks
        click.Click();
    }
}