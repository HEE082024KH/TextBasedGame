public class ShackLocation
{
  Locations locations = new();
  Status inventory = new();
  Items items = new();
  public void Shack()
  {
    locations.currentLocation = "Shack";
    Console.Clear();
    Console.WriteLine($"You are at the  -{locations.currentLocation}-");
    Thread.Sleep(500);
    Console.WriteLine("---What do you want to do?---");
    Console.WriteLine("1. Travel to a different location");
    Console.WriteLine("2. Check inventory");
    Console.WriteLine("3. Exit through the gate");
    Console.WriteLine("4. Look around for anything useful");
    try
    {
      locations.input = Convert.ToInt32(Console.ReadLine());
    }
    catch
    {
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
          Console.WriteLine("Press -enter- to go back");
          inventory.showStatus();
          Console.ReadLine();
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
          break;
        }
    }
  }
}