using TextBasedGame.classes;

public class PavilionLocation(Locations locations, Lists lists, Status status)
{
  public void Pavilion()
  {
    while (true)
    {
      if (!lists.CheckBool("pavilion"))
      {
        Console.Clear();
        Console.Write("As you approach the pavilion");
        Thread.Sleep(2500);
        Console.WriteLine(" you expect to see a decayed structure in the middle of the park.");
        Thread.Sleep(4000);
        Console.Write("To your surprise");
        Thread.Sleep(2000);
        Console.Write(" it looks magnificent");
        Thread.Sleep(2500);
        Console.WriteLine(", a gorgeous structure in the center of a lush, green park.");
        Thread.Sleep(4000);
        Console.Write("Decorated with colorful bushes and flowers");
        Thread.Sleep(3500);
        Console.WriteLine(" everywhere throughout the park.");
        Thread.Sleep(3000);
        Console.Write("In stark contrast to it's surroundings");
        Thread.Sleep(3000);
        Console.Write(", somehow");
        Thread.Sleep(1500);
        Console.Write(" it looks incredible.");
        Thread.Sleep(4000);
        lists.AddItem("pavilion", -1, true);
      }

      lists.CurrentLocation = "Pavilion";
      Console.Clear();
      Console.WriteLine($"You are at the -{lists.CurrentLocation}-");
      Thread.Sleep(500);
      Console.WriteLine("");
      Console.WriteLine("--What do you want to do?--");
      Console.WriteLine("1. Travel to a different location");
      Console.WriteLine("2. Check status");
      Console.WriteLine("3. Walk up to the center of the pavilion");
      Console.WriteLine("4. Walk around the pavilion");
      try
      {
        lists.ModifyInt("Input", Convert.ToInt32(Console.ReadLine()));
      }
      catch
      {
        Console.Clear();
        Console.WriteLine("Invalid input");
        Thread.Sleep(1500);
        Pavilion();
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
          Console.WriteLine("You walk up the stairs to the pavilion.");
          Thread.Sleep(2500);
          Console.WriteLine("You see benches along the railing.");
          Thread.Sleep(3000);
          Console.WriteLine("");
          pavilionCenter:
          Console.WriteLine("--What do you want to do?--");
          Console.WriteLine("1. Look around for anything useful");
          Console.WriteLine("2. Sit down and relax for a minute");
          Console.WriteLine("3. Leave");
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
            goto pavilionCenter;
          }

          switch (lists.GetValue("Input"))
          {
            case 1:
              if (!lists.CheckBool("pavilionSearch"))
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
                lists.AddItem("pavilionSearch", -1, true);
                lists.AddItem("Credit Card", 0, true);
              }
              else
              {
                Console.Clear();
                Console.WriteLine("There is nothing more to find here.");
                Thread.Sleep(3000);
              }

              goto pavilionCenter;
            case 2:
              Console.Clear();
              Console.WriteLine("You sit down on one of the benches.");
              Thread.Sleep(2500);
              Console.Write("There is not a sound to be heard");
              Thread.Sleep(2500);
              Console.Write(", somehow");
              Thread.Sleep(1500);
              Console.WriteLine(", complete silence.");
              Thread.Sleep(2000);
              Console.Write("A gentle breeze tickles your chin");
              Thread.Sleep(2500);
              Console.WriteLine(" as you embrace the quiet.");
              Thread.Sleep(2500);
              Console.WriteLine("You enjoy the tranquility a for a minute.");
              Thread.Sleep(5000);
              Console.Clear();
              Console.WriteLine("You feel invigorated by the break.");
              Thread.Sleep(3000);
              if (!lists.CheckBool("pavilionCenter"))
              {
                Console.WriteLine("You are at full HP");
                Thread.Sleep(2500);
                lists.ModifyInt("HP", 100);
                lists.Hp();
                lists.AddItem("pavilionCenter", -1, true);
              }

              goto pavilionCenter;
            case 3:
              continue;
            default:
              Console.Clear();
              Console.WriteLine("Invalid input");
              Thread.Sleep(1500);
              Console.Clear();
              goto pavilionCenter;
          }
        }
        case 4:
        {
          if (!lists.CheckBool("pavilionAround"))
          {
            Console.Clear();
            Console.WriteLine("You walk around the base of the pavilion");
            Thread.Sleep(3000);
            Console.Write("It is full of flowers");
            Thread.Sleep(2000);
            Console.WriteLine("in all sorts of beautiful colors.");
            Thread.Sleep(2500);
            Console.Write("It all looks perfectly normal");
            Thread.Sleep(2000);
            Console.WriteLine(" until you walk past two weird looking flowers.");
            Thread.Sleep(3000);
            Console.WriteLine("One of the flowers is significantly larger than the other.");
            Thread.Sleep(3500);
            Console.Write("They look");
            Thread.Sleep(1500);
            Console.WriteLine(" faded");
            Thread.Sleep(1500);
            Console.WriteLine(", almost dead");
            Thread.Sleep(1500);
            Console.WriteLine(", colorless.");
            Thread.Sleep(2500);
            lists.AddItem("pavilionAround", -1, true);
          }
          else
          {
            Console.Clear();
            Console.WriteLine("You walk around the base of the pavilion.");
            Thread.Sleep(3000);
            Console.WriteLine("The two flowers are still there.");
            Thread.Sleep(2500);
          }

          Console.WriteLine("Maybe some Water could help?");
          Thread.Sleep(3000);
          Console.WriteLine("");
          pavilionWater:
          Console.WriteLine("--What do you want to do?--");
          Console.WriteLine("1. Leave");
          if (lists.CheckBool("Water") && !lists.CheckBool("pavilionBigFlower"))
            Console.WriteLine("2. Water the big flower");
          if (lists.CheckBool("Water") && !lists.CheckBool("pavilionSmallFlower"))
            Console.WriteLine("3. Water the small flower");
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
            goto pavilionWater;
          }

