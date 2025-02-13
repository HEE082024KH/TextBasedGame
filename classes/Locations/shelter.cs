public class BombShelter(Locations locations)
{
  private readonly Items items = new(locations, locations.items);
  private readonly Status status = new(locations, locations.items);
  private bool insideShelter;
  private bool insideShelterTake;
  private bool travelFromShelter;

  public void Shelter()
  {
    while (true)
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
          if (insideShelterTake)
          {
            travelFromShelter = true;
          }

          break;
        }
        case 2:
        {
          Console.Clear();
          status.ShowStatus();
          continue;
        }
        case 3:
        {
          Console.Clear();
          Console.WriteLine("You walk down the concrete stairs towards a solid steel door.");
          Thread.Sleep(3000);
          Console.WriteLine("Seems like it might go deep underground.");
          Thread.Sleep(2500);
          Console.WriteLine("You almost feel slightly claustrophobic as you approach the door.");
          Thread.Sleep(3000);
          if (items.ShelterKey && !insideShelter)
          {
            Console.Clear();
            Console.WriteLine("You use the Shelter Key to open the door.");
            Thread.Sleep(2500);
            Console.WriteLine("The door screeches as it opens.");
            Thread.Sleep(2000);
            Console.Write("Inside everything looks untouched");
            Thread.Sleep(2000);
            Console.Write(" like no one has been here for a long time");
            Thread.Sleep(2000);
            Console.WriteLine(", if at all.");
            Thread.Sleep(1500);
            Console.WriteLine("There is a lot of useful things in here.");
            Thread.Sleep(2500);
            Console.WriteLine("Maybe I should leave some stuff for other people that need it.");
            Thread.Sleep(3000);
            Console.WriteLine("");
            insideShelter:
            Console.WriteLine("--What do you want to do?---");
            Console.WriteLine("1. Take only what you need.");
            Console.WriteLine("2. Take everything.");
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
              goto insideShelter;
            }

            switch (locations.Input)
            {
              case 1:
                Console.Clear();
                Console.WriteLine("You gather some of the useful things in here.");
                Thread.Sleep(2500);
                Console.WriteLine("You got a FLASHLIGHT");
                Thread.Sleep(2000);
                items.Flashlight = true;
                Console.WriteLine("You got WATER");
                Thread.Sleep(2000);
                items.Water = true;
                Console.WriteLine("You got BATTERIES");
                Thread.Sleep(3000);
                items.Batteries = true;
                Console.WriteLine("And you leave the rest for someone else that needs it.");
                Thread.Sleep(3000);
                Shelter();
                break;
              case 2:
                Console.Clear();
                Console.Write("You take with you everything you can carry");
                Thread.Sleep(2500);
                Console.WriteLine(" even things you do not need.");
                Thread.Sleep(2000);
                Console.WriteLine("You got a FLASHLIGHT");
                Thread.Sleep(2000);
                items.Flashlight = true;
                Console.WriteLine("You got WATER");
                Thread.Sleep(2000);
                items.Water = true;
                Console.WriteLine("You got BATTERIES");
                Thread.Sleep(3000);
                items.Batteries = true;
                Console.WriteLine("You leave the place empty.");
                Thread.Sleep(3000);
                Shelter();
                insideShelterTake = true;
                break;
            }

            insideShelter = true;
          }
          else if (!items.ShelterKey)
          {
            Console.Clear();
            Console.WriteLine("Locked.");
            Thread.Sleep(2000);
            Console.WriteLine("I guess it is smart to prevent people stealing stuff.");
            Thread.Sleep(3000);
            Console.WriteLine("But what if people actually need shelter?");
            Thread.Sleep(3000);
            continue;
          }
          else if (travelFromShelter)
          {
            Console.Clear();
            Console.Write("As you enter the shelter");
            Thread.Sleep(1500);
            Console.WriteLine(" you notice a dead woman on the ground.");
            Thread.Sleep(2500);
            Console.Write("She looks frail and skinny");
            Thread.Sleep(2000);
            Console.WriteLine(", clothes ragged and dirty.");
            Thread.Sleep(2000);
            Console.WriteLine("Looks like she starved to death.");
            Thread.Sleep(2000);
            Console.WriteLine("Maybe I should not have taken everything.");
            Thread.Sleep(3000);
            continue;
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
              continue;
            case 2:
              continue;
          }

          break;
        }
        default:
        {
          Console.Clear();
          Console.Write("Invalid input");
          Thread.Sleep(1500);
          continue;
        }
      }

      break;
    }
  }
}