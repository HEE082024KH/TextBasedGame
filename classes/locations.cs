namespace TextBasedGame.classes;

public class Locations
{
  Start start = new();
  public Items items;
  public string? CurrentLocation;
  public int? Input;
  public string? ItemInput;

  // Define locations
  GateLocation gate;
  ApartmentsLocation apartments;
  SubwayEntrance subway;
  ShopLocation shop;
  ArtGallery art;
  OfficeBuilding office;
  PavilionLocation pavilion;
  AbandonedWarehouse warehouse;
  BombShelter shelter;
  FountainLocation fountain;
  AlleyLocation alley;
  ShackLocation shack;

  public void InitializeLocations()
  {
    gate = new(this);
    apartments = new(this);
    subway = new(this);
    shop = new(this);
    art = new(this);
    office = new(this);
    pavilion = new(this);
    warehouse = new(this);
    shelter = new(this);
    fountain = new(this);
    alley = new((Locations)this);
    shack = new(this);
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
      case 1:
        CurrentLocation = "Gate";
        gate.Gate();
        break;
      case 2:
        CurrentLocation = "Apartments";
        apartments.Apartments();
        break;
      case 3:
        CurrentLocation = "Subway Entrance";
        subway.Subway();
        break;
      case 4:
        CurrentLocation = "Shop";
        shop.Shop();
        break;
      case 5:
        CurrentLocation = "Art Gallery";
        art.Art();
        break;
      case 6:
        CurrentLocation = "Office Building";
        office.Office();
        break;
      case 7:
        CurrentLocation = "Pavilion";
        pavilion.Pavilion();
        break;
      case 8:
        CurrentLocation = "Abandoned Warehouse";
        warehouse.Warehouse();
        break;
      case 9:
        CurrentLocation = "Bomb Shelter";
        shelter.Shelter();
        break;
      case 10:
        CurrentLocation = "Fountain";
        fountain.Fountain();
        break;
      case 11:
        CurrentLocation = "Alley";
        alley.Alley();
        break;
      case 12:
        CurrentLocation = "Shack";
        shack.Shack();
        break;
      default:
        Console.WriteLine("Invalid input");
        break;
    }
  }
}