public class Controller
{
  Locations locations = new();
  Map map = new();

  public void Run()
  {
    Console.Clear();
    locations.LocationSelector();
  }
}