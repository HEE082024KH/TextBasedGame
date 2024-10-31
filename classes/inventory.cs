public class Status
{
    Items items = new();

    public void showStatus()
    {
        Console.WriteLine($"HP: {items.HP}/50");
        Console.WriteLine("");
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
        return;
    }
}