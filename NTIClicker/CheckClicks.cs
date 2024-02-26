public class ClickAction : computeBuildingCost, IClickable
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

                Raylib.DrawText($"+{BaseMPClick}", (int)Raylib.GetMousePosition().X, (int)Raylib.GetMousePosition().Y, 100, Color.White);

                if (MP == 5)
                {
                    Console.WriteLine("Hello this works!");
                }
            }
        }


        if (Raylib.IsMouseButtonPressed(MouseButton.Left))
        {
            // Check if the mouse click is within the button rectangle
            if (Raylib.CheckCollisionPointRec(Raylib.GetMousePosition(), LoadTexture.MatkortRect))
            {
                if (MP >= MatkortPrice)
                {
                    MatkortAmount++;
                    MP -= MatkortPrice;
                    Raylib.PlaySound(audio.buyBuilding);
                    computeMatkortCost();

                    Console.WriteLine(MatkortPrice);
                    Console.WriteLine(MP);
                    Console.WriteLine(MatkortAmount);
                }
            }
        }
    }
}