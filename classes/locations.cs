public class Locations
{
    Items items = new();
    public string? currentLocation;
    public int? input;
    public bool gateUnlocked = false;
    public void Gate()
    {

        if (currentLocation == "GATE")
        {
            Console.WriteLine("You are at the front gate");
            Console.WriteLine("What do you want to do?");
            Console.WriteLine("1. Travel to a different location");
            Console.WriteLine("2. Exit through the gate");
            Console.WriteLine("3. Look around for anything useful");
            input = Convert.ToInt32(Console.ReadKey());
            while (!(input == 1 || input == 2 || input == 3))
            {
                if (input == 1)
                {
                    currentLocation = Console.ReadLine();
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
                    input = Convert.ToInt32(Console.ReadKey());
                }
            }
        }
    }
    public void Apartments()
    {
        if (currentLocation == "APARTMENTS" || currentLocation == "APARTEMENTS" || currentLocation == "APARTMENT" || currentLocation == "APARTEMENT")
        {
        }
    }
    public void SubwayEntrance()
    {
        if (currentLocation == "SUBWAY")
        {
        }
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