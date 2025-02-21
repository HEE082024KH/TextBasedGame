namespace TextBasedGame.classes;

public class Locations
{
  private readonly Start start = new();
  public readonly Items Items = new();
  public Status? Status;
  public Lists? Lists;
  public string? CurrentLocation;
  public int? Input;
  public string? ItemInput;

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
    Status = new Status(this, Items);
    gate = new GateLocation(this, Lists);
    apartments = new ApartmentsLocation(this, Lists);
    subway = new SubwayEntrance(this);
    shop = new ShopLocation(this);
    art = new ArtGallery(this);
    office = new OfficeBuilding(this);
    pavilion = new PavilionLocation(this);
    warehouse = new AbandonedWarehouse(this);
    shelter = new BombShelter(this, Lists);
    fountain = new FountainLocation(this);
    alley = new AlleyLocation(this);
    shack = new ShackLocation(this);
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
      Input = Convert.ToInt32(Console.ReadLine());
    }
    catch
    {
      Console.WriteLine("Invalid input");
      Thread.Sleep(1500);
      Console.Clear();
      LocationSelector();
    }

    switch (Input)
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
        CurrentLocation = "Gate";
        gate?.Gate();
        break;
      case 2:
        CurrentLocation = "Apartments";
        apartments?.Apartments();
        break;
      case 3:
        CurrentLocation = "Subway Entrance";
        subway?.Subway();
        break;
      case 4:
        CurrentLocation = "Shop";
        shop?.Shop();
        break;
      case 5:
        CurrentLocation = "Art Gallery";
        art?.Art();
        break;
      case 6:
        CurrentLocation = "Office Building";
        office?.Office();
        break;
      case 7:
        CurrentLocation = "Pavilion";
        pavilion?.Pavilion();
        break;
      case 8:
        CurrentLocation = "Abandoned Warehouse";
        warehouse?.Warehouse();
        break;
      case 9:
        CurrentLocation = "Bomb Shelter";
        shelter?.Shelter();
        break;
      case 10:
        CurrentLocation = "Fountain";
        fountain?.Fountain();
        break;
      case 11:
        CurrentLocation = "Alley";
        alley?.Alley();
        break;
      case 12:
        CurrentLocation = "Shack";
        shack?.Shack();
        break;
      default:
        Console.WriteLine("Invalid input");
        break;
    }
  }
}