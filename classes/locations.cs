public class Locations
{
    Map map = new();
    Start start = new();
    GateLocation gate = new();
    public string? currentLocation;
    public int? input;
    public bool gateUnlocked = false;
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
    public void Apartments()
    {
        currentLocation = "Apartments";
        Console.Clear();
        Console.WriteLine($"You are at the  -{currentLocation}-");
        Console.WriteLine("");
        Console.WriteLine("---What do you want to do?---");
        Console.WriteLine("1. Travel to a different location");
        Console.WriteLine("2. Check inventory");
        Console.WriteLine("3. Look around outside");
        Console.WriteLine("4. Go in the front door");
        Console.WriteLine("5. Look for an open window");
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
                    Console.WriteLine("");
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
                                Console.Clear();
                                Console.WriteLine("You rummage through the bags, looking for anything of use.");
                                Thread.Sleep(1000);
                                Console.WriteLine("Looking through one of the bags, you cut your hand on a sharp object");
                                Thread.Sleep(2000);
                                items.Wounds();
                                Apartments();
                                break;
                            }
                        case 2:
                            {
                                Console.Clear();
                                Console.WriteLine("You leave the bags alone.");
                                Thread.Sleep(2000);
                                Console.WriteLine("Who knows what kind of diseases are in those bags.");
                                Thread.Sleep(2000);
                                Apartments();
                                break;
                            }
                    }
                    break;
                }
            case 4:
                {
                insideApartments:
                    Console.Clear();
                    Console.WriteLine("The door opens with a nasty creak");
                    Thread.Sleep(1000);
                    Console.WriteLine(", sure to notify anyone nearby.");
                    Thread.Sleep(2000);
                    Console.WriteLine("Inside there's a small hallway with a door at the end,");
                    Console.WriteLine("and 2 doors on either side.");
                    Thread.Sleep(2000);
                    Console.WriteLine("");
                    Console.WriteLine("What do you want to do?");
                    Console.WriteLine("1. Enter the first door on the right");
                    Console.WriteLine("2. Enter the second door on the right");
                    Console.WriteLine("3. Enter the first door on the left");
                    Console.WriteLine("4. Enter the first door on the left");
                    Console.WriteLine("5. Enter the door at the end");
                    Console.WriteLine("6. Leave");
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
                                if (items.hasCrowbar == true)
                                {
                                    Console.WriteLine("You use the crowbar to pry the door open.");
                                    Thread.Sleep(1000);
                                    Console.WriteLine("With a loud crack the door opens");
                                    Thread.Sleep(2000);
                                    Console.WriteLine("The room looks to be a maintainance room of sorts");
                                    Thread.Sleep(1000);
                                    Console.WriteLine("Not much to find here");
                                    Thread.Sleep(2000);
                                    goto insideApartments;
                                }
                                if (items.hasHairpin == true)
                                {
                                    items.hasHairpin = false;
                                    Console.WriteLine("You use the hairpin to unlock the door.");
                                    Thread.Sleep(2000);
                                    Console.WriteLine("The room looks to be a maintainance room of sorts");
                                    Thread.Sleep(1000);
                                    Console.WriteLine("Not much to find here");
                                    Thread.Sleep(2000);
                                    goto insideApartments;
                                }
                                else
                                {
                                    Console.WriteLine("The door is locked");
                                    Thread.Sleep(1000);
                                    Console.WriteLine("If only I had a crowbar or something to unlock down the door");
                                    Thread.Sleep(3000);
                                    goto insideApartments;
                                }
                            }
                        case 2:
                            {
                                if (items.hasCrowbar == true || items.hasHairpin == true)
                                {
                                    Console.Clear();
                                    if (items.hasCrowbar == true)
                                    {
                                        Console.WriteLine("You use the crowbar to pry the door open.");
                                    }
                                    else if (items.hasHairpin == true)
                                    {
                                        items.hasHairpin = false;
                                        Console.WriteLine("You use the hairpin to unlock the door.");
                                    }
                                    Thread.Sleep(1000);
                                    Console.WriteLine("The door opens with ease");
                                    Thread.Sleep(500);
                                    Console.Write(", almost too easy");
                                    Thread.Sleep(1500);
                                    Console.WriteLine("");
                                    Console.WriteLine("What do you want to do?");
                                    Console.WriteLine("1. Just walk in");
                                    Console.WriteLine("2. Hug the wall and sneakily look inside");
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
                                                Console.WriteLine("As you walk in man jumps you.");
                                                Thread.Sleep(1000);
                                                Console.WriteLine("During the struggle you hurt your arm.");
                                                items.Wounds();
                                                Thread.Sleep(1500);
                                                Console.WriteLine("He's not much of a fighter, however, and eventually you knock him out.");
                                                Thread.Sleep(2000);
                                                Console.WriteLine("You go through his pockets and find a -Knife-");
                                                items.hasKnife = true;
                                                Thread.Sleep(1500);
                                                Console.WriteLine("");
                                                goto insideApartments;
                                            }
                                        case 2:
                                            {
                                                Console.Clear();
                                                Console.WriteLine("As you sneakily look inside");
                                                Thread.Sleep(500);
                                                Console.Write(", you notice a man waiting to jump you.");
                                                Thread.Sleep(1500);
                                                Console.WriteLine("You catch him off guard by quickly charging him and knocking him to the ground.");
                                                Thread.Sleep(2000);
                                                Console.WriteLine("With a quick strike you knock him out cold.");
                                                Thread.Sleep(1500);
                                                Console.WriteLine("You go through his pockets and find a -Knife-");
                                                items.hasKnife = true;
                                                Thread.Sleep(1500);
                                                Console.WriteLine("");
                                                goto insideApartments;
                                            }
                                        default:
                                            {

                                                break;
                                            }
                                    }
                                }
                                else
                                {
                                    Console.Clear();
                                    Console.WriteLine("The door is locked");
                                    Thread.Sleep(1000);
                                    Console.WriteLine("If only I had a crowbar or something to unlock down the door");
                                    Thread.Sleep(3000);
                                    goto insideApartments;
                                }
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
                        case 5:
                            {
                                break;
                            }
                        case 6:
                            {
                                Console.WriteLine("You leave the apartments and go outside again.");
                                Apartments();
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