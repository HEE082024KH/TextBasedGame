public class Locations
{
    Map map = new();
    Start start = new();
    GateLocation gate = new();
    ApartmentsLocation apartments = new();
    SubwayEntrance subway = new();
    ShopLocation shop = new();
    ArtGallery art = new();
    OfficeBuilding office = new();
    PavilionLocation pavilion = new();
    public string? currentLocation;
    public int? input;
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
        input = Convert.ToInt32(Console.ReadLine());
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
                AbandonedWarehouse();
                break;
            case 9:
                currentLocation = "Bomb Shelter";
                BombShelter();
                break;
            case 10:
                currentLocation = "Fountain";
                Fountain();
                break;
            case 11:
                currentLocation = "Alley";
                Alley();
                break;
            case 12:
                currentLocation = "Shack";
                Shack();
                break;
            default:
                Console.WriteLine("Invalid input");
                break;
        }
    }


    public void AbandonedWarehouse()
    {
        currentLocation = "AbandonedWarehouse";
        Console.Clear();
        Console.WriteLine($"You are at the  -{currentLocation}-");
        Thread.Sleep(500);
        Console.WriteLine("---What do you want to do?---");
        Console.WriteLine("1. Travel to a different location");
        Console.WriteLine("2. Check inventory");
        Console.WriteLine("3. Exit through the gate");
        Console.WriteLine("4. Look around for anything useful");
        try
        {
            input = Convert.ToInt32(Console.ReadLine());
        }
        catch
        {
        }
        switch (locations.input)
        {
            case 1:
                {
                    locations.LocationSelector();
                    break;
                }
            case 2:
                {
                    Console.Clear();
                    Console.WriteLine("Press -enter- to go back");
                    inventory.openInventory();
                    Console.ReadLine();
                    break;
                }
            case 3:
                {
                    break;
                }
            case 4:
                {
                    break;
                }
            default:
                {
                    Console.Clear();
                    Console.Write("---Invalid input---");
                    Thread.Sleep(1000);
                    break;
                }
        }
    }
    public void BombShelter()
    {
        currentLocation = "BombShelter";
        Console.Clear();
        Console.WriteLine($"You are at the  -{currentLocation}-");
        Thread.Sleep(500);
        Console.WriteLine("---What do you want to do?---");
        Console.WriteLine("1. Travel to a different location");
        Console.WriteLine("2. Check inventory");
        Console.WriteLine("3. Exit through the gate");
        Console.WriteLine("4. Look around for anything useful");
        try
        {
            input = Convert.ToInt32(Console.ReadLine());
        }
        catch
        {
        }
        switch (locations.input)
        {
            case 1:
                {
                    locations.LocationSelector();
                    break;
                }
            case 2:
                {
                    Console.Clear();
                    Console.WriteLine("Press -enter- to go back");
                    inventory.openInventory();
                    Console.ReadLine();
                    break;
                }
            case 3:
                {
                    break;
                }
            case 4:
                {
                    break;
                }
            default:
                {
                    Console.Clear();
                    Console.Write("---Invalid input---");
                    Thread.Sleep(1000);
                    break;
                }
        }
    }
    public void Fountain()
    {
        currentLocation = "Fountain";
        Console.Clear();
        Console.WriteLine($"You are at the  -{currentLocation}-");
        Thread.Sleep(500);
        Console.WriteLine("---What do you want to do?---");
        Console.WriteLine("1. Travel to a different location");
        Console.WriteLine("2. Check inventory");
        Console.WriteLine("3. Exit through the gate");
        Console.WriteLine("4. Look around for anything useful");
        try
        {
            input = Convert.ToInt32(Console.ReadLine());
        }
        catch
        {
        }
        switch (locations.input)
        {
            case 1:
                {
                    locations.LocationSelector();
                    break;
                }
            case 2:
                {
                    Console.Clear();
                    Console.WriteLine("Press -enter- to go back");
                    inventory.openInventory();
                    Console.ReadLine();
                    break;
                }
            case 3:
                {
                    break;
                }
            case 4:
                {
                    break;
                }
            default:
                {
                    Console.Clear();
                    Console.Write("---Invalid input---");
                    Thread.Sleep(1000);
                    break;
                }
        }
    }
    public void Alley()
    {
        currentLocation = "Alley";
        Console.Clear();
        Console.WriteLine($"You are at the  -{currentLocation}-");
        Thread.Sleep(500);
        Console.WriteLine("---What do you want to do?---");
        Console.WriteLine("1. Travel to a different location");
        Console.WriteLine("2. Check inventory");
        Console.WriteLine("3. Exit through the gate");
        Console.WriteLine("4. Look around for anything useful");
        try
        {
            input = Convert.ToInt32(Console.ReadLine());
        }
        catch
        {
        }
        switch (locations.input)
        {
            case 1:
                {
                    locations.LocationSelector();
                    break;
                }
            case 2:
                {
                    Console.Clear();
                    Console.WriteLine("Press -enter- to go back");
                    inventory.openInventory();
                    Console.ReadLine();
                    break;
                }
            case 3:
                {
                    break;
                }
            case 4:
                {
                    break;
                }
            default:
                {
                    Console.Clear();
                    Console.Write("---Invalid input---");
                    Thread.Sleep(1000);
                    break;
                }
        }
    }
    public void Shack()
    {
        currentLocation = "Shack";
        Console.Clear();
        Console.WriteLine($"You are at the  -{currentLocation}-");
        Thread.Sleep(500);
        Console.WriteLine("---What do you want to do?---");
        Console.WriteLine("1. Travel to a different location");
        Console.WriteLine("2. Check inventory");
        Console.WriteLine("3. Exit through the gate");
        Console.WriteLine("4. Look around for anything useful");
        try
        {
            input = Convert.ToInt32(Console.ReadLine());
        }
        catch
        {
        }
        switch (locations.input)
        {
            case 1:
                {
                    locations.LocationSelector();
                    break;
                }
            case 2:
                {
                    Console.Clear();
                    Console.WriteLine("Press -enter- to go back");
                    inventory.openInventory();
                    Console.ReadLine();
                    break;
                }
            case 3:
                {
                    break;
                }
            case 4:
                {
                    break;
                }
            default:
                {
                    Console.Clear();
                    Console.Write("---Invalid input---");
                    Thread.Sleep(1000);
                    break;
                }
        }
    }
}