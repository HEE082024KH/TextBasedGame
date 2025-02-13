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
      locations.Input = Convert.ToInt32(Console.ReadLine());
    }
    catch
    {
      Console.WriteLine("Invalid input");
      ShowStatus();
    }

    switch (locations.Input)
    {
      case 1:
        Console.Clear();
        ShowInventory();
        break;
      case 2:
        Console.Clear();
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
      locations.ItemInput = Console.ReadLine()?.ToLower();
    }
    catch
    {
      Console.WriteLine("Invalid input");
      Thread.Sleep(1500);
      UseItems();
    }

    switch (locations.ItemInput)
    {
      case "bandage":
        switch (items.HealthPoints)
        {
          case 70:
            Console.WriteLine("You use a bandage, and is now at full health.");
            Thread.Sleep(3000);
            items.HealthPoints = 100;
            break;
          case 100:
            Console.WriteLine("You are already full health.");
            Thread.Sleep(2500);
            break;
          default:
            items.Bandages = items.Bandages--;
            items.HealthPoints += 30;
            Console.WriteLine("You use a bandage.");
            Thread.Sleep(1000);
            Console.WriteLine($"HP: {items.HealthPoints}/100");
            Thread.Sleep(2000);
            break;
        }

        break;
      case "alcohol":
        if (items.IsBuzzed)
        {
          Console.WriteLine("You take another drink.");
          Thread.Sleep(1500);
          Console.WriteLine("You start to feel drunk.");
          Thread.Sleep(2500);
          items.IsDrunk = true;
          items.IsBuzzed = false;
        }
        else if (items.IsDrunk)
        {
          Console.WriteLine("You take another drink.");
          Thread.Sleep(1500);
          Console.WriteLine("You start to feel hammered.");
          Thread.Sleep(2500);
          items.IsHammered = true;
          items.IsDrunk = false;
        }
        else
        {
          Console.WriteLine("You take a drink.");
          Thread.Sleep(1500);
          Console.WriteLine("You start to feel buzzed.");
          Thread.Sleep(2500);
          items.IsBuzzed = true;
        }

        items.Alcohol = items.Alcohol--;
        break;
    }
  }

  private void ShowInventory()
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

    if (items.GreenGem)
    {
      Console.WriteLine("- Green Gem");
    }

    if (items.OfficeKeycard)
    {
      Console.WriteLine("- Office Keycard");
    }

    if (items.Necklace)
    {
      Console.WriteLine("- Necklace");
    }

    if (items.DogBone)
    {
      Console.WriteLine("- Dog Bone");
    }

    if (items.MachineGun)
    {
      Console.WriteLine("- Machine Gun");
    }

    if (items.Coin)
    {
      Console.WriteLine("- Coin");
    }

    if (items.Gun)
    {
      Console.WriteLine("- Gun");
    }

    Console.WriteLine(">");
    Console.ReadLine();
  }
}