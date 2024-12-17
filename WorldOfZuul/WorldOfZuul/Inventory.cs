using System;
using System.Collections.Generic;
using System.Text;


namespace WorldOfZuul{

public class Inventory{
    public List<Item> items { get; private set; }

    public Inventory()
    {
        items = new List<Item>();
    }

    public void AddItem(Item item)
    {
        items.Add(item);
        Console.WriteLine($"{item.Symbol} - {item.Name} added to your inventory.");
        Console.WriteLine($"{item.Description}");
    }

public string ShowInventory()
{
    int width = 88;
    StringBuilder sb = new StringBuilder();

    sb.AppendLine("┌" + new string('─', width-4) + "┐");
    sb.AppendLine("│" + " Inventory".PadRight(width-4) + "│");

    if (items.Count == 0)
    {
        sb.AppendLine("│" + " Inventory is empty!".PadRight(width-4) + "│");
    }
    else
    {
        string itemsLine = string.Join(" | ", items.Select(item => item.Symbol));
        sb.AppendLine("│" + itemsLine.PadRight(width-4) + "│");
    }

    sb.AppendLine("└" + new string(' ', width-4) + "┘");

    return sb.ToString();
}
public bool HasItem(string itemName)
{
    // Check if any item in the list matches the given name
    return items.Exists(item => item.Name == itemName);
}
}

}

