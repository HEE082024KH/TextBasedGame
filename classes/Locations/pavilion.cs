public class PavilionLocation(Locations locations)
{
  private readonly Items items = new(locations, locations.items);
  private readonly Status status = new(locations, locations.items);

  public void Pavilion()
  {
    locations.CurrentLocation = "Pavilion";
    Console.Clear();
    Console.WriteLine($"You are at the  -{locations.CurrentLocation}-");
    Thread.Sleep(500);
    Console.WriteLine("---What do you want to do?---");
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
      Pavilion();
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
        Pavilion();
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
        Pavilion();
        break;
      }
    }
  }
}