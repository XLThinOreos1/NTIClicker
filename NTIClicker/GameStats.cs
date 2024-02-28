public class Building
{
    public int Amount { get; set; }
    public int MPS { get; set; }
    public int BaseMPS { get; set; }
    public long Price { get; set; }
    public int BasePrice { get; set; }

    public Building(int amount, int mps, int baseMps, long price, int basePrice)
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
    public static long MP = 0;
    public static int BaseMPClick = 1;


    public static Building Matkort = new(0, 0, 1, 15, 15);
    public static Building Teacher = new(0, 0, 3, 100, 100);
    public static Building Matsal = new(0, 0, 10, 1100, 1100);
    public static Building Pendeltag = new(0, 0, 47, 12000, 12000);
    public static Building Laptop = new(0, 0, 260, 130000, 130000);
    public static Building Rektor = new(0, 0, 1400, 1400000, 1400000);
}