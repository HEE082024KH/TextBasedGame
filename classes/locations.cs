public class Locations
{
    Map map = new();
    Start start = new();
    GateLocation gate = new();
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
                Apartments();
                break;
            case 3:
                currentLocation = "Subway Entrance";
                SubwayEntrance();
                break;
            case 4:
                currentLocation = "Shop";
                Shop();
                break;
            case 5:
                currentLocation = "Art Gallery";
                ArtGallery();
                break;
            case 6:
                currentLocation = "Office Building";
                OfficeBuilding();
                break;
            case 7:
                currentLocation = "Pavilion";
                Pavilion();
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
    public void SubwayEntrance()
    {
        currentLocation = "SubwayEntrance";
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
        while (input != 1 || input != 2 || input != 3 || input != 4)
        {
            if (input == 1)
            {
                Console.Clear();
                map.ShowMap();
                input = Convert.ToInt32(Console.ReadLine());
                LocationSelector();
            }
            else if (input == 2)
            {
                Console.Clear();
                Console.WriteLine("Press -enter- to go back");
                inventory.openInventory();
                Console.ReadLine();
            }
            else if (input == 3)
            {
            }
            else if (input == 4)
            {
            }
            else
            {
                Console.Clear();
                Console.Write("---Invalid input---");
                Thread.Sleep(1000);
            }
        }
    }
    public void Shop()
    {
        currentLocation = "Shop";
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
        while (input != 1 || input != 2 || input != 3 || input != 4)
        {
            if (input == 1)
            {
                Console.Clear();
                map.ShowMap();
                input = Convert.ToInt32(Console.ReadLine());
                LocationSelector();
            }
            else if (input == 2)
            {
                Console.Clear();
                Console.WriteLine("Press -enter- to go back");
                inventory.openInventory();
                Console.ReadLine();
            }
            else if (input == 3)
            {
            }
            else if (input == 4)
            {
            }
            else
            {
                Console.Clear();
                Console.Write("---Invalid input---");
                Thread.Sleep(1000);
            }
        }
    }
    public void ArtGallery()
    {
        currentLocation = "ArtGallery";
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
        while (input != 1 || input != 2 || input != 3 || input != 4)
        {
            if (input == 1)
            {
                Console.Clear();
                map.ShowMap();
                input = Convert.ToInt32(Console.ReadLine());
                LocationSelector();
            }
            else if (input == 2)
            {
                Console.Clear();
                Console.WriteLine("Press -enter- to go back");
                inventory.openInventory();
                Console.ReadLine();
            }
            else if (input == 3)
            {
            }
            else if (input == 4)
            {
            }
            else
            {
                Console.Clear();
                Console.Write("---Invalid input---");
                Thread.Sleep(1000);
            }
        }
    }
    public void OfficeBuilding()
    {
        currentLocation = "OfficeBuilding";
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
        while (input != 1 || input != 2 || input != 3 || input != 4)
        {
            if (input == 1)
            {
                Console.Clear();
                map.ShowMap();
                input = Convert.ToInt32(Console.ReadLine());
                LocationSelector();
            }
            else if (input == 2)
            {
                Console.Clear();
                Console.WriteLine("Press -enter- to go back");
                inventory.openInventory();
                Console.ReadLine();
            }
            else if (input == 3)
            {
            }
            else if (input == 4)
            {
            }
            else
            {
                Console.Clear();
                Console.Write("---Invalid input---");
                Thread.Sleep(1000);
            }
        }
    }
    public void Pavilion()
    {
        currentLocation = "Pavilion";
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
        while (input != 1 || input != 2 || input != 3 || input != 4)
        {
            if (input == 1)
            {
                Console.Clear();
                map.ShowMap();
                input = Convert.ToInt32(Console.ReadLine());
                LocationSelector();
            }
            else if (input == 2)
            {
                Console.Clear();
                Console.WriteLine("Press -enter- to go back");
                inventory.openInventory();
                Console.ReadLine();
            }
            else if (input == 3)
            {
            }
            else if (input == 4)
            {
            }
            else
            {
                Console.Clear();
                Console.Write("---Invalid input---");
                Thread.Sleep(1000);
            }
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
        while (input != 1 || input != 2 || input != 3 || input != 4)
        {
            if (input == 1)
            {
                Console.Clear();
                map.ShowMap();
                input = Convert.ToInt32(Console.ReadLine());
                LocationSelector();
            }
            else if (input == 2)
            {
                Console.Clear();
                Console.WriteLine("Press -enter- to go back");
                inventory.openInventory();
                Console.ReadLine();
            }
            else if (input == 3)
            {
            }
            else if (input == 4)
            {
            }
            else
            {
                Console.Clear();
                Console.Write("---Invalid input---");
                Thread.Sleep(1000);
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
        while (input != 1 || input != 2 || input != 3 || input != 4)
        {
            if (input == 1)
            {
                Console.Clear();
                map.ShowMap();
                input = Convert.ToInt32(Console.ReadLine());
                LocationSelector();
            }
            else if (input == 2)
            {
                Console.Clear();
                Console.WriteLine("Press -enter- to go back");
                inventory.openInventory();
                Console.ReadLine();
            }
            else if (input == 3)
            {
            }
            else if (input == 4)
            {
            }
            else
            {
                Console.Clear();
                Console.Write("---Invalid input---");
                Thread.Sleep(1000);
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
        while (input != 1 || input != 2 || input != 3 || input != 4)
        {
            if (input == 1)
            {
                Console.Clear();
                map.ShowMap();
                input = Convert.ToInt32(Console.ReadLine());
                LocationSelector();
            }
            else if (input == 2)
            {
                Console.Clear();
                Console.WriteLine("Press -enter- to go back");
                inventory.openInventory();
                Console.ReadLine();
            }
            else if (input == 3)
            {
            }
            else if (input == 4)
            {
            }
            else
            {
                Console.Clear();
                Console.Write("---Invalid input---");
                Thread.Sleep(1000);
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
        while (input != 1 || input != 2 || input != 3 || input != 4)
        {
            if (input == 1)
            {
                Console.Clear();
                map.ShowMap();
                input = Convert.ToInt32(Console.ReadLine());
                LocationSelector();
            }
            else if (input == 2)
            {
                Console.Clear();
                Console.WriteLine("Press -enter- to go back");
                inventory.openInventory();
                Console.ReadLine();
            }
            else if (input == 3)
            {
            }
            else if (input == 4)
            {
            }
            else
            {
                Console.Clear();
                Console.Write("---Invalid input---");
                Thread.Sleep(1000);
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
        while (input != 1 || input != 2 || input != 3 || input != 4)
        {
            if (input == 1)
            {
                Console.Clear();
                map.ShowMap();
                input = Convert.ToInt32(Console.ReadLine());
                LocationSelector();
            }
            else if (input == 2)
            {
                Console.Clear();
                Console.WriteLine("Press -enter- to go back");
                inventory.openInventory();
                Console.ReadLine();
            }
            else if (input == 3)
            {
            }
            else if (input == 4)
            {
            }
            else
            {
                Console.Clear();
                Console.Write("---Invalid input---");
                Thread.Sleep(1000);
            }
        }
    }
}