namespace WorldOfZuul
{
    public static class Items
    {

        public const string Water = "A tank of fresh water. Reduces the pollution bar.";
        public const string Crown = "The Fish Mayor's crown. Makes questions slightly easier.";
        public const string Hourglass = "Allows the player to answer the questions for a longer period of time.";
        
        

        public static Item CreateWater(int x, int y)
        {
            return new Item("A fresh water tank", Water, x, y);
        }

        public static Item CreateCrown(int x, int y)
        {
            return new Item("Fish Mayor's Crown", Crown, x, y);
        }
    }

    public class Item
    {
        public string Name { get; private set; }
        public string Description { get; private set; }
        public int X { get; private set; }
        public int Y { get; private set; }

        public Item(string name, string description, int x, int y)
        {
            Name = name;
            Description = description;
            X = x;
            Y = y;
        }
    }
}





