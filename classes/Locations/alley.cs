using TextBasedGame.classes;

public class AlleyLocation(Locations locations)
{
  private readonly Items items = locations.Items;
  private readonly Status status = locations.Status;

  public void Alley()
  {
    locations.CurrentLocation = "Alley";
    Console.Clear();
    Console.WriteLine($"You are at the -{locations.CurrentLocation}-");
    Thread.Sleep(500);
    Console.WriteLine("");
    Console.WriteLine("--What do you want to do?--");
    Console.WriteLine("1. Travel to a different location");
    Console.WriteLine("2. Check status");
    Console.WriteLine("3. ");
    Console.WriteLine("4. ");
    try
    {
      locations.Input = Convert.ToInt32(Console.ReadLine());
    }
    catch
    {
      Console.Clear();
      Console.WriteLine("Invalid input");
      Thread.Sleep(1500);
      Alley();
    }

    switch (locations.Input)
    {
      case 1:
      {
        locations.LocationSelector();
        break;
      }
      case 2:
      {
        Console.Clear();
        status.ShowStatus();
        Alley();
        break;
      }
      case 3:
      {
        break;
      }
      case 4:
      {
        break;
      }
      default:
      {
        Console.Clear();
        Console.Write("Invalid input");
        Thread.Sleep(1500);
        Alley();
        break;
      }
    }
  }
}