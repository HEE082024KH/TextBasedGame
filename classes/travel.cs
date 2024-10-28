public class Travel
{
    public void MapOptions()
    {
        Locations locations = new();

        if (locations.currentLocation != null)
        {
            Console.WriteLine($"You are at: {locations.currentLocation}     What do you want to do?");
            Console.WriteLine("1. Travel to a location     2. Check inventory");
            locations.input = Convert.ToInt32(Console.ReadLine());
            while (locations.input != 1 || locations.input == 2)
            {
                if (locations.input == 1)
                {
                    locations.LocationSelector();
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
                    locations.LocationSelector();
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