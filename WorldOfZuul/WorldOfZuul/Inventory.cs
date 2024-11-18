namespace WorldOfZuul{

public class Inventory{
    private List<string> items;

    public Inventory()
    {
        items = new List<string>();
    }

    public void AddItem(string item)
    {
        items.Add(item);
        Console.WriteLine($"{item} added to your inventory.");
    }

    public void RemoveItem(string item)
    {
        if(items.Contains(item)){
            items.Remove(item);
            Console.WriteLine($"{item} removed from inventory.");
        }
        else{
            Console.WriteLine($"{item} is not in inventory.");
        }

    }
    
 
public void ShowInventory()
{
    int width = 88; 

    Console.WriteLine("    ┌" + new string('─', width - 4) + "┐");

    Console.WriteLine("    │" + " Inventory:".PadRight(width - 4) + "│");

    if (items.Count == 0)
    {
        Console.WriteLine("    │" + " Inventory is empty!".PadRight(width - 4) + "│");
    }
    else
    {
        foreach (var item in items)
        {
            Console.WriteLine("    │" + (" - " + item).PadRight(width - 4) + "│");
        }
    }

    Console.Write("    └" + new string('─', width - 4) + "┘");
}


}


}

