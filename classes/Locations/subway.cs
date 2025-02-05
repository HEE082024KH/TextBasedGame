public class SubwayEntrance(Locations locations)
{
  private readonly Items items = locations.items;
  private readonly Locations locations = locations;
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
        if (!subwayEntrance)
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
          subwayEntrance = true;
          Console.WriteLine("");
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
            if (items.Flashlight)
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
              Console.WriteLine("");
              Thread.Sleep(2000);
              Console.WriteLine("");
              Thread.Sleep(2000);
              Console.WriteLine("");
              Thread.Sleep(2000);
              Console.WriteLine("");
              Thread.Sleep(2000);
              Console.WriteLine("");
              Thread.Sleep(2000);
            }

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