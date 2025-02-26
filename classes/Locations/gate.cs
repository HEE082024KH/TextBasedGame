using TextBasedGame.classes;

public class GateLocation(Locations locations, Lists lists)
{
  private readonly Status? status = locations.Status;

  public void Gate()
  {
    while (true)
    {
      if (!lists.CheckBool("gate"))
      {
        Console.Clear();
        Console.WriteLine("");
        Thread.Sleep(2000);
        lists.AddItem("gate", -1, true);
      }

      lists.CurrentLocation = "Gate";
      Console.Clear();
      Structures.Gate();
      Console.WriteLine("");
      Console.WriteLine($"You are at the -{lists.CurrentLocation}-");
      Thread.Sleep(500);
      Console.WriteLine("");
      Console.WriteLine("--What do you want to do?--");
      Console.WriteLine("1. Travel to a different location");
      Console.WriteLine("2. Check status");
      Console.WriteLine("3. Exit through the gate");
      Console.WriteLine("4. Look around for anything useful");
      try
      {
        lists.ModifyInt("Input", Convert.ToInt32(Console.ReadLine()));
      }
      catch
      {
        Console.Clear();
        Console.WriteLine("Invalid input");
        Thread.Sleep(1500);
        Gate();
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
          status?.ShowStatus();
          continue;
        }
        case 3:
        {
          if (lists.CheckBool("Gate Key"))
          {
            Console.Clear();
            Structures.Gate();
            Console.WriteLine("");
            Console.WriteLine("You take out the key and slide it into the keyhole");
            Thread.Sleep(3000);
            Console.Write("With a distinct click");
            Thread.Sleep(2000);
            Console.WriteLine(" it unlocks.");
            Thread.Sleep(1500);
            Console.WriteLine("You push open the heavy gate.");
            Thread.Sleep(2500);
            Console.WriteLine("It screeches loudly as it scrapes along the ground.");
            Thread.Sleep(3500);
            Console.WriteLine("Then silence...");
            Thread.Sleep(2500);
            Console.WriteLine("");
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
            Thread.Sleep(2000);
            Console.WriteLine("I need to find some way to unlock the gate");
            Thread.Sleep(3500);
            continue;
          }

          break;
        }
        case 4:
        {
          if (lists.CheckBool("Flashlight") && lists.CheckBool("Hairpin"))
          {
            Console.Clear();
            Console.WriteLine("You use your flashlight to look around");
            Thread.Sleep(2500);
            Console.WriteLine("But you find nothing useful");
            Thread.Sleep(3000);
            continue;
          }

          if (lists.CheckBool("Flashlight"))
          {
            Console.Clear();
            Console.WriteLine("You use your flashlight to look around");
            Thread.Sleep(2500);
            Console.WriteLine("You found a HAIRPIN");
            lists.AddItem("Hairpin", -1, true);
            Thread.Sleep(300);
            continue;
          }

          Console.Clear();
          Console.WriteLine("You struggle to see anything in the dark");
          Thread.Sleep(2500);
          Console.WriteLine("If only you had a flashlight");
          Thread.Sleep(3000);
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