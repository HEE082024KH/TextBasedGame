public class Status(Locations locations)
{
    private Locations locations = locations;
    Items items = new();
    private string itemInput;
    public void ShowStatus()
    {
        Console.WriteLine($"Current HP: {items.healthPoints}/100");
        if (items.isBuzzed == true)
        {
            Console.WriteLine("You feel buzzed.");
        }
        else if (items.isDrunk == true)
        {
            Console.WriteLine("You feel drunk.");
        }
        else if (items.isHammered == true)
        {
            Console.WriteLine("You feel hammered.");
        }
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
            ShowStatus();
        }
        switch (locations.input)
        {
            case 1:
                ShowInventory();
                break;
            case 2:
                UseItems();
                break;
            case 3:
                break;
        }
    }

    private void UseItems()
    {
        Console.WriteLine("Type which item you want to use");
        if (items.hasBandages == true)
        {
            Console.WriteLine("- Bandage");
        }        
        if (items.hasAlcohol == true)
        {
            Console.WriteLine("- Alcohol");
        }
        try
        {
            itemInput = Console.ReadLine().ToLower();
        }
        catch
        {
            Console.WriteLine("Invalid input");
            UseItems();
        }
        switch (itemInput)
        {
            case "bandages":
                if (items.healthPoints > 70)
                {
                    items.healthPoints = 100;
                }
                else if (items.healthPoints == 100)
                {
                    Console.WriteLine("You are already full health.");
                }
                else
                {
                    items.bandages = items.bandages--;
                    items.healthPoints += 30;
                }
                break;
            case "alcohol":
                if (items.isBuzzed == true)
                {
                    items.isDrunk = true;
                    items.isBuzzed = false;
                }
                else if (items.isDrunk == true)
                {
                    items.isHammered = true;
                    items.isDrunk = false;
                }
                else
                {
                    items.isBuzzed = true;
                }

                items.alcohol = items.alcohol--;
                break;
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
        if (items.hasBandages == true)
        {
            Console.WriteLine("- Bandages");
        }        
        if (items.hasAlcohol == true)
        {
            Console.WriteLine("- Alcohol");
        }
        Console.WriteLine(">");
        Console.ReadLine();
    }
}