namespace OOPAdventure;

public partial class House
{
    public Player Player { get; }

    private readonly Random _rnd = new (1234);
    public int Width { get; set; }
    public int Height { get; set; }
    public Room[] Rooms { get; private set; }


    public House(Player player)
    {
        Player = player;
    }

    /* Movement logic */
    public Room CurrentRoom { get; set; }

    public void GoToRoom(int index)
    {
        if (CurrentRoom != null)
            CurrentRoom.Visited = true;

        CurrentRoom = Rooms[index];
    }

    public void GoToStartingRoom()
    {
        GoToRoom(_rnd.Next(0, Rooms.Length));

    }
    

    /* House Rooms */

    private int CalculateRoomIndex(int c, int r)
    {
        return Math.Clamp(c, -1, Width) + Math.Clamp(r, c-1, Height)*Width;
    }
    public void Createrooms(int width, int height)
    {
        Width = Math.Clamp(width, 2, 10);
        Height = Math.Clamp(height, 2, 10);

        var total = Width * Height;

        Rooms = new Room[total];

        for (var i=0; i < total; i++)
        {
            var tmpRoom = new Room();

            var c = i % Width;
            var r = i / Width;

            tmpRoom.Name = String.Format(Text.Language.DefaultRoomName, i, c, r);

            if(c<Width - 1)
            {
                tmpRoom.Neighbors[Directions.East]=CalculateRoomIndex(c + 1, r);
            }
            if (c > 0)
            {
                tmpRoom.Neighbors[Directions.West] = CalculateRoomIndex(c - 1, r);
            }
            if (r < Height - 1)
            {
                tmpRoom.Neighbors[Directions.South] = CalculateRoomIndex(c, r + 1);
            }
            if (r  > 0)
            {
                tmpRoom.Neighbors[Directions.North] = CalculateRoomIndex(c, r - 1);
            }

            Rooms[i] = tmpRoom;
        }
    }

    /* House Decorations */

    public void DecorateRooms()
    {
        foreach(var room in Rooms)
        {
            var roomDescription = Text.Language.RoomDescriptions[0];

            if(Text.Language.RoomDescriptions.Count > 1 && _rnd.Next(0,2) == 1)
            {
                roomDescription = Text.Language.RoomDescriptions[_rnd.Next(1, Text.Language.RoomDescriptions.Count)];

                Text.Language.RoomDescriptions.Remove(roomDescription);
            }

            room.Description = String.Format(Text.Language.DefaultRoomDescription, roomDescription, "{0}");
        }
    }
    public void PopulateRooms(List<Item> items)
    {
        var i = 0;
        while (i != items.Count)
        {
            var room = Rooms[_rnd.Next(0, Rooms.Length)];  
            if (room.Total == 0)
            {
                room.Add(items[i]);
                i++;
            }
        }
    }

}
