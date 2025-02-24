using TextBasedGame.classes;

public class AlleyLocation(Locations locations, Lists lists)
{
  private readonly Status? status = locations.Status;

  public void Alley()
  {
    while (true)
    {
      if (!lists.CheckBool("alley"))
      {
        Console.Clear();
        Console.WriteLine("");
        Thread.Sleep(2000);
        lists.AddItem("alley", -1, true);
      }

      lists.CurrentLocation = "Alley";
      Console.Clear();
      Console.WriteLine($"You are at the -{lists.CurrentLocation}-");
      Thread.Sleep(500);
      Console.WriteLine("");
      Console.WriteLine("--What do you want to do?--");
      Console.WriteLine("1. Travel to a different location");
      Console.WriteLine("2. Check status");
      Console.WriteLine("3. ");
      Console.WriteLine("4. ");
      try
      {
        lists.ModifyInt("Input", Convert.ToInt32(Console.ReadLine()));
      }
      catch
      {
        Console.Clear();
        Console.WriteLine("Invalid input");
        Thread.Sleep(1500);
        Alley();
      }

      switch (lists.GetValue("Input"))
      {
        case 1:
        {
          locations.LocationSelector();
          break;
        }
        case 2:
        {
          Console.Clear();
          status?.ShowStatus();
          continue;
        }
        case 3:
        {
          continue;
        }
        case 4:
        {
          continue;
        }
        default:
        {
          Console.Clear();
          Console.Write("Invalid input");
          Thread.Sleep(1500);
          continue;
        }
      }

      break;
    }
  }
}