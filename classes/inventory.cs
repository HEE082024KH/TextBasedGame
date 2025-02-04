public class Status(Locations locations, Items items)
{
  public void ShowStatus()
  {
    Console.WriteLine($"Current HP: {items.HealthPoints}/100");
    Console.WriteLine(($"Current $: {items.Money}"));
    if (items.IsBuzzed)
    {
      Console.WriteLine("You feel buzzed.");
    }
    else if (items.IsDrunk)
    {
      Console.WriteLine("You feel drunk.");
    }
    else if (items.IsHammered)
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

  public void UseItems()
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
      locations.itemInput = Console.ReadLine()?.ToLower();
    }
    catch
    {
      Console.WriteLine("Invalid input");
      UseItems();
    }

    switch (locations.itemInput)
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
        if (items.IsBuzzed)
        {
          items.IsDrunk = true;
          items.IsBuzzed = false;
        }
        else if (items.IsDrunk)
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

  public void ShowInventory()
  {
    Console.WriteLine("You have the following items in your inventory:");
    if (items.GateKey)
    {
      Console.WriteLine("- Gate Key");
    }

    if (items.Flashlight)
    {
      Console.WriteLine("- Flashlight");
    }

    if (items.Hairpin)
    {
      Console.WriteLine("- Hairpin");
    }

    if (items.Crowbar)
    {
      Console.WriteLine("- Crowbar");
    }

    if (items.Knife)
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

    if (items.Key)
    {
      Console.WriteLine("- Key");
    }

    if (items.Necklace)
    {
      Console.WriteLine("- Necklace");
    }

    if (items.GreenGem)
    {
      Console.WriteLine("- Green Gem");
    }

    if (items.OfficeKeycard)
    {
      Console.WriteLine("- Office Keycard");
    }

    Console.WriteLine(">");
    Console.ReadLine();
  }
}