namespace MenuOPI;

public class SalesManager
{
    private DBItem<Laptop> dbLaptops;

    public SalesManager(DBItem<Laptop> dbLaptops)
    {
        this.dbLaptops = dbLaptops;
    }

    public void LaptopCreate()
    {
        try
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\n\nAdding Laptop Master");
            Console.Write("Enter the brand name: ");
            string? brand = Console.ReadLine();
            if (string.IsNullOrEmpty(brand)) throw new ArgumentNullException();
            Console.Write("Enter model: ");
            string? model = Console.ReadLine();
            if (string.IsNullOrEmpty(model)) throw new ArgumentNullException();

            Laptop laptop = new Laptop(brand, model);
            dbLaptops.AddItem(laptop);
        }
        catch (ArgumentNullException e)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Value you entered is null.\n");
            LaptopCreate();
        }
    }
    //non-existent
    public void LaptopDelete()
    {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\n\nDeleting Laptop Master");
            Console.Write("Enter id: ");
            int id = int.Parse(Console.ReadLine());

            dbLaptops.RemoveItem(id);
    }

    public void LaptopFind()
    {
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine("\n\nFinding Laptop Master");
        Console.Write("Enter id: ");
        int id = int.Parse(Console.ReadLine());
        
        dbLaptops.FindItem(id);
    }

    public void ShowLaptop()
    {
        dbLaptops.ShowItems();
    }
}