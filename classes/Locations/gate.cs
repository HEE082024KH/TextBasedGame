public class GateLocation
{
    Locations locations = new();
    Status inventory = new();
    Items items = new();
    public void Gate()
    {
    gate:
        locations.currentLocation = "Gate";
        Console.Clear();
        Console.WriteLine($"You are at the  -{locations.currentLocation}-");
        Console.WriteLine("");
        Console.WriteLine("---What do you want to do?---");
        Console.WriteLine("1. Travel to a different location");
        Console.WriteLine("2. Check inventory");
        Console.WriteLine("3. Exit through the gate");
        Console.WriteLine("4. Look around for anything useful");
        try
        {
            locations.input = Convert.ToInt32(Console.ReadLine());
        }
        catch
        {
            Console.WriteLine("Invalid input");
        }
        switch (locations.input)
        {
            case 1:
                {
                    goto locationSelector;
                }
            case 2:
                {
                    Console.Clear();
                    Console.WriteLine("Press -enter- to go back");
                    inventory.showStatus();
                    Console.ReadLine();
                    goto gate;
                }
            case 3:
                {
                    if (items.hasGateKey == true)
                    {
                        Console.Clear();
                        Console.WriteLine("You take out the key and slide it into the keyhole");
                        Thread.Sleep(2000);
                        Console.Write(", with a distinct click");
                        Thread.Sleep(1000);
                        Console.Write(" it unlocks.");
                        Thread.Sleep(1000);
                        Console.WriteLine("You push open the heavy gate.");
                        Thread.Sleep(3000);
                        Console.Clear();
                        Console.WriteLine("It screeches loudly as it scrapes along the ground.");
                        Thread.Sleep(3000);
                        Console.Clear();
                        Console.WriteLine("Then silence...");
                        Thread.Sleep(2000);
                        Console.Clear();
                        Console.WriteLine("You look back one last time before leaving.");
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
                        Console.WriteLine("");
                        Console.WriteLine("I need to find some way to unlock the gate");
                        Thread.Sleep(3500);
                        goto gate;
                    }
                    break;
                }
            case 4:
                {
                    if (items.hasFlashlight == true && items.hasHairpin == true)
                    {
                        Console.Clear();
                        Console.WriteLine("You use your flashlight to look around");
                        Thread.Sleep(1500);
                        Console.WriteLine("But you find nothing useful");
                        Thread.Sleep(3500);
                        goto gate;
                    }
                    else if (items.hasFlashlight == true)
                    {
                        Console.Clear();
                        Console.WriteLine("You use your flashlight to look around");
                        Thread.Sleep(1500);
                        Console.WriteLine("You found a -Hairpin-");
                        items.hasHairpin = true;
                        Thread.Sleep(3500);
                        goto gate;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("You struggle to see anything in the dark");
                        Thread.Sleep(1500);
                        Console.WriteLine("If only I had a flashlight");
                        Thread.Sleep(3500);
                        goto gate;
                    }
                }
            default:
                {
                    Console.Clear();
                    Console.Write("---Invalid input---");
                    Thread.Sleep(1000);
                    goto gate;
                }
        }
    locationSelector:
        locations.LocationSelector();
    }
}