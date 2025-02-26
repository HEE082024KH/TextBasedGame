using TextBasedGame.classes;

public class FountainLocation(Locations locations, Lists lists, Status status)
{
  public void Fountain()
  {
    while (true)
    {
      if (!lists.CheckBool("fountain"))
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
        lists.AddItem("fountain", -1, true);
      }

      lists.CurrentLocation = "Fountain";
      Console.Clear();
      Console.WriteLine($"You are at the -{lists.CurrentLocation}-");
      Thread.Sleep(500);
      Console.WriteLine("");
      Console.WriteLine("--What do you want to do?--");
      Console.WriteLine("1. Travel to a different location");
      Console.WriteLine("2. Check status");
      Console.WriteLine("3. Throw something into the fountain");
      Console.WriteLine("4. Sit down by the fountain");
      try
      {
        lists.ModifyInt("Input", Convert.ToInt32(Console.ReadLine()));
      }
      catch
      {
        Console.Clear();
        Console.WriteLine("Invalid input");
        Thread.Sleep(1500);
        Fountain();
      }

      switch (lists.GetValue("Input"))
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
          Console.WriteLine("Which item do you want to throw in?");
          Console.WriteLine("0. Leave");
          var usableAt = lists.Variables.Where(item => item.UsableAtLocation.Contains(lists.CurrentLocation));
          foreach (var item in usableAt)
          {
            Console.WriteLine($"{lists.Variables.IndexOf(item)}. {item.Name}");
          }

          try
          {
            lists.ModifyInt("Input", Convert.ToInt32(Console.ReadLine()));
          }
          catch
          {
            Console.Clear();
            Console.WriteLine("Invalid input");
            Thread.Sleep(1500);
            Console.Clear();
            goto fountainThrow;
          }

          var items = usableAt.Where((_, index) => index == lists.GetValue("Input"))
            .FirstOrDefault();

          switch (items?.Name)
          {
            case "Coin":
              Console.Clear();
              Console.WriteLine("You toss the Coin into the fountain.");
              Thread.Sleep(2000);
              Console.Write("The water changes color");
              Thread.Sleep(2000);
              Console.Write(" to a hue of green");
              Thread.Sleep(2000);
              Console.WriteLine(", and starts to boil.");
              Thread.Sleep(2000);
              Console.Write("Shortly after it calms down");
              Thread.Sleep(2000);
              Console.WriteLine(" and the SHELTER KEY jumps out of the water.");
              Thread.Sleep(3000);
              lists.AddItem("Shelter Key", 0, true);
              break;
            case "Dog Bone":
              Console.Clear();
              Console.WriteLine("You toss the Dog Bone into the fountain.");
              Thread.Sleep(2000);
              Console.Write("The water changes color");
              Thread.Sleep(2000);
              Console.Write(" to a hue of red");
              Thread.Sleep(2000);
              Console.WriteLine(", and starts to boil.");
              Thread.Sleep(2000);
              Console.Write("Shortly after it calms down");
              Thread.Sleep(2000);
              Console.WriteLine(" and a GUN MAGAZINE jumps out of the water.");
              Thread.Sleep(3000);
              lists.AddItem("Gun Magazine", 0, true);
              if (lists.CheckBool("Gun"))
              {
                Console.WriteLine("You have now assembled the Gun, and is able to use it.");
                Thread.Sleep(4000);
              }
              else
              {
                Console.Write("Not much use for this");
                Thread.Sleep(2000);
                Console.WriteLine(", unless you find the rest of the Gun.");
                Thread.Sleep(3000);
              }

              break;
            case "0":
              Fountain();
              break;
            default:
              goto fountainThrow;
          }

          break;
        }
        case 4:
        {
          Console.Clear();
          Console.WriteLine("You approach the fountain and sit down by the water.");
          Thread.Sleep(3000);
          Console.Write("With swift motions");
          Thread.Sleep(1500);
          Console.WriteLine(" you drag your hand through the water.");
          Thread.Sleep(2000);
          Console.WriteLine("The water is surprisingly warm.");
          Thread.Sleep(2500);
          Console.Write("Somehow");
          Thread.Sleep(1000);
          Console.Write(", there is not a sound to be heard");
          Thread.Sleep(2000);
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
          if (!lists.CheckBool("fountainSit"))
          {
            Console.WriteLine("You are at full HP");
            lists.ModifyInt("HP", 100);
            lists.Hp();
            lists.AddItem("fountainSit", -1, true);
          }

          continue;
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