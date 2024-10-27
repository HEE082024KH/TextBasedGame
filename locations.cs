public class Locations
{
    Items items = new();
    public string? currentLocation;
    public int? input;
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
                    if (items.gateUnlocked == true)
                    {
                        Console.WriteLine("You push open the heavy gate");
                        Console.WriteLine("It screeches loudly as it scrapes along the ground");
                        Console.WriteLine("Then silence");
                        Console.WriteLine("You look back one last time before leaving");
                        Thread.Sleep(10000);
                        Console.Clear();
                        Console.WriteLine("CONGRATULATIONS, YOU MANAGED TO ESCAPE!");
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