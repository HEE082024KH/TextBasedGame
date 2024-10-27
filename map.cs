public class Map
{
    Locations locations = new();
    public void ShowMap()
    {
        Console.WriteLine("");
        Console.WriteLine("                              +---+           +-----------------------------+");
        Console.WriteLine("  +-----------+               | B |           |                             |");
        Console.WriteLine("  |           |               +---+           |                             |");
        Console.WriteLine("  |           |____             |             |                             |");
        Console.WriteLine("  |           |    |       +--------+         |                    +--------+");
        Console.WriteLine("  |           |    |       |        |         |                    |");
        Console.WriteLine("  +-----------+    --------|        |-----    |                    |");
        Console.WriteLine("    Abandoned      |       |        |    |    +--------------------+");
        Console.WriteLine("    Warehouse      |       +--------+    |       |  Office Building");
        Console.WriteLine("                   |        Pavilion     --------|");
        Console.WriteLine("                   |                             |");
        Console.WriteLine(" +----------+      | +---+                       |        +---------------+");
        Console.WriteLine(" |          |      |-| A |                       |        |               |");
        Console.WriteLine(" |          |      | +---+                       |        |               |");
        Console.WriteLine(" |          |      |          +--------+         |        |               |");
        Console.WriteLine(" |          |      |          |        |       +---+      |               |");
        Console.WriteLine(" |          |-----------------|        |-------| F |------|               |");
        Console.WriteLine(" |          |      |          |        |       +---+      |               |");
        Console.WriteLine(" |          |      |          +--------+         |        |               |");
        Console.WriteLine(" |          |      |            Subway           |        +---------------+");
        Console.WriteLine(" |          |      |           Entrance          |           Art Gallery");
        Console.WriteLine(" +----------+      |  +---+                  +--------+");
        Console.WriteLine("  Apartments       |--| S |                  |        |");
        Console.WriteLine("                   |  +---+                  |        |");
        Console.WriteLine("                   |                         |        |");
        Console.WriteLine("                   |                         +--------+");
        Console.WriteLine("                  Gate                          Shop");
        Console.WriteLine("");
        if (locations.currentLocation != null)
        {
            Console.WriteLine($"You are at: {locations.currentLocation}     What do you want to do?");
            Console.WriteLine("1. Travel to a location     2. Check inventory");
            locations.input = Convert.ToInt32(Console.ReadLine());
            while (locations.input != 1 || locations.input == 2)
            {
                if (locations.input == 1)
                {
                    Console.WriteLine("Where do you want to travel to?");
                    locations.currentLocation = Console.ReadLine();
                }
                else if (locations.input == 2)
                {
                    Inventory inventory = new();
                    inventory.openInventory();
                }
            }
        }
        else
        {            
            Console.WriteLine("What do you want to do?");
            Console.WriteLine("1. Travel to a location     2. Check inventory");
            locations.input = Convert.ToInt32(Console.ReadLine());
            while (locations.input != 1 || locations.input == 2)
            {
                if (locations.input == 1)
                {
                    Console.WriteLine("Where do you want to travel to?");
                    locations.currentLocation = Console.ReadLine();
                }
                else if (locations.input == 2)
                {
                    Inventory inventory = new();
                    inventory.openInventory();
                }
            }
        }
    }

}