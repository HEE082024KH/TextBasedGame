public class Status
{
    Items items = new();

    public void showStatus()
    {
        Console.WriteLine($"Current HP: {items.HP}/50");
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
        return;
    }
}