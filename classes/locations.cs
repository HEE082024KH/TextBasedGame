namespace TextBasedGame.classes;

public class Locations
{
  private readonly Start start = new();
  public Status? Status;
  public Lists Lists;

  // Define locations
  private GateLocation? gate;
  private ApartmentsLocation? apartments;
  private SubwayEntrance? subway;
  private ShopLocation? shop;
  private PavilionLocation? pavilion;
  private BombShelter? shelter;
  private FountainLocation? fountain;
  private AlleyLocation? alley;
  private ShackLocation? shack;

  public void InitializeClasses()
  {
    Lists = new Lists(this);
    Status = new Status(this, Lists);
    gate = new GateLocation(this, Lists, Status);
    apartments = new ApartmentsLocation(this, Lists, Status);
    subway = new SubwayEntrance(this, Lists, Status);
    shop = new ShopLocation(this, Lists, Status);
    pavilion = new PavilionLocation(this, Lists, Status);
    shelter = new BombShelter(this, Lists, Status);
    fountain = new FountainLocation(this, Lists, Status);
    alley = new AlleyLocation(this, Lists, Status);
    shack = new ShackLocation(this, Lists, Status);
  }

  public void MainMenu()
  {
    while (true)
    {
      Console.Clear();
      Structures.Computer();
      Console.WriteLine("");
      Console.WriteLine("|~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~|");
      Console.WriteLine("|                                  |");
      Console.WriteLine("|    1. Start Game                 |");
      Console.WriteLine("|                                  |");
      Console.WriteLine("|    2. Check Achievements         |");
      Console.WriteLine("|                                  |");
      Console.WriteLine("|    3. Exit Game                  |");
      Console.WriteLine("|                                  |");
      Console.WriteLine("|~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~|");
      Console.WriteLine("");
      try
      {
        Lists.ModifyInt("Input", Convert.ToInt32(Console.ReadLine()));
      }
      catch
      {
        Console.Clear();
        Console.WriteLine("Invalid Input");
        Thread.Sleep(1500);
        MainMenu();
      }

      switch (Lists.GetValue("Input"))
      {
        case 1:
          InitializeClasses();
          LocationSelector();
          break;
        case 2:
          break;
        case 3:
          Console.WriteLine("Quitting...");
          Thread.Sleep(2000);
          Environment.Exit(0);
          break;
        default:
          Console.Clear();
          Console.WriteLine("Invalid Input");
          Thread.Sleep(1500);
          continue;
      }

      break;
    }
  }

  public void LocationSelector()
  {
    while (true)
    {
      Console.Clear();
      if (start.newGame)
      {
        start.NewGame();
        start.newGame = false;
      }

      Console.Clear();
      Map.ShowMap();
      Console.WriteLine("--Where do you want to travel to?--");
      Console.Write(">");
      try
      {
        Lists.ModifyInt("Input", Convert.ToInt32(Console.ReadLine()));
      }
      catch
      {
        Console.Clear();
        Console.WriteLine("Invalid input");
        Thread.Sleep(1500);
        Console.Clear();
        LocationSelector();
      }

      switch (Lists.GetValue("Input"))
      {
        case 99: // Testing lists
          Lists lists = new(this);
          // lists.AddItem("Money", 50, false);
          // lists.AddItem("Bandages", 3, true);
          // lists.AddItem("Alcohol", 1, true);
          // lists.AddItem("Coin", 0, true);
          // lists.AddItem("apartments", -1, true);
          // lists.DisplayExistingItemsAndAmount();
          // Console.WriteLine("");
          lists.DisplayInventory();
          Console.ReadLine();
          break;
        case 1:
          shack?.Shack();
          break;
        case 2:
          subway?.Subway();
          break;
        case 3:
          pavilion?.Pavilion();
          break;
        case 4:
          apartments?.Apartments();
          break;
        case 5:
          fountain?.Fountain();
          break;
        case 6:
          shelter?.Shelter();
          break;
        case 7:
          gate?.Gate();
          break;
        case 8:
          alley?.Alley();
          break;
        case 9:
          shop?.Shop();
          break;
        default:
          Console.Clear();
          Console.WriteLine("Invalid input");
          Thread.Sleep(1500);
          continue;
      }

      break;
    }
  }
}