namespace MenuOPI;

public class DBItem<T> : IDBItem<T> where T : IID
{
    private int ctr = 1;
    
    public List<T> Items { get; set; }

    public DBItem()
    {
        Items = new List<T>();
    }

    public void AddItem(T item)
    {
        if (item != null)
        {
            item.ID = ctr++;
            Items.Add(item);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Item was successfully added.");
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Error was caught while adding new item.");
        }
        Console.ForegroundColor = ConsoleColor.Gray;
    }

    public void RemoveItem(int id)
    {
        T obj = Items.Find(x => x.ID == id);
        if (obj != null)
        {
            Items.Remove(obj);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Item with ID={0} was deleted.", id);
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Error was caught while adding new item.");
            Console.WriteLine("Item with ID={0} not found.", id);
        }
        Console.ForegroundColor = ConsoleColor.Gray;
    }

    public void FindItem(int id)
    {
        T obj = Items.Find(x => x.ID == id);
        if (obj != null)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(obj);
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Item with ID={0} not found.", id);
        }
        Console.ForegroundColor = ConsoleColor.Gray;
    }

    public void ShowItems()
    {
        Console.WriteLine("\nID    Brand    Model");
        Console.WriteLine("______________________");
        foreach (T obj in Items)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(obj);
        }
        Console.ForegroundColor = ConsoleColor.Gray;
    }
}