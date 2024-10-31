public class Controller
{
  Locations locations = new();

  public void Run()
  {
    Console.Clear();
    locations.LocationSelector();
  }
}