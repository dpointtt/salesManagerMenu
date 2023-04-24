namespace MenuOPI;

public class Laptop : IID
{
    public int ID { get; set; }
    public string Brand { get; }
    public string Model { get; }

    public Laptop(string brand, string model)
    {
        Brand = brand;
        Model = model;
    }

    public override string ToString()
    {
        Console.ForegroundColor = ConsoleColor.White;
        return string.Format(ID + "   " + Brand + "   " + Model);
    }
}