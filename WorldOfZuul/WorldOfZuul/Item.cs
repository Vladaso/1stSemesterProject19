namespace WorldOfZuul
{
    public class Item
    {
        public string Name { get; private set; }
        public string Description { get; private set; }
        public int X { get; private set; }
        public int Y { get; private set; }
        public int RoomNumber { get; private set; }
        public string Symbol { get; private set; }

        public Item(string name, string description, int x, int y, int roomNumber, string symbol)
        {
            Name = name;
            Description = description;
            X = x;
            Y = y;
            RoomNumber = roomNumber;
            Symbol = symbol;
        }
    }
}





