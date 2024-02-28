public class ClickAction : IClickable
{
    private readonly static GameAudio audio = new();

    public void Click()
    {
        if (Raylib.IsMouseButtonPressed(MouseButton.Left))
        {
            // Check if the mouse click is within the button rectangle
            if (Raylib.CheckCollisionPointRec(Raylib.GetMousePosition(), LoadTexture.NTIrect))
            {
                Raylib.PlaySound(audio.clickNTI);
                GameConstants.MP += GameConstants.BaseMPClick;
                Raylib.DrawText($"+{GameConstants.BaseMPClick}", (int)Raylib.GetMousePosition().X, (int)Raylib.GetMousePosition().Y, 100, Color.White);
            }
        }


        if (Raylib.IsMouseButtonPressed(MouseButton.Left))
        {
            // Check if the mouse click is within the button rectangle
            if (Raylib.CheckCollisionPointRec(Raylib.GetMousePosition(), LoadTexture.MatkortRect))
            {
                if (GameConstants.MP >= GameConstants.Matkort.Price)
                {
                    BuildingCalculators.BuyBuilding(GameConstants.Matkort);
                }
            }
            else if (Raylib.CheckCollisionPointRec(Raylib.GetMousePosition(), LoadTexture.TeacherRect))
            {
                if (GameConstants.MP >= GameConstants.Teacher.Price)
                {
                    BuildingCalculators.BuyBuilding(GameConstants.Teacher);
                }
            }
            else if (Raylib.CheckCollisionPointRec(Raylib.GetMousePosition(), LoadTexture.MatsalRect))
            {
                if (GameConstants.MP >= GameConstants.Matsal.Price)
                {
                    BuildingCalculators.BuyBuilding(GameConstants.Matsal);
                }
            }
            else if (Raylib.CheckCollisionPointRec(Raylib.GetMousePosition(), LoadTexture.PendeltagRect))
            {
                if (GameConstants.MP >= GameConstants.Pendeltag.Price)
                {
                    BuildingCalculators.BuyBuilding(GameConstants.Pendeltag);
                }
            }
            else if (Raylib.CheckCollisionPointRec(Raylib.GetMousePosition(), LoadTexture.LaptopRect))
            {
                if (GameConstants.MP >= GameConstants.Laptop.Price)
                {
                    BuildingCalculators.BuyBuilding(GameConstants.Laptop);
                }
            }
            else if (Raylib.CheckCollisionPointRec(Raylib.GetMousePosition(), LoadTexture.RektorRect))
            {
                if (GameConstants.MP >= GameConstants.Rektor.Price)
                {
                    BuildingCalculators.BuyBuilding(GameConstants.Rektor);
                }
            }
        }
    }
}