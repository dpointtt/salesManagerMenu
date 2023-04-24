namespace MenuOPI;

public class MainMenu
{
    public bool isWorking;
    private SalesManagerMenu _salesManagerMenu;
    
    public MainMenu(SalesManagerMenu salesManagerMenu)
    {
        _salesManagerMenu = salesManagerMenu;
    }

    public void Open()
    {
        isWorking = true;

        while (isWorking)
        {
            isWorking = !_salesManagerMenu.isWorking;
            
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nMAIN MENU");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("1. Sales Manager Menu");
            Console.WriteLine("2. Exit");
            Console.Write("\r\nSelect an option: ");

            int i = int.Parse(Console.ReadLine());

            switch (i)
            {
                case 1:
                    Console.Clear();
                    _salesManagerMenu.isWorking = true;
                    _salesManagerMenu.Open();
                    break;
                case 2:
                    isWorking = false;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Terminating...");
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Wrong option.");
                    break;
            } 
        }
    }
}