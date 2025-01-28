public class Locations
{
    Map map = new();
    Start start = new();
    public Items items = new();
    public Status inventory = new();
    public string? currentLocation;
    public int? input;

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
        alley = new(this);
        shack = new(this);
    }

    public void LocationSelector()
    {
        if (start.newGame == true)
        {
            start.NewGame();
            start.newGame = false;
        }
        Console.Clear();
        map.ShowMap();
        Console.WriteLine("Where do you want to travel to?");
        Console.Write(">");
        try
        {
            input = Convert.ToInt32(Console.ReadLine());
        }
        catch
        {
            Console.WriteLine("Please enter a number!");
        }
        switch (input)
        {
            case 1:
                currentLocation = "Gate";
                gate.Gate();
                break;
            case 2:
                currentLocation = "Apartments";
                apartments.Apartments();
                break;
            case 3:
                currentLocation = "Subway Entrance";
                subway.Subway();
                break;
            case 4:
                currentLocation = "Shop";
                shop.Shop();
                break;
            case 5:
                currentLocation = "Art Gallery";
                art.Art();
                break;
            case 6:
                currentLocation = "Office Building";
                office.Office();
                break;
            case 7:
                currentLocation = "Pavilion";
                pavilion.Pavilion();
                break;
            case 8:
                currentLocation = "Abandoned Warehouse";
                warehouse.Warehouse();
                break;
            case 9:
                currentLocation = "Bomb Shelter";
                shelter.Shelter();
                break;
            case 10:
                currentLocation = "Fountain";
                fountain.Fountain();
                break;
            case 11:
                currentLocation = "Alley";
                alley.Alley();
                break;
            case 12:
                currentLocation = "Shack";
                shack.Shack();
                break;
            default:
                Console.WriteLine("Invalid input");
                break;
        }
    }
}