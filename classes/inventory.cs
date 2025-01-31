public class Status(Locations locations)
{
    private Locations locations = locations;
    Items items = new();
    public string? itemInput;
    public void ShowStatus()
    {
        Console.WriteLine($"Current HP: {items.HealthPoints}/100");
        if (items.IsBuzzed == true)
        {
            Console.WriteLine("You feel buzzed.");
        }
        else if (items.IsDrunk == true)
        {
            Console.WriteLine("You feel drunk.");
        }
        else if (items.IsHammered == true)
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
        if (items.Bandages > 0)
        {
            Console.WriteLine("- Bandage");
        }
        if (items.Alcohol > 0)
        {
            Console.WriteLine("- Alcohol");
        }
        try
        {
            itemInput = Console.ReadLine()?.ToLower();
        }
        catch
        {
            Console.WriteLine("Invalid input");
            UseItems();
        }
        switch (itemInput)
        {
            case "bandages":
                if (items.HealthPoints > 70)
                {
                    items.HealthPoints = 100;
                }
                else if (items.HealthPoints == 100)
                {
                    Console.WriteLine("You are already full health.");
                }
                else
                {
                    items.Bandages = items.Bandages--;
                    items.HealthPoints += 30;
                }
                break;
            case "alcohol":
                if (items.IsBuzzed == true)
                {
                    items.IsDrunk = true;
                    items.IsBuzzed = false;
                }
                else if (items.IsDrunk == true)
                {
                    items.IsHammered = true;
                    items.IsDrunk = false;
                }
                else
                {
                    items.IsBuzzed = true;
                }

                items.Alcohol = items.Alcohol--;
                break;
        }
    }

    private void ShowInventory()
    {
        Console.WriteLine("You have the following items in your inventory:");
        if (items.Flashlight == true)
        {
            Console.WriteLine("- Flashlight");
        }
        if (items.Hairpin == true)
        {
            Console.WriteLine("- Hairpin");
        }
        if (items.Crowbar == true)
        {
            Console.WriteLine("- Crowbar");
        }
        if (items.Knife == true)
        {
            Console.WriteLine("- Knife");
        }
        if (items.Bandages > 0)
        {
            Console.WriteLine("- Bandages");
        }
        if (items.Alcohol > 0)
        {
            Console.WriteLine("- Alcohol");
        }
        Console.WriteLine(">");
        Console.ReadLine();
    }
}