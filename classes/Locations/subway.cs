public class SubwayEntrance(Locations locations)
{
  private readonly Items items = locations.items;
  private readonly Status status = new(locations, locations.items);
  private bool subwayEntrance;
  private bool subwayFlashlight;

  public void Subway()
  {
    locations.currentLocation = "SubwayEntrance";
    Console.Clear();
    Console.WriteLine($"You are at the  -{locations.currentLocation}-");
    Thread.Sleep(500);
    Console.WriteLine("---What do you want to do?---");
    Console.WriteLine("1. Travel to a different location");
    Console.WriteLine("2. Check status");
    Console.WriteLine("3. Go down into the subway");
    Console.WriteLine("4. Check the area around the entrance");
    try
    {
      locations.input = Convert.ToInt32(Console.ReadLine());
    }
    catch
    {
      Console.Clear();
      Console.WriteLine("Invalid input");
      Thread.Sleep(1500);
      Subway();
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
        Subway();
        break;
      }
      case 3:
      {
        if (subwayFlashlight)
        {
          Console.WriteLine("I have nothing more to do down here.");
          Thread.Sleep(2000);
          Subway();
        }
        else if (!subwayEntrance)
        {
          Console.Clear();
          Console.Write("As you walk down into the subway");
          Thread.Sleep(1500);
          Console.WriteLine(", it gets harder to see");
          Thread.Sleep(2500);
          Console.Write("The lights are out");
          Thread.Sleep(1500);
          Console.WriteLine(" and you can hear rats running around somewhere.");
          Thread.Sleep(3000);
          Console.Write("Despite the lack of lights");
          Thread.Sleep(1500);
          Console.WriteLine(", you notice all the dirt and grime on the floors.");
          Thread.Sleep(3000);
          Console.Write("From what you can see");
          Thread.Sleep(1500);
          Console.WriteLine(" it does not look like this subway is in use anymore.");
          Thread.Sleep(3000);
          Console.Write("I can go further down into the subway");
          Thread.Sleep(2000);
          Console.WriteLine(" but it might be hard to see anything without a flashlight.");
          Thread.Sleep(3500);
          Console.WriteLine("");
          subwayEntrance = true;
        }

        subwayEntrance:
        Console.WriteLine("--What do you want to do?--");
        Console.WriteLine("1. Go further down into the subway");
        Console.WriteLine("2. Leave");
        try
        {
          locations.input = Convert.ToInt32(Console.ReadLine());
        }
        catch
        {
          Console.Clear();
          Console.WriteLine("Invalid input");
          Thread.Sleep(1500);
          goto subwayEntrance;
        }

        switch (locations.input)
        {
          case 1:
            if (items.Flashlight && !subwayFlashlight)
            {
              Console.WriteLine("You venture down into the subway.");
              Thread.Sleep(2000);
              Console.Write("Your flashlight makes it easier to see");
              Thread.Sleep(2000);
              Console.WriteLine(", but it is still rather dark.");
              Thread.Sleep(2000);
              Console.Write("The subway is fairly empty");
              Thread.Sleep(2000);
              Console.WriteLine(", if you look past the dirt and trash.");
              Thread.Sleep(2000);
              Console.Write("As you walk around");
              Thread.Sleep(1500);
              Console.WriteLine(" it feels like there is someone of something watching you.");
              Thread.Sleep(3000);
              Console.Write("You try every door you find");
              Thread.Sleep(2000);
              Console.WriteLine(", but they are all locked.");
              Thread.Sleep(2500);
              Console.WriteLine("Eventually, you find an unlocked door.");
              Thread.Sleep(3000);
              Console.Clear();
              Console.Write("Slowly");
              Thread.Sleep(1000);
              Console.Write(", you open the door");
              Thread.Sleep(1000);
              Console.WriteLine("and walk in.");
              Thread.Sleep(2000);
              Console.Write("Inside there are shelves everywhere");
              Thread.Sleep(2000);
              Console.WriteLine(", filled with boxes on boxes.");
              Thread.Sleep(2000);
              Console.WriteLine("");
              subwayShelves:
              Console.WriteLine("--What do you do want to do?--");
              Console.WriteLine("1. Search left side first");
              Console.WriteLine("2. Search right side first");
              Console.WriteLine("3. Leave");
              try
              {
                locations.input = Convert.ToInt32(Console.ReadLine());
              }
              catch
              {
                Console.Clear();
                Console.WriteLine("Invalid input");
                Thread.Sleep(1500);
                Console.Clear();
                goto subwayShelves;
              }

              switch (locations.input)
              {
                case 1:
                  Console.WriteLine("You start searching the boxes on the left side.");
                  Thread.Sleep(2500);
                  Console.Write("While searching one of the boxes");
                  Thread.Sleep(1500);
                  Console.WriteLine(", you cut your hand on something sharp");
                  Thread.Sleep(2500);
                  Console.WriteLine("-10 HP");
                  items.HealthPoints -= 10;
                  items.Hp();
                  Console.Clear();
                  goto subwayShelves;
                case 2:
                  if (!items.Crowbar)
                  {
                    Console.WriteLine("You start searching the boxes on the right side.");
                    Thread.Sleep(2500);
                    Console.Write("After going through a lot of empty boxes");
                    Thread.Sleep(2500);
                    Console.WriteLine(", you find a box with a tool label.");
                    Thread.Sleep(2000);
                    Console.WriteLine("Inside you find a CROWBAR");
                    Thread.Sleep(2500);
                    items.Crowbar = true;
                  }
                  else
                  {
                    Console.WriteLine("I have already searched these boxes before.");
                    Thread.Sleep(2500);
                  }

                  Console.Clear();
                  goto subwayShelves;
                case 3:
                  Subway();
                  break;
              }

              subwayFlashlight = true;
            }
            else if (subwayFlashlight)
            {
              Console.WriteLine("I have nothing more to do down here.");
              Thread.Sleep(2000);
            }
            else
            {
              Console.WriteLine("You venture down into the subway.");
              Thread.Sleep(2000);
              Console.WriteLine("Before you know it everything is pitch black.");
              Thread.Sleep(3500);
              Console.WriteLine("You start hearing unintelligible noises");
              Thread.Sleep(2000);
              Console.Write("Humans?");
              Thread.Sleep(1000);
              Console.Write(" Animals?");
              Thread.Sleep(1000);
              Console.WriteLine(" Or maybe something worse?");
              Thread.Sleep(1500);
              Console.Write("You keep walking down corridors");
              Thread.Sleep(2000);
              Console.WriteLine(", or what you think are corridors.");
              Thread.Sleep(2000);
              Console.WriteLine("You get the feeling someone or something is watching you");
              Thread.Sleep(3000);
              Console.Write("...");
              Thread.Sleep(1000);
              Console.WriteLine(" Everything goes black.");
              Thread.Sleep(2000);
              items.HealthPoints = 0;
              items.Hp();
            }

            break;
          case 2:
            Subway();
            break;
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
        Console.Write("Some of them torn apart");
        Thread.Sleep(1500);
        Console.WriteLine(", trash scattered everywhere.");
        Thread.Sleep(2000);

        break;
      }
      default:
      {
        Console.Clear();
        Console.Write("---Invalid input---");
        Thread.Sleep(1000);
        Subway();
        break;
      }
    }
  }
}