namespace TextBasedGame.classes;

public class Status(Locations locations, Lists lists)
{
  public void ShowStatus()
  {
    while (true)
    {
      Console.WriteLine($"Current HP: {lists.GetValue("HP")}/100");
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
          continue;
        case 2:
          Console.Clear();
          UseItems();
          continue;
        case 3:
          break;
      }

      break;
    }
  }

  private void UseItems()
  {
    Console.WriteLine("Type which item you want to use");
    var usable = lists.Variables.Where(item => item.Usable && item.Amount >= 1);
    foreach (var item in usable)
    {
      Console.WriteLine($"{lists.Variables.IndexOf(item)}. {item.Name}");
    }

    try
    {
      lists.ModifyInt("Input", Convert.ToInt32(Console.ReadLine()));
    }
    catch
    {
      Console.Clear();
      Console.WriteLine("Invalid input");
      Thread.Sleep(1500);
      UseItems();
    }

    var items = usable.Where((_, index) => index == lists.GetValue("Input"))
      .FirstOrDefault();
    if (items.Name == "Bandages" && lists.GetValue("HP") >= 70)
    {
      Console.Clear();
      Console.WriteLine("You use a bandage, and is now at full health.");
      Thread.Sleep(3500);
      lists.ModifyInt("HP", 100);
    }
    else if (items.Name == "Bandages" && lists.GetValue("HP") == 100)
    {
      Console.Clear();
      Console.WriteLine("You are already full health.");
      Thread.Sleep(2500);
    }
    else
    {
      Console.Clear();
      lists.ModifyValue("Bandages", i => i - 1);
      lists.ModifyValue("HP", i => i + 30);
      Console.WriteLine("You use a bandage.");
      Thread.Sleep(2500);
      Console.WriteLine($"HP: {lists.GetValue("HealthPoints")}/100");
      Thread.Sleep(3000);
    }

    if (items.Name == "Alcohol" || lists.CheckBool("IsBuzzed"))
    {
      Console.Clear();
      Console.WriteLine("You take another drink.");
      Thread.Sleep(2500);
      Console.WriteLine("You start to feel drunk.");
      Thread.Sleep(3000);
      lists.AddItem("IsDrunk", -1, true);
      lists.AddItem("IsBuzzed", -1, false);
    }
    else if (items.Name == "Alcohol" || lists.CheckBool("IsDrunk"))
    {
      Console.Clear();
      Console.WriteLine("You take another drink.");
      Thread.Sleep(2500);
      Console.WriteLine("You start to feel hammered.");
      Thread.Sleep(2500);
      lists.AddItem("IsHammered", -1, true);
      lists.AddItem("IsDrunk", -1, false);
    }
    else if (items.Name == "Alcohol" || lists.CheckBool("IsHammered"))
    {
      Console.Clear();
      Console.WriteLine("You twake anowther dwink");
      Thread.Sleep(2500);
      Console.WriteLine("You pass out from drinking too much alcohol.");
      Thread.Sleep(4000);
      lists.ModifyInt("HP", 0);
      lists.Hp();
    }
    else
    {
      Console.Clear();
      Console.WriteLine("You take a drink.");
      Thread.Sleep(2500);
      Console.WriteLine("You start to feel buzzed.");
      Thread.Sleep(3000);
      lists.AddItem("IsBuzzed", -1, true);
    }

    lists.ModifyValue("Alcohol", i => i - 1);
  }
}