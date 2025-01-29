public class AlleyLocation(Locations locations)
{
  private Locations locations = locations;
  Status inventory = locations.inventory;
  Items items = locations.items;
  public void Alley()
  {
    locations.currentLocation = "Alley";
    Console.Clear();
    Console.WriteLine($"You are at the  -{locations.currentLocation}-");
    Thread.Sleep(500);
    Console.WriteLine("---What do you want to do?---");
    Console.WriteLine("1. Travel to a different location");
    Console.WriteLine("2. Check status");
    Console.WriteLine("3. ");
    Console.WriteLine("4. ");
    try
    {
      locations.input = Convert.ToInt32(Console.ReadLine());
    }
    catch
    {
      Console.WriteLine("Invalid input");
    }
    switch (locations.input)
    {
      case 1:
        {
          locations.LocationSelector();
          break;
        }
      case 2:
        {
          Console.Clear();
          inventory.ShowStatus();
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
          Console.Write("---Invalid input---");
          Thread.Sleep(1000);
          Alley();
          break;
        }
    }
  }
}