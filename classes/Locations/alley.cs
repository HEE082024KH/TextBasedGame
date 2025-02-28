using TextBasedGame.classes;

public class AlleyLocation(Locations locations, Lists lists, Status status)
{
  public void Alley()
  {
    while (true)
    {
      if (!lists.CheckBool("alley"))
      {
        Console.Clear();
        Console.Write("Between two shabby buildings");
        Thread.Sleep(2000);
        Console.WriteLine(" there is a murky alley leading away from the lights.");
        Thread.Sleep(4000);
        Console.Write("Faint sounds of people can be heard");
        Thread.Sleep(3000);
        Console.WriteLine(", hard to tell friendly or not.");
        Thread.Sleep(3500);
        lists.AddItem("alley", -1, true);
      }

      lists.CurrentLocation = "Alley";
      Console.Clear();
      Console.WriteLine($"You are at the -{lists.CurrentLocation}-");
      Thread.Sleep(500);
      Console.WriteLine("");
      Console.WriteLine("--What do you want to do?--");
      Console.WriteLine("1. Travel to a different location");
      Console.WriteLine("2. Check status");
      Console.WriteLine("3. Enter the alley");
      try
      {
        lists.ModifyInt("Input", Convert.ToInt32(Console.ReadLine()));
      }
      catch
      {
        Console.Clear();
        Console.WriteLine("Invalid input");
        Thread.Sleep(1500);
        Alley();
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
          Console.Write("As you walk down the alley");
          Thread.Sleep(2500);
          Console.WriteLine(" you come across a man blocking the road.");
          Thread.Sleep(3000);
          Console.WriteLine("The man is tall and wide, strong and intimidating.");
          Thread.Sleep(4000);
          Console.WriteLine("");
          alley:
          Console.WriteLine("--What do you want to do?--");
          Console.WriteLine("1. Approach the man");
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
            goto alley;
          }

          switch (lists.GetValue("Input"))
          {
            case 1:
              Console.Clear();
              if (lists.CheckBool("Gun"))
              {
                Console.Clear();
                Console.WriteLine("Your approach the man.");
                Thread.Sleep(2500);
                Console.WriteLine("He just stares ominously at you.");
                Thread.Sleep(3000);
                Console.WriteLine("You pull out your Gun and points it at him.");
                Thread.Sleep(3500);
                Console.WriteLine("He continues staring at you.");
                Thread.Sleep(3000);
                Console.WriteLine("Without changing expressions he stand aside and lets you pass.");
                Thread.Sleep(4000);
                Console.Write("As you turn the corner");
                Thread.Sleep(2500);
                Console.WriteLine("the area opens up with people everywhere.");
                Thread.Sleep(3500);
                Console.WriteLine("Stands and shops, selling all kinds of things and services");
                Thread.Sleep(4000);
                Console.WriteLine("How can there be this many people here when it is dead everywhere else?");
                Thread.Sleep(4500);
                Console.WriteLine("There is a so much going on here you don't even know where to start.");
                Thread.Sleep(4500);
                Console.Write("The alley is a deadend");
                Thread.Sleep(2500);
                Console.WriteLine(", tall buildings surrounds the market on all sides.");
                Thread.Sleep(3500);
                Console.WriteLine("You notice a lone steel door along the left wall.");
                Thread.Sleep(3500);
                Console.Write("Looks like the kind of door that should be heavily guarded");
                Thread.Sleep(3500);
                Console.WriteLine(", but it is not.");
                Thread.Sleep(2500);
                Console.WriteLine("");
                alleyBackyard:
                Console.WriteLine("--What do you want to do?--");
                Console.WriteLine("1. Try to enter the lone steel door");
                Console.WriteLine("2. Walk around the open area");
                Console.WriteLine("3. Check out the stand and shops");
                Console.WriteLine("4. Talk with people");
                Console.WriteLine("5. Leave");
                try
                {
                  lists.ModifyInt("Input", Convert.ToInt32(Console.ReadLine()));
                }
                catch
                {
                  Console.Clear();
                  Console.WriteLine("Invalid input");
                  Thread.Sleep(1500);
                  goto alleyBackyard;
                }

                switch (lists.GetValue("Input"))
                {
                }
              }
              else
              {
                Console.Clear();
                Console.WriteLine("Your approach the man.");
                Thread.Sleep(2500);
                Console.WriteLine("He just stares ominously at you.");
                Thread.Sleep(3000);
                Console.Write("As you start to open your mouth");
                Thread.Sleep(3000);
                Console.WriteLine(" he smacks you across the face.");
                Thread.Sleep(3000);
                Console.WriteLine("-10 HP");
                Thread.Sleep(3000);
                lists.ModifyValue("HP", i => i - 10);
                lists.Hp();
                Console.WriteLine("Does not seem like much of a talker.");
                Thread.Sleep(4000);
              }

              break;
            case 2:
              break;
          }

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