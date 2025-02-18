namespace TextBasedGame.classes;

public class Controller
{
  private readonly Locations locations = new();

  public void Run()
  {
    // Load all items/variables.
    locations.InitializeLocations();
    locations.LocationSelector();
  }

  public void MainMenu()
  {
    Console.Clear();
    Console.WriteLine("Start Game");
    Console.WriteLine("");
    Console.WriteLine("Check Achievements");
    Console.WriteLine("");
    Console.WriteLine("Exit Game");
    try
    {
      locations.ItemInput = Console.ReadLine()?.ToLower();
    }
    catch
    {
      Console.Clear();
      Console.WriteLine("Invalid Input");
      Thread.Sleep(1500);
      MainMenu();
    }

    switch (locations.ItemInput)
    {
      case "1":
      case "start":
      case "startgame":
      case "start game":
        locations.InitializeLocations();
        locations.LocationSelector();
        break;
      case "2":
      case "check":
      case "achievements":
        break;
      case "3":
      case "exit":
      case "exitgame":
      case "exit game":
        Environment.Exit(0);
        break;
      default:
        Console.Clear();
        Console.WriteLine("Invalid Input");
        Thread.Sleep(1500);
        MainMenu();
        break;
    }
  }
}