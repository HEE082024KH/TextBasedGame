public class Locations
{
    Map map = new();
    Start start = new();
    public Items items = new();
    public Status inventory;
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
                goto gate;
            case 2:
                currentLocation = "Apartments";
                goto apartments;
            case 3:
                currentLocation = "Subway Entrance";
                goto subway;
            case 4:
                currentLocation = "Shop";
                goto shop;
            case 5:
                currentLocation = "Art Gallery";
                goto art;
            case 6:
                currentLocation = "Office Building";
                goto office;
            case 7:
                currentLocation = "Pavilion";
                goto pavilion;
            case 8:
                currentLocation = "Abandoned Warehouse";
                goto warehouse;
            case 9:
                currentLocation = "Bomb Shelter";
                goto shelter;
            case 10:
                currentLocation = "Fountain";
                goto fountain;
            case 11:
                currentLocation = "Alley";
                goto alley;
            case 12:
                currentLocation = "Shack";
                goto shack;
            default:
                Console.WriteLine("Invalid input");
                break;
        }

    gate:
        gate.Gate();
    apartments:
        apartments.Apartments();
    subway:
        subway.Subway();
    shop:
        shop.Shop();
    art:
        art.Art();
    office:
        office.Office();
    pavilion:
        pavilion.Pavilion();
    warehouse:
        warehouse.Warehouse();
    shelter:
        shelter.Shelter();
    fountain:
        fountain.Fountain();
    alley:
        alley.Alley();
    shack:
        shack.Shack();
    }
}