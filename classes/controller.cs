public class Controller
{
  Locations locations = new();

  public void Run()
  {
    locations.InitializeLocations();
    locations.LocationSelector();
  }
}