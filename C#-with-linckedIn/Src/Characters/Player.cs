namespace OOPAdventure;
public class Player : Character, IInvertory
{
    public readonly IInvertory _invertory;
    public Player(string name) : base(name)
    {
        _invertory = new Invertory();
    }

    public int Total => _invertory.Total;

    public string[] InvertoryList => _invertory.InvertoryList;

    public void Add(Item item)
    {
        _invertory.Add(item);
    }

    public bool Contains(string itemName)
    {
        return _invertory.Contains(itemName);
    }

    public Item? Find(string itemName)
    {
        return _invertory.Find(itemName);
    }

    public Item? Find(string itemName, bool remove)
    {
        return _invertory.Find(itemName, remove);
    }

    public void Remove(Item item)
    {
        _invertory?.Remove(item);
    }

    public Item? Take(string itemName)
    {
        return _invertory.Take(itemName);
    }

    public void Use(string itemName, string source)
    {
        _invertory.Use(itemName, source);
    }
}