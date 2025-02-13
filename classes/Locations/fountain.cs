public class FountainLocation(Locations locations)
{
  private readonly Items items = new(locations, locations.items);
  private readonly Status status = new(locations, locations.items);
  private bool fountain;

  public void Fountain()
  {
    while (true)
    {
      if (!fountain)
      {
        Console.Write("As you round the corner");
        Thread.Sleep(2000);
        Console.WriteLine(" a large sculpture appears in the distance.");
        Thread.Sleep(2500);
        Console.Write("You move closer towards the middle of the intersection");
        Thread.Sleep(2500);
        Console.WriteLine(" the large sculpture shows it's beauty.");
        Thread.Sleep(2000);
        Console.Write("A magnificent marble sculpture");
        Thread.Sleep(1500);
        Console.Write(", like nothing you have ever seen");
        Thread.Sleep(1500);
        Console.WriteLine(", of an angel in deep thought.");
        Thread.Sleep(2000);
        Console.Write("In this gloomy town");
        Thread.Sleep(1500);
        Console.WriteLine(", decayed and destroyed");
        Thread.Sleep(1500);
        Console.WriteLine(", it stands out.");
        Thread.Sleep(2000);
        Console.Write("Out of place");
        Thread.Sleep(1500);
        Console.Write(", untouched");
        Thread.Sleep(1000);
        Console.WriteLine(", like it has been frozen in time.");
        Thread.Sleep(2500);
        fountain = true;
      }

      locations.CurrentLocation = "Fountain";
      Console.Clear();
      Console.WriteLine($"You are at the  -{locations.CurrentLocation}-");
      Thread.Sleep(500);
      Console.WriteLine("---What do you want to do?---");
      Console.WriteLine("1. Travel to a different location");
      Console.WriteLine("2. Check status");
      Console.WriteLine("3. Throw something into the fountain");
      Console.WriteLine("4. Sit down by the fountain");
      try
      {
        locations.Input = Convert.ToInt32(Console.ReadLine());
      }
      catch
      {
        Console.Clear();
        Console.WriteLine("Invalid input");
        Thread.Sleep(1500);
        Fountain();
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
          continue;
        }
        case 3:
        {
          Console.Clear();
          Console.Write("As you approach the fountain");
          Thread.Sleep(2000);
          Console.WriteLine(" you notice the water is clear and empty.");
          Thread.Sleep(2000);
          Console.WriteLine("It does not look like anyone has thrown anything into the fountain before.");
          Thread.Sleep(3500);
          Console.WriteLine("Or is there something strange going on?");
          Thread.Sleep(2000);
          Console.WriteLine("");
          fountainThrow:
          Console.WriteLine("--What do you want to do?---");
          Console.WriteLine("1. Throw something into the fountain");
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
            goto fountainThrow;
          }

          switch (locations.Input)
          {
            case 1:
              fountainThrowThrow:
              Console.Clear();
              Console.WriteLine("Which item do you want to throw in?");
              Console.WriteLine("1. Leave");
              if (items.Coin)
              {
                Console.WriteLine("- Coin");
              }

              if (items.DogBone)
              {
                Console.WriteLine("- Dog Bone");
              }

              try
              {
                locations.ItemInput = Console.ReadLine()?.ToLower();
              }
              catch
              {
                Console.Clear();
                Console.WriteLine("Invalid input");
                Thread.Sleep(1500);
                Console.Clear();
                goto fountainThrowThrow;
              }

              switch (locations.ItemInput)
              {
                case "coin":
                  Console.WriteLine("You toss the Coin into the fountain.");
                  Thread.Sleep(2000);
                  break;
                case "dogbone":
                case "dog bone":
                  Console.WriteLine("You toss the Dog Bone into the fountain.");
                  Thread.Sleep(2000);
                  break;
                case "1":
                  Fountain();
                  break;
                default:
                  goto fountainThrowThrow;
              }

              break;
            case 2:
              Fountain();
              break;
          }

          break;
        }
        case 4:
        {
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