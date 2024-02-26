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
                    GameConstants.Matkort.MPS++;
                    GameConstants.Matkort.Amount++;

                    Console.WriteLine(GameConstants.Matkort.MPS);
                    Console.WriteLine(GameConstants.Matkort.Amount);

                    GameConstants.MP -= GameConstants.Matkort.Price;

                    BuildingCostCalculator.ComputeCost(GameConstants.Matkort);

                    Raylib.PlaySound(audio.buyBuilding);
                }
            }
            else if (Raylib.CheckCollisionPointRec(Raylib.GetMousePosition(), LoadTexture.TeacherRect))
            {
                if (GameConstants.MP >= GameConstants.Teacher.Price)
                {
                    GameConstants.Teacher.Amount++;
                    GameConstants.Teacher.MPS += GameConstants.Teacher.Amount;
                    GameConstants.MP -= GameConstants.Teacher.Price;
                    BuildingCostCalculator.ComputeCost(GameConstants.Teacher);

                    Raylib.PlaySound(audio.buyBuilding);
                }
            }
        }
    }
}