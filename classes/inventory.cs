public class Status(Locations locations)
{
    private Locations locations = locations;
    Items items = new();

    public void ShowStatus()
    {
        Console.WriteLine($"Current HP: {items.healthPoints}/50");
        Console.WriteLine("1. Check inventory");
        Console.WriteLine("2. Use item");
        Console.WriteLine("3. Go back");
        try
        {
            locations.input = Convert.ToInt32(Console.ReadLine());
        }
        catch
        {
            Console.WriteLine("Invalid input");
        }
        switch (locations.input)
        {
            case 1:
                ShowInventory();
                break;
            case 2:
                ;
                break;
            case 3:
                break;
        }
    }

    public void ShowItems()
    {
        Console.WriteLine("You have the following items in your inventory:");
        if (items.hasFlashlight == true)
        {
            Console.WriteLine();
        }
    }

    private void ShowInventory()
    {
    Console.WriteLine("You have the following items in your inventory:");
        if (items.hasFlashlight == true)
        {
            Console.WriteLine("- Flashlight");
        }
        if (items.hasHairpin == true)
        {
            Console.WriteLine("- Hairpin");
        }
        if (items.hasCrowbar == true)
        {
            Console.WriteLine("- Crowbar");
        }
        if (items.hasKnife == true)
        {
            Console.WriteLine("- Knife");
        }
        Console.WriteLine(">");
        Console.ReadLine();
    }
}