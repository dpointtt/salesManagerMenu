namespace MenuOPI;

public interface IDBItem<T> where T : IID
{
    List<T> Items { get; set; }
    void AddItem(T item);
    void RemoveItem(int id);
    void FindItem(int id);
    void ShowItems();
}