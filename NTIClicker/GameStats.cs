public class Building
{
    public uint Amount { get; set; }
    public uint MPS { get; set; }
    public uint BaseMPS { get; set; }
    public ulong Price { get; set; }
    public uint BasePrice { get; set; }

    public Building(uint amount, uint mps, uint baseMps, ulong price, uint basePrice)
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
    public static ulong MP = 0;
    public static uint BaseMPClick = 1;

    public static Building Matkort = new(0, 0, 1, 10, 10);
    public static Building Teacher = new(0, 0, 5, 100, 100);
    public static Building Matsal = new(0, 0, 15, 1100, 1100);
    public static Building Pendeltag = new(0, 0, 50, 12000, 12000);
    public static Building Laptop = new(0, 0, 300, 130000, 130000);
    public static Building Rektor = new(0, 0, 2000, 1400000, 1400000);
    public static List<Building> buildings = [Matkort, Teacher, Matsal, Pendeltag, Laptop, Rektor];
}