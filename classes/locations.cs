public class Locations
{
    Items items = new();
    Map map = new();
    Start start = new();
    Inventory inventory = new();
    public string? currentLocation;
    public int? input;
    public bool gateUnlocked = false;
    public void LocationSelector()
    {
        if (start.newGame == true)
        {
            start.NewGame();
            start.newGame = false;
            map.ShowMap();
            Console.WriteLine("Where do you want to travel to?");
            Console.Write(">");
            input = Convert.ToInt32(Console.ReadLine());
        }
        switch (input)
        {
            case 1:
                currentLocation = "Gate";
                Gate();
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
    public void Gate()
    {
        currentLocation = "Gate";
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
            Gate();
        }
        while (input != 1 || input != 2 || input != 3 || input != 4)
        {
            if (input == 1)
            {
                Console.Clear();
                map.ShowMap();
                Console.WriteLine("Where do you want to travel to?");
                input = Convert.ToInt32(Console.ReadLine());
                LocationSelector();
            }
            else if (input == 2)
            {
                Console.Clear();
                Console.WriteLine("Press -enter- to go back");
                inventory.openInventory();
                Console.ReadLine();
                Gate();
            }
            else if (input == 3)
            {
                if (gateUnlocked == true)
                {
                    Console.Clear();
                    Console.WriteLine("You push open the heavy gate");
                    Thread.Sleep(3000);
                    Console.Clear();
                    Console.WriteLine("It screeches loudly as it scrapes along the ground");
                    Thread.Sleep(3000);
                    Console.Clear();
                    Console.WriteLine("Then silence...");
                    Thread.Sleep(2000);
                    Console.Clear();
                    Console.WriteLine("You look back one last time before leaving");
                    Thread.Sleep(5000);
                    Console.Clear();
                    Console.WriteLine("CONGRATULATIONS, YOU MANAGED TO ESCAPE!");
                    Thread.Sleep(3000);
                    Console.WriteLine("Press a to check achievements unlocked, e to exit game");
                    string? endGame = Console.ReadLine();
                    while (endGame != "a" || endGame != "e")
                    {
                        if (endGame == "a")
                        {
                            Console.WriteLine("Achievements Unlocked:");
                        }
                        else if (endGame == "e")
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Press a to check achievements unlocked, e to exit game");
                            endGame = Console.ReadLine();
                        }
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("The gate is locked");
                    Thread.Sleep(1500);
                    Console.WriteLine("I need to find some way to unlock the gate");
                    Thread.Sleep(3500);
                    Gate();
                }
            }
            else if (input == 4)
            {
                if (items.hasFlashlight == true)
                {
                    Console.Clear();
                    Console.WriteLine("You use your flashlight to look around");
                    Thread.Sleep(1500);
                    Console.WriteLine("You found a 'Hairpin'");
                    items.hasHairpin = true;
                    Thread.Sleep(3500);
                    Gate();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("You struggle to see anything in the dark");
                    Thread.Sleep(1500);
                    Console.WriteLine("If only I had a flashlight");
                    Thread.Sleep(3500);
                    Gate();
                }
            }
            else
            {
                Console.Clear();
                Console.Write("---Invalid input---");
                Thread.Sleep(1000);
                Gate();
            }
        }
    }
    public void Apartments()
    {
        currentLocation = "Apartments";
        Console.Clear();
        Console.WriteLine($"You are at the  -{currentLocation}-");
        Thread.Sleep(500);
        Console.WriteLine("---What do you want to do?---");
        Console.WriteLine("1. Travel to a different location");
        Console.WriteLine("2. Check inventory");
        Console.WriteLine("3. Look around outside");
        Console.WriteLine("4. Go in the front door");
        Console.WriteLine("5. Walk around to the back door");
        try
        {
            input = Convert.ToInt32(Console.ReadLine());
        }
        catch
        {
            Apartments();
        }
        switch (input)
        {
            case 1:
                {
                    Console.Clear();
                    map.ShowMap();
                    input = Convert.ToInt32(Console.ReadLine());
                    LocationSelector();
                    break;
                }
            case 2:
                {
                    Console.Clear();
                    Console.WriteLine("Press -enter- to go back");
                    inventory.openInventory();
                    Console.ReadLine();
                    Apartments();
                    break;
                }
            case 3:
                {
                    Console.Clear();
                    Console.WriteLine("There's a few bags of trash scattered along the walls");
                    Thread.Sleep(2000);
                    Console.WriteLine("---What do you want to do?---");
                    Console.WriteLine("1. Search the bags");
                    Console.WriteLine("2. Leave them alone");
                    try
                    {
                        input = Convert.ToInt32(Console.ReadLine());
                    }
                    catch
                    {
                        Apartments();
                    }
                    switch (input)
                    {
                        case 1:
                            {
                                Console.WriteLine("You rummage through the bags, looking for anything of use.");
                                Thread.Sleep(2000);
                                Console.WriteLine("Looking through one of the bags, you cut your hand on a sharp object");
                                Thread.Sleep(2500);
                                items.Wounds();
                                break;
                            }
                        case 2:
                            {
                                break;
                            }
                    }
                    break;
                }
            case 4:
                {
                    break;
                }
            case 5:
                {
                    break;
                }
            default:
                {
                    Console.Clear();
                    Console.Write("---Invalid input---");
                    Thread.Sleep(1000);
                    Apartments();
                    break;
                }
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
            Gate();
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
                Gate();
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
                Gate();
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
            Gate();
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
                Gate();
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
                Gate();
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
            Gate();
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
                Gate();
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
                Gate();
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
            Gate();
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
                Gate();
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
                Gate();
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
            Gate();
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
                Gate();
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
                Gate();
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
            Gate();
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
                Gate();
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
                Gate();
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
            Gate();
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
                Gate();
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
                Gate();
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
            Gate();
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
                Gate();
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
                Gate();
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
            Gate();
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
                Gate();
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
                Gate();
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
            Gate();
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
                Gate();
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
                Gate();
            }
        }
    }
}