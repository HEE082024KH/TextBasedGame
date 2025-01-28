public class Controller
{
  Locations locations = new();

  public void Run()
  {
    locations.InitializeLocations();
    Console.Clear();
    locations.LocationSelector();
  }
}