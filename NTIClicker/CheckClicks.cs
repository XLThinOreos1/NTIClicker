public class ClickAction : IClickable
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
        }
    }
}