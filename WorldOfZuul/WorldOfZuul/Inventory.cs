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
    
    public void ShowInventory(){

        if (items.Count == 0){
            Console.WriteLine("Inventory is empty!");
        
        }

        else{
            Console.WriteLine("Your inventory contains:");
            foreach(var item in items){
                Console.WriteLine("- " + item);

            }


        }
    }


        

}















}

