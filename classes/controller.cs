public class Controller
{
  Locations locations = new();

  public void Run()
  {
    Console.SetWindowSize(Console.LargestWindowWidth, Console.LargestWindowHeight);
    locations.InitializeLocations();
    locations.LocationSelector();
  }
}