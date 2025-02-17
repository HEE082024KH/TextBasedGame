using TextBasedGame.classes;

public class PavilionLocation(Locations locations)
{
  private readonly Items items = new(locations, locations.items);
  private readonly Status status = new(locations, locations.items);
  private bool pavilion;
  private bool pavilionCenter;
  private bool pavilionSearch;


  public void Pavilion()
  {
    while (true)
    {
      if (!pavilion)
      {
        Console.Clear();
        Console.Write("As you approach the pavilion");
        Thread.Sleep(2000);
        Console.WriteLine(" you expect to see a decayed structure in the middle of the park.");
        Thread.Sleep(3500);
        Console.Write("To your surprise");
        Thread.Sleep(1500);
        Console.Write(" it looks magnificent");
        Thread.Sleep(2000);
        Console.WriteLine(", a gorgeous structure center of a lush, green park.");
        Thread.Sleep(3000);
        Console.Write("Decorated with colorful bushes and flower");
        Thread.Sleep(2500);
        Console.WriteLine(" everywhere throughout the park.");
        Thread.Sleep(2000);
        Console.Write("In stark contrast to it's surroundings");
        Thread.Sleep(2000);
        Console.Write(", somehow");
        Thread.Sleep(1500);
        Console.Write(" it looks incredible.");
        Thread.Sleep(2000);
        pavilion = true;
      }

      locations.CurrentLocation = "Pavilion";
      Console.Clear();
      Console.WriteLine($"You are at the -{locations.CurrentLocation}-");
      Thread.Sleep(500);
      Console.WriteLine("");
      Console.WriteLine("--What do you want to do?--");
      Console.WriteLine("1. Travel to a different location");
      Console.WriteLine("2. Check status");
      Console.WriteLine("3. Walk up to the center of the pavilion");
      Console.WriteLine("4. Look around the pavilion");
      try
      {
        locations.Input = Convert.ToInt32(Console.ReadLine());
      }
      catch
      {
        Console.Clear();
        Console.WriteLine("Invalid input");
        Thread.Sleep(1500);
        Pavilion();
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
          Console.WriteLine("You walk up the stairs to the pavilion.");
          Thread.Sleep(2500);
          Console.WriteLine("You see benches along the railing.");
          Thread.Sleep(3000);
          Console.WriteLine("");
          pavilionCenter:
          Console.WriteLine("--What do you want to do?--");
          Console.WriteLine("1. Look around for anything useful");
          Console.WriteLine("2. Sit down and relax for a minute");
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
            goto pavilionCenter;
          }

          switch (locations.Input)
          {
            case 1:
              if (!pavilionSearch)
              {
                Console.Clear();
                Console.Write("It looks pretty empty here");
                Thread.Sleep(2000);
                Console.WriteLine(", not many spots where anything could be.");
                Thread.Sleep(2500);
                Console.WriteLine("Regardless, you search around each bench.");
                Thread.Sleep(3000);
                Console.Write("Nothing");
                Thread.Sleep(2000);
                Console.WriteLine(", just as you expected.");
                Thread.Sleep(2000);
                Console.Write("Just as you are about to leave");
                Thread.Sleep(2000);
                Console.WriteLine(", something catches your eye.");
                Thread.Sleep(2000);
                Console.WriteLine("Something is stuck to the leg of one of the benches.");
                Thread.Sleep(3000);
                Console.WriteLine("You found a CREDIT CARD");
                Thread.Sleep(2000);
                items.CreditCard = true;
                pavilionSearch = true;
              }
              else
              {
                Console.Clear();
                Console.WriteLine("There is nothing more to find here.");
                Thread.Sleep(3000);
              }

              Pavilion();
              break;
            case 2:
              Console.Clear();
              Console.WriteLine("You sit down on one of the benches.");
              Thread.Sleep(2000);
              Console.Write("There is not a sound to be heard");
              Thread.Sleep(2000);
              Console.Write(", somehow");
              Thread.Sleep(1000);
              Console.WriteLine(", complete silence.");
              Thread.Sleep(1500);
              Console.Write("A gentle breeze tickles your chin");
              Thread.Sleep(2000);
              Console.WriteLine(" as you embrace the quiet.");
              Thread.Sleep(2000);
              Console.WriteLine("You enjoy the tranquility a for a minute.");
              Thread.Sleep(5000);
              Console.Clear();
              Console.WriteLine("You feel invigorated by the break.");
              Thread.Sleep(3000);
              if (!pavilionCenter)
              {
                Console.WriteLine("You are at full HP");
                items.HealthPoints = 100;
                items.Hp();
                pavilionCenter = true;
              }

              break;
            default:
              Console.Clear();
              Console.WriteLine("Invalid input");
              Thread.Sleep(1500);
              Console.Clear();
              goto pavilionCenter;
          }

          break;
        }
        case 4:
        {
          Console.Clear();
          Console.WriteLine("");
          Thread.Sleep(2000);
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