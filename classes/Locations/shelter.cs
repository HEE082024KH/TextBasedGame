public class BombShelter(Locations locations)
{
  private readonly Items items = new(locations, locations.items);
  private readonly Status status = new(locations, locations.items);

  public void Shelter()
  {
    locations.CurrentLocation = "BombShelter";
    Console.Clear();
    Console.WriteLine($"You are at the  -{locations.CurrentLocation}-");
    Thread.Sleep(500);
    Console.WriteLine("---What do you want to do?---");
    Console.WriteLine("1. Travel to a different location");
    Console.WriteLine("2. Check status");
    Console.WriteLine("3. Go inside");
    Console.WriteLine("4. Look around outside");
    try
    {
      locations.Input = Convert.ToInt32(Console.ReadLine());
    }
    catch
    {
      Console.Clear();
      Console.WriteLine("Invalid input");
      Thread.Sleep(1500);
      Shelter();
    }

    switch (locations.Input)
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
        Shelter();
        break;
      }
      case 3:
      {
        Console.Clear();
        Console.WriteLine("You walk down the concrete stairs towards a solid steel door.");
        Thread.Sleep(3500);
        Console.WriteLine("Seems like it might go deep underground.");
        Thread.Sleep(2500);
        Console.WriteLine("You almost feel slightly claustrophobic as you approach the door.");
        Thread.Sleep(3500);
        if (items.ShelterKey)
        {
          Console.WriteLine("Shelter Key success.");
        }
        else
        {
          Console.WriteLine("Locked.");
          Thread.Sleep(2000);
          Console.WriteLine("I guess it is smart to prevent people stealing stuff.");
          Thread.Sleep(3000);
          Console.WriteLine("But what if people actually need shelter?");
          Thread.Sleep(3000);
        }

        break;
      }
      case 4:
      {
        Console.Clear();
        Console.WriteLine("You look around the entrance for anything useful.");
        Thread.Sleep(2500);
        Console.WriteLine("There is a few bags of trash scattered around.");
        Thread.Sleep(2500);
        Console.WriteLine("");
        shelterEntrance:
        Console.WriteLine("--What do you want to do?--");
        Console.WriteLine("1. Search the bags of trash");
        Console.WriteLine("2. Leave");
        try
        {
          locations.Input = Convert.ToInt32(Console.ReadLine());
        }
        catch
        {
          Console.Clear();
          Console.WriteLine("Invalid input");
          Thread.Sleep(1500);
          Console.Clear();
          goto shelterEntrance;
        }

        switch (locations.Input)
        {
          case 1:
            Console.Clear();
            Console.Write("You open a few of the bags");
            Thread.Sleep(2000);
            Console.WriteLine(" but they are all full of nothing useful.");
            Thread.Sleep(2500);
            Console.Write("You are about to go back to the entrance");
            Thread.Sleep(2500);
            Console.WriteLine(" when you spot a hidden bag you have not searched.");
            Thread.Sleep(3000);
            Console.Write("As you open it you find a GUN");
            Thread.Sleep(2000);
            items.Gun = true;
            Console.WriteLine(", however it is missing the magazine.");
            Thread.Sleep(2000);
            Shelter();
            break;
          case 2:
            Shelter();
            break;
        }

        break;
      }
      default:
      {
        Console.Clear();
        Console.Write("Invalid input");
        Thread.Sleep(1500);
        Shelter();
        break;
      }
    }
  }
}