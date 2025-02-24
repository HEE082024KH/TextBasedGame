namespace TextBasedGame.classes;

public class Locations
{
  private readonly Start start = new();
  public Status? Status;
  public required Lists Lists;

  // Define locations
  private GateLocation? gate;
  private ApartmentsLocation? apartments;
  private SubwayEntrance? subway;
  private ShopLocation? shop;
  private ArtGallery? art;
  private OfficeBuilding? office;
  private PavilionLocation? pavilion;
  private AbandonedWarehouse? warehouse;
  private BombShelter? shelter;
  private FountainLocation? fountain;
  private AlleyLocation? alley;
  private ShackLocation? shack;

  public void InitializeClasses()
  {
    Lists = new Lists(this);
    Status = new Status(this, Lists);
    gate = new GateLocation(this, Lists);
    apartments = new ApartmentsLocation(this, Lists);
    subway = new SubwayEntrance(this, Lists);
    shop = new ShopLocation(this, Lists);
    art = new ArtGallery(this, Lists);
    office = new OfficeBuilding(this, Lists);
    pavilion = new PavilionLocation(this, Lists);
    warehouse = new AbandonedWarehouse(this, Lists);
    shelter = new BombShelter(this, Lists);
    fountain = new FountainLocation(this, Lists);
    alley = new AlleyLocation(this, Lists);
    shack = new ShackLocation(this, Lists);
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
    Console.Clear();
    if (start.newGame)
    {
      start.NewGame();
      start.newGame = false;
    }

    Console.Clear();
    Map.ShowMap();
    Console.WriteLine("Where do you want to travel to?");
    Console.Write(">");
    try
    {
      Lists.ModifyInt("Input", Convert.ToInt32(Console.ReadLine()));
    }
    catch
    {
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
        gate?.Gate();
        break;
      case 2:
        apartments?.Apartments();
        break;
      case 3:
        subway?.Subway();
        break;
      case 4:
        shop?.Shop();
        break;
      case 5:
        art?.Art();
        break;
      case 6:
        office?.Office();
        break;
      case 7:
        pavilion?.Pavilion();
        break;
      case 8:
        warehouse?.Warehouse();
        break;
      case 9:
        shelter?.Shelter();
        break;
      case 10:
        fountain?.Fountain();
        break;
      case 11:
        alley?.Alley();
        break;
      case 12:
        shack?.Shack();
        break;
      default:
        Console.Clear();
        Console.WriteLine("Invalid input");
        Thread.Sleep(1500);
        break;
    }
  }
}