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
        Console.WriteLine($"{item.Symbol} added to your inventory.");
    }

        public string ShowInventory()
        {
            int width = 88;
            int maxLines = 6;
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("    ┌" + new string('─', width - 4) + "┐");
            sb.AppendLine("    │" + " Inventory:".PadRight(width - 4) + "│");

            if (items.Count == 0)
            {
                sb.AppendLine("    │" + " Inventory is empty!".PadRight(width - 4) + "│");
                for (int i = 0; i < maxLines - 3; i++) // Reserve 3 lines for header, empty message, and footer
                {
                    sb.AppendLine("    │" + new string(' ', width - 4) + "│");
                }
            }
            else
            {
                int linesToShow = Math.Min(items.Count, maxLines - 3); // Reserve 3 lines for header, footer, and possible "more items" line
                for (int i = 0; i < linesToShow; i++)
                {
                    sb.AppendLine("    │" + (" - " + items[i].Symbol).PadRight(width - 4) + "│");
                }

                if (items.Count > linesToShow)
                {
                    sb.AppendLine("    │" + (" ... and more items").PadRight(width - 4) + "│");
                }

                int paddingLines = maxLines - 3 - linesToShow - (items.Count > linesToShow ? 1 : 0);
                for (int i = 0; i < paddingLines; i++)
                {
                    sb.AppendLine("    │" + new string(' ', width - 4) + "│");
                }
            }

            sb.Append("    └" + new string(' ', width - 4) + "┘");

            return sb.ToString();
        }

}
}

