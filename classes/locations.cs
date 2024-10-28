public class Locations
{
    Items items = new();
    Map map = new();
    Start start = new();
    public string? currentLocation;
    public int? input;
    public bool gateUnlocked = false;
    public void LocationSelector()
    {
        if (start.newGame == true)
        {
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
        {
            Console.Clear();
            Console.WriteLine("You are at the front gate");
            Thread.Sleep(2000);
            Console.WriteLine("What do you want to do?");
            Console.WriteLine("1. Travel to a different location");
            Console.WriteLine("2. Exit through the gate");
            Console.WriteLine("3. Look around for anything useful");
            input = Convert.ToInt32(Console.ReadLine());
            while (input != 1 || input != 2 || input != 3)
            {
                if (input == 1)
                {
                    map.ShowMap();
                    Console.WriteLine("Where do you want to travel to?");
                    input = Convert.ToInt32(Console.ReadLine());
                    LocationSelector();
                }
                else if (input == 2)
                {
                    if (gateUnlocked == true)
                    {
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
                        Console.WriteLine("The gate is locked");
                        Console.WriteLine("I need to find some way to unlock the gate");
                    }
                }
                else if (input == 3)
                {
                    if (items.hasFlashlight == true)
                    {
                        Console.WriteLine("You use your flashlight to look around");
                        Console.WriteLine("You found a 'Hairpin'");
                        items.hasHairpin = true;
                    }
                    else
                    {
                        Console.WriteLine("You struggle to see anything in the dark");
                        Console.WriteLine("If only I had a flashlight");
                    }
                }
                else
                {
                    Console.WriteLine("What do you want to do?");
                    Console.WriteLine("1. Travel to a different location");
                    Console.WriteLine("2. Exit through the gate");
                    Console.WriteLine("3. Look around for anything useful");
                    input = Convert.ToInt32(Console.ReadLine());
                }
            }
        }
    }
    public void Apartments()
    {
    }
    public void SubwayEntrance()
    {
    }
    public void Shop()
    {
    }
    public void ArtGallery()
    {
    }
    public void OfficeBuilding()
    {
    }
    public void Pavilion()
    {
    }
    public void AbandonedWarehouse()
    {
    }
    public void BombShelter()
    {
    }
    public void Fountain()
    {
    }
    public void Alley()
    {
    }
    public void Shack()
    {
    }
}