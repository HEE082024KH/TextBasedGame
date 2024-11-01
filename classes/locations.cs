public class Locations
{
    Map map = new();
    Start start = new();
    public string? currentLocation;
    public int? input;

    // Define locations
    GateLocation gate = new();
    ApartmentsLocation apartments = new();
    SubwayEntrance subway = new();
    ShopLocation shop = new();
    ArtGallery art = new();
    OfficeBuilding office = new();
    PavilionLocation pavilion = new();
    AbandonedWarehouse warehouse = new();
    BombShelter shelter = new();
    FountainLocation fountain = new();
    AlleyLocation alley = new();
    ShackLocation shack = new();

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