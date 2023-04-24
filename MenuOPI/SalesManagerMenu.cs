namespace MenuOPI;

public class SalesManagerMenu
{

    public bool isWorking;
    
    private SalesManager salesManager;
    public SalesManagerMenu(SalesManager salesManager)
    {
        this.salesManager = salesManager;
    }

    public void Open()
    {
        while (isWorking)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nSALES MANAGER MENU");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("1. Show Laptops");
            Console.WriteLine("2. Add Laptop");
            Console.WriteLine("3. Remove Laptop");
            Console.WriteLine("4. Find Laptop");
            Console.WriteLine("5. Back");
            Console.Write("\r\nSelect an option: ");

            int i = int.Parse(Console.ReadLine());

            switch (i)
            {
                case 1:
                    salesManager.ShowLaptop();
                    break;
                case 2:
                    salesManager.LaptopCreate();
                    break;
                case 3:
                    salesManager.LaptopDelete();
                    break;
                case 4:
                    salesManager.LaptopFind();
                    break;
                case 5:
                    Console.Clear();
                    isWorking = false;
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Wrong option.");
                    break;
            } 
        }
    }
}