          switch (lists.GetValue("Input"))
          {
            case 1:
              break;
            case 2:
              if (lists.CheckBool("Water") && !lists.CheckBool("pavilionBigFlower"))
              {
                Console.Clear();
                Console.WriteLine("You water the big flower.");
                Thread.Sleep(2500);
                lists.AddItem("Water", 0, false);
                Console.Write("It sprouts to life ");
                Thread.Sleep(1500);
                Console.WriteLine(" and grows even bigger.");
                Thread.Sleep(2500);
                Console.Write("Then it opens it's mouth");
                Thread.Sleep(2000);
                Console.WriteLine(" with rows and rows of massive sharp teeth.");
                Thread.Sleep(3000);
                Console.Write("Before you can react");
                Thread.Sleep(2000);
                Console.WriteLine(" it lunges towards you and takes a bite of your arm.");
                Thread.Sleep(3500);
                Console.WriteLine("-70 HP");
                Thread.Sleep(2000);
                lists.ModifyValue("HP", i => i - 70);
                lists.Hp();
                lists.AddItem("pavilionBigFlower", -1, true);
              }
              else if (lists.CheckBool("pavilionBigFlower"))
              {
                Console.Clear();
                Console.WriteLine("That big flower is still there.");
                Thread.Sleep(2500);
                Console.WriteLine("Does not seem smart to approach it.");
                Thread.Sleep(3000);
              }

              break;
            case 3:
              if (lists.CheckBool("Water") && !lists.CheckBool("pavilionSmallFlower"))
              {
                Console.Clear();
                Console.WriteLine("You water the small flower.");
                Thread.Sleep(2500);
                lists.AddItem("Water", 0, false);
                Console.Write("It sprouts to life");
                Thread.Sleep(2000);
                Console.WriteLine(" and becomes full of beautiful vibrant colors.");
                Thread.Sleep(3000);
                Console.WriteLine("It is almost like the flower is smiling at you.");
                Thread.Sleep(3000);
                Console.WriteLine("Suddenly, it drops $100 on the ground in front of you.");
                Thread.Sleep(4000);
                lists.ModifyValue("Money", i => i + 100);
                lists.AddItem("pavilionSmallFlower", -1, true);
              }
              else if (lists.CheckBool("pavilionSmallFlower"))
              {
                Console.Clear();
                Console.WriteLine("The small flower is still there.");
                Thread.Sleep(2500);
                Console.WriteLine("It looks much healthier than before.");
                Thread.Sleep(3500);
              }

              break;
            default:
              Console.Clear();
              goto pavilionWater;
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