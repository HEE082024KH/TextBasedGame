public class Status(Locations locations)
{
    private Locations locations = locations;
    Items items = new();

    public void showStatus()
    {
        Console.WriteLine($"Current HP: {items.HP}/50");
        Console.WriteLine();
        Console.WriteLine();
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
                break;
            case 2:
                break;
            default:
                break;
        }
    }
    
    public void showInventory()
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