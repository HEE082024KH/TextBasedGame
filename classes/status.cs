namespace TextBasedGame.classes;

public class Status(Locations locations, Lists lists)
{
  public void ShowStatus()
  {
    Console.WriteLine($"Current HP: {lists.GetValue("HealthPoints")}/100");
    Console.WriteLine($"Current $: {lists.GetValue("Money")}");
    if (lists.CheckBool("IsBuzzed"))
    {
      Console.WriteLine("You feel buzzed.");
    }
    else if (lists.CheckBool("IsDrunk"))
    {
      Console.WriteLine("You feel drunk.");
    }
    else if (lists.CheckBool("IsHammered"))
    {
      Console.WriteLine("You feel hammered.");
    }

    Console.WriteLine("1. Check inventory");
    Console.WriteLine("2. Use item");
    Console.WriteLine("3. Go back");
    try
    {
      lists.ModifyInt("Input", Convert.ToInt32(Console.ReadLine()));
    }
    catch
    {
      Console.Clear();
      Console.WriteLine("Invalid input");
      Thread.Sleep(1500);
      ShowStatus();
    }

    switch (lists.GetValue("Input"))
    {
      case 1:
        Console.Clear();
        lists.DisplayInventory();
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

    switch (lists.GetValue("Input"))
    {
      case "bandage":
        switch (lists.GetValue("HealthPoints"))
        {
          case 70:
            Console.WriteLine("You use a bandage, and is now at full health.");
            Thread.Sleep(3000);
            lists.ModifyInt("HP", 100);
            break;
          case 100:
            Console.WriteLine("You are already full health.");
            Thread.Sleep(2500);
            break;
          default:
            lists.ModifyValue("Bandages", i => i - 1);
            lists.ModifyValue("HP", i => i + 30);
            Console.WriteLine("You use a bandage.");
            Thread.Sleep(1000);
            Console.WriteLine($"HP: {lists.GetValue("HealthPoints")}/100");
            Thread.Sleep(2000);
            break;
        }

        break;
      case "alcohol":
        if (lists.CheckBool("IsBuzzed"))
        {
          Console.WriteLine("You take another drink.");
          Thread.Sleep(1500);
          Console.WriteLine("You start to feel drunk.");
          Thread.Sleep(2500);
          lists.AddItem("IsDrunk", -1, true);
          lists.AddItem("IsBuzzed", -1, false);
        }
        else if (lists.CheckBool("IsDrunk"))
        {
          Console.WriteLine("You take another drink.");
          Thread.Sleep(1500);
          Console.WriteLine("You start to feel hammered.");
          Thread.Sleep(2500);
          lists.AddItem("IsHammered", -1, true);
          lists.AddItem("IsDrunk", -1, false);
        }
        else
        {
          Console.WriteLine("You take a drink.");
          Thread.Sleep(1500);
          Console.WriteLine("You start to feel buzzed.");
          Thread.Sleep(2500);
          lists.AddItem("IsBuzzed", -1, true);
        }

        lists.ModifyValue("Alcohol", i => i - 1);
        break;
    }
  }
}