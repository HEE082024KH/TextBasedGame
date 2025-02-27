using TextBasedGame.classes;

public class ShackLocation(Locations locations, Lists lists, Status status)
{
  public void Shack()
  {
    while (true)
    {
      if (!lists.CheckBool("shack"))
      {
        Console.Clear();
        Console.WriteLine("On the outskirts of town you notice a small structure.");
        Thread.Sleep(4000);
        Console.WriteLine("As you walk towards it the structure turns into a house.");
        Thread.Sleep(4000);
        Console.WriteLine("Then goes from a house to a shack.");
        Thread.Sleep(3000);
        Console.Write("Rundown, broken");
        Thread.Sleep(2500);
        Console.WriteLine(", full of holes");
        Thread.Sleep(2000);
        Console.WriteLine(", clearly seen better days.");
        Thread.Sleep(3000);
        lists.AddItem("shack", -1, true);
      }

      lists.CurrentLocation = "Shack";
      Console.Clear();
      Console.WriteLine($"You are at the -{lists.CurrentLocation}-");
      Thread.Sleep(500);
      Console.WriteLine("");
      Console.WriteLine("--What do you want to do?--");
      Console.WriteLine("1. Travel to a different location");
      Console.WriteLine("2. Check status");
      Console.WriteLine("3. Enter the shack");
      Console.WriteLine("4. Look around outside for anything useful");
      try
      {
        lists.ModifyInt("Input", Convert.ToInt32(Console.ReadLine()));
      }
      catch
      {
        Console.Clear();
        Console.WriteLine("Invalid input");
        Thread.Sleep(1500);
        Shack();
      }

      switch (lists.GetValue("Input"))
      {
        case 1:
          locations.LocationSelector();
          break;
        case 2:
          Console.Clear();
          status.ShowStatus();
          continue;
        case 3:
          Console.Clear();
          Console.WriteLine("The floorboards creek as you approach the door.");
          Thread.Sleep(3500);
          Console.WriteLine("You carefully watch your step to not step on any of the broken ones.");
          Thread.Sleep(4000);
          Console.WriteLine("The door barely opens as you push it, squeeking and scraping as you do.");
          Thread.Sleep(5000);
          Console.Write("Inside looks about the same as the outside");
          Thread.Sleep(3500);
          Console.WriteLine(", broken and abandoned.");
          Thread.Sleep(2500);
          Console.WriteLine("There are not many spots to search.");
          Thread.Sleep(3000);
          Console.WriteLine("");
          insideShack:
          Console.WriteLine("--Where do you want to search?--");
          Console.WriteLine("1. Broken boxes in the corner");
          Console.WriteLine("2. Fireplace");
          Console.WriteLine("3. Remains of a dresser.");
          Console.WriteLine("4. Leave");
          try
          {
            lists.ModifyInt("Input", Convert.ToInt32(Console.ReadLine()));
          }
          catch
          {
            Console.Clear();
            Console.WriteLine("Invalid input");
            Thread.Sleep(1500);
            goto insideShack;
          }

          switch (lists.GetValue("Input"))
          {
            case 1:
              Console.Clear();
              Console.Write("You ruffle through the boxes");
              Thread.Sleep(2000);
              Console.WriteLine(", one by one.");
              Thread.Sleep(2500);
              Console.WriteLine("Dust emit as you open them.");
              Thread.Sleep(3000);
              Console.Write("To your surprise");
              Thread.Sleep(2500);
              Console.WriteLine(" they are full of cash.");
              Thread.Sleep(3000);
              Console.Write("Discolored and crumpled");
              Thread.Sleep(2500);
              Console.WriteLine(", clearly all fake.");
              Thread.Sleep(3000);
              Console.WriteLine("One of the bills look normal, however.");
              Thread.Sleep(3000);
              Console.WriteLine("You got $10");
              Thread.Sleep(3000);
              lists.ModifyValue("Money", i => i + 10);
              break;
            case 2:
              Console.Clear();
              Console.WriteLine("The fireplace looks broken down and ruined.");
              Thread.Sleep(3500);
              Console.WriteLine("There is probably nothing to be found here.");
              Thread.Sleep(3500);
              Console.Write("You are about to leave");
              Thread.Sleep(2500);
              Console.Write(" when you spot a small button");
              Thread.Sleep(2500);
              Console.WriteLine(", in plain view next to the fireplace");
              Thread.Sleep(3000);
              Console.WriteLine("");
              insideShackButton:
              Console.WriteLine("--What do you want to do?--");
              Console.WriteLine("1. Push the button");
              Console.WriteLine("2. Leave");
              try
              {
                lists.ModifyInt("Input", Convert.ToInt32(Console.ReadLine()));
              }
              catch
              {
                Console.Clear();
                Console.WriteLine("Invalid input");
                Thread.Sleep(1500);
                goto insideShackButton;
              }

              switch (lists.GetValue("Input"))
              {
                case 1:
                  Console.Clear();
                  Console.Write("As you push the button");
                  Thread.Sleep(2500);
                  Console.WriteLine(" you hear faint mechanical sounds.");
                  Thread.Sleep(3000);
                  Console.WriteLine("A small slot opens in the wall");
                  Thread.Sleep(3000);
                  Console.WriteLine("");
                  Thread.Sleep(2000);
                  break;
                case 2:
                  break;
              }

              break;
            case 3:
              Console.Clear();
              Console.Write("You search the dresser");
              Thread.Sleep(2500);
              Console.WriteLine(", at least what is left of it");
              Thread.Sleep(3000);
              Console.Write("It is mostly empty");
              Thread.Sleep(2500);
              Console.WriteLine(" except for some paper.");
              Thread.Sleep(3000);
              Console.WriteLine("In between the paper you find $15");
              Thread.Sleep(4000);
              lists.ModifyValue("Money", i => i + 15);
              break;
            case 4:
              break;
          }

          continue;
        case 4:
          continue;
        default:
          Console.Clear();
          Console.Write("Invalid input");
          Thread.Sleep(1500);
          continue;
      }

      break;
    }
  }
}