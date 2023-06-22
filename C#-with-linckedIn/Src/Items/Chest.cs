namespace OOPAdventure;

public class Chest : Item, IInvertory
{

    private readonly House _house;
    private readonly Invertory _invertory;

    public override string Name => Text.Language.Chest;

    public bool Locked => true;

    public Chest(Item?[] items, House house)
    {
        CanTake = false;
        _house = house;
        _invertory = new Invertory();

        foreach (var item in items)
        {
            Add(item);
        }
    }

    public override void Use(string source)
    {
        if(source == Text.Language.Key) 
        {
            var items = InvertoryList;
            if (Locked)
            {
                Console.WriteLine(Text.Language.UnlockChest);
            }
            if(items.Length == 0)
            {
                Console.WriteLine(Text.Language.ChestEmpty);
            } else
            {
                Console.WriteLine(string.Format(Text.Language.ChestFound, Text.Language.JoinedWordList(items, Text.Language.And)));
                foreach (var itemName in items)
                {
                    var item = Take(itemName);
                    _house.Player.Add(item);
                }
            }
        }
    }

    public int Total => ((IInvertory)_invertory).Total;

    public string[] InvertoryList => ((IInvertory)_invertory).InvertoryList;

    public void Add(Item item)
    {
        ((IInvertory)_invertory).Add(item);
    }

    public bool Contains(string itemName)
    {
        return ((IInvertory)_invertory).Contains(itemName);
    }

    public Item? Find(string itemName)
    {
        return ((IInvertory)_invertory).Find(itemName);
    }

    public Item? Find(string itemName, bool remove)
    {
        return ((IInvertory)_invertory).Find(itemName, remove);
    }

    public void Remove(Item item)
    {
        ((IInvertory)_invertory).Remove(item);
    }

    public Item? Take(string itemName)
    {
        return ((IInvertory)_invertory).Take(itemName);
    }

    public void Use(string itemName, string source)
    {
        ((IInvertory)_invertory).Use(itemName, source);
    }
}
