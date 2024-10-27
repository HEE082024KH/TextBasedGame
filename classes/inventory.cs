public class Inventory
{
    Items items = new();

    public void openInventory()
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
    }
}