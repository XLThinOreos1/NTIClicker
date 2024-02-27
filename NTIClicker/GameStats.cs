// public class GameStats
// {
//     // Meritpoäng
//     public static int MP = 0;
//     public static int BaseMPClick = 1;


//     // Building amount
//     public static int MatkortAmount = 0;
//     public static int TeacherAmount = 0;


//     // Building MPS (Meritpoäng per second)
//     public static int MatkortMPS = 1;
//     public static int TeacherMPS = 2;


//     // Building prices
//     public static int MatkortPrice = 15;
//     public static int MatkortBasePrice = 15;
//     public static int TeacherPrice = 100;
//     public static int TeacherBasePrice = 100;

//     // List<string> GameBuilding = [ "Matkort", "Teacher" ];
//     string[] GameBuilding = ["Matkort", "Teacher"];
// }

public class Building
{
    public int Amount { get; set; }
    public int MPS { get; set; }
    public int BaseMPS { get; set; }
    public int Price { get; set; }
    public int BasePrice { get; set; }

    public Building(int amount, int mps, int baseMps, int price, int basePrice)
    {
        Amount = amount;
        MPS = mps;
        BaseMPS = baseMps;
        Price = price;
        BasePrice = basePrice;
    }
}

public class GameConstants
{
    public static int MP = 0;
    public static int BaseMPClick = 1;

    public static Building Matkort = new(0, 0, 1, 15, 15);
    public static Building Teacher = new(0, 0, 3, 100, 100);
    public static Building Matsal = new(0, 0, 10, 1000, 100);
}



// public static void UpdateBuildingCosts()
// {
//     BuildingCostCalculator.ComputeCost(GameConstants.Matkort);
//     BuildingCostCalculator.ComputeCost(GameConstants.Teacher);
// }