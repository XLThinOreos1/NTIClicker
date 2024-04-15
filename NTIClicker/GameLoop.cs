public class GameLoop
{
    private readonly static NTITexture s_nti = new();
    private readonly static Matkort s_matkort = new();
    private readonly static Teacher s_teacher = new();
    private readonly static Matsal s_matsal = new();
    private readonly static Pendeltag s_pendeltag = new();
    private readonly static Laptop s_laptop = new();
    private readonly static Rektor s_rektor = new();
    private readonly static MPDisplay s_mpDisplay = new();
    private readonly static MPSText s_mpsText = new();
    private readonly static ClickAction s_click = new();
    private readonly static DebugMenu s_debugClick = new();
    private readonly static BlueBG s_background = new();
    private KonamiCodeDetector _konamiDetector = new();

    public void RunGameLoop()
    {
        // Update MPS every second
        GameTimer.Timer(1);
        MPSCalculator.UpdateMPS();

        // Console.WriteLine(GameConstants.MP.ToString("G41"));
        // Draw game textures and text
        s_background.Draw();
        s_nti.Draw();
        s_mpDisplay.Draw();
        s_mpsText.Draw();

        // Draw buildings
        s_matkort.Draw();
        s_teacher.Draw();
        s_matsal.Draw();
        s_pendeltag.Draw();
        s_laptop.Draw();
        s_rektor.Draw();

        if (!_konamiDetector.IsKonamiActivated)
        {
            _konamiDetector.KonamiUpdate();
        }
        else
        {
            DebugMenu.DrawDebugMenu();
            s_debugClick.Click();
        }

        // Check for any mouse clicks
        s_click.Click();
    }
}