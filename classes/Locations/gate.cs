public class GateLocation(Locations locations)
{
  private readonly Items items = locations.items;
  private readonly Locations locations = locations;
  private readonly Status status = new(locations, locations.items);

  public void Gate()
  {
    locations.currentLocation = "Gate";
    Console.Clear();
    Console.WriteLine($"You are at the  -{locations.currentLocation}-");
    Console.WriteLine("");
    Console.WriteLine("--What do you want to do?--");
    Console.WriteLine("1. Travel to a different location");
    Console.WriteLine("2. Check status");
    Console.WriteLine("3. Exit through the gate");
    Console.WriteLine("4. Look around for anything useful");
    try
    {
      locations.input = Convert.ToInt32(Console.ReadLine());
    }
    catch
    {
      Console.Clear();
      Console.WriteLine("Invalid input");
      Thread.Sleep(1500);
      Gate();
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
        status.ShowStatus();
        Gate();
        break;
      }
      case 3:
      {
        if (items.GateKey == true)
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
          Gate();
        }

        break;
      }
      case 4:
      {
        if (items.Flashlight == true && items.Hairpin == true)
        {
          Console.Clear();
          Console.WriteLine("You use your flashlight to look around");
          Thread.Sleep(1500);
          Console.WriteLine("But you find nothing useful");
          Thread.Sleep(3500);
          Gate();
        }
        else if (items.Flashlight == true)
        {
          Console.Clear();
          Console.WriteLine("You use your flashlight to look around");
          Thread.Sleep(1500);
          Console.WriteLine("You found a -Hairpin-");
          items.Hairpin = true;
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

        break;
      }
      default:
      {
        Console.Clear();
        Console.Write("Invalid input");
        Thread.Sleep(1000);
        Gate();
        break;
      }
    }
  }
}