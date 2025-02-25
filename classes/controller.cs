namespace TextBasedGame.classes;

public class Controller
{
  private readonly Locations locations = new Locations();

  public void Run()
  {
    // Load all items/variables.
    locations.InitializeClasses();
    locations.LocationSelector();
  }
}