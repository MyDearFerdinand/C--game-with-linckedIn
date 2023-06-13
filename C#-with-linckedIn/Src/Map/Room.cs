using System.Text;
namespace OOPAdventure;

public class Room : IInvertory
{
    public string Name { get; set; } = Text.Language.DefaultRoomName;
    public string Description { get; set; } = Text.Language.DefaultRoomDescription;

    private readonly IInvertory _invertory = new Invertory();

    public Dictionary<Directions, int> Neighbors { get; set; } = new()
    {
        { Directions.North, -1 },
        { Directions.East, -1 },
        { Directions.South, -1 },
        { Directions.West, -1 },
        { Directions.None, -1 },
    };
    public bool Visited { get; set; }

    public int Total => _invertory.Total;

    public string[] InvertoryList => _invertory.InvertoryList;

    public override string ToString ()
    {
        var sb = new StringBuilder();

        if(Visited)
        {
            sb.Append(string.Format(Text.Language.RoomOld, Name));
        }
        else
        {
            sb.Append(string.Format(Text.Language.RoomNew, Name));
        }
        var names = Enum.GetNames(typeof(Directions));

        var directions = (from p in names where Neighbors[(Directions)Enum.Parse(typeof(Directions), p)] > -1 select p.ToLower()).ToArray();

        var description = string.Format(Description, Text.Language.JoinedWordList(directions, Text.Language.And));

        sb.Append(description);

        return sb.ToString();
    }

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
        _invertory.Remove(item);
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
