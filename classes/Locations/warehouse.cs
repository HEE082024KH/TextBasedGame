public class AbandonedWarehouse(Locations locations)
{
  private readonly Items items = locations.items;
  private readonly Status status = new(locations, locations.items);
  private bool pavilionToWarehouse;

  public void Warehouse()
  {
    if (locations.currentLocation == "Pavilion" && !pavilionToWarehouse)
    {
      Console.Clear();
      Console.Write("On your way to the Warehouse");
      Thread.Sleep(1500);
      Console.WriteLine(", you encounter a strange man.");
      Thread.Sleep(2000);
      Console.WriteLine("It is hard to tell if he is friendly or not.");
      Thread.Sleep(3000);
      Console.WriteLine("");
      pavilionToWarehouse:
      Console.WriteLine("--What do you want to do?");
      Console.WriteLine("1. Talk with him");
      Console.WriteLine("2. Attack him");
      Console.WriteLine("3. Run");
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
        goto pavilionToWarehouse;
      }

      switch (locations.input)
      {
        case 1:
          Console.Clear();
          break;
        case 2:
          Console.Clear();
          if (items.MachineGun)
          {
            Console.WriteLine("You pull out the Machine Gun and fire multiple rounds towards him.");
            Thread.Sleep(3500);
            Console.Write("You catch him by surprise");
            Thread.Sleep(2000);
            Console.Write(", seeing as he just stands there");
            Thread.Sleep(2000);
            Console.WriteLine(" absorbing all the bullets.");
            Thread.Sleep(2000);
            Console.Write("His body drops like a stone");
            Thread.Sleep(2000);
            Console.WriteLine(", blood flowing everywhere.");
            Thread.Sleep(2000);
            Console.WriteLine("He does not have anything useful on him.");
            Thread.Sleep(2000);
          }
          else if (items.Knife || items.Crowbar)
          {
            if (items.Knife) Console.Write("You pull out your Knife");
            if (items.Crowbar) Console.Write("You pull out your Crowbar");
            Thread.Sleep(2000);
            Console.WriteLine(", but the man keeps walking towards you.");
            Thread.Sleep(2000);
            Console.Write("Either he does not notice");
            Thread.Sleep(2000);
            Console.WriteLine(" or he does not care.");
            Thread.Sleep(2000);
            Console.WriteLine("He approaches you.");
            Thread.Sleep(2000);
            Console.WriteLine("");
            warehouseAttackMan:
            Console.WriteLine("--What do you want to do?--");
            Console.WriteLine("1. Talk with him");
            Console.WriteLine("2. Attack him");
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
              goto warehouseAttackMan;
            }

            switch (locations.input)
            {
              case 1:
                Console.Clear();
                Console.Write("You put away your weapon");
                Thread.Sleep(2000);
                Console.WriteLine(" and try to talk with the man");
                Thread.Sleep(2000);
                break;
              case 2:
                Console.Clear();
                if (items.Knife)
                {
                  Console.WriteLine("You shove the knife into his stomach.");
                  Thread.Sleep(2500);
                  Console.Write("Blood start flowing from his wound");
                  Thread.Sleep(2500);
                  Console.WriteLine(" as you stab him again.");
                  Thread.Sleep(2000);
                  Console.Write("Over");
                  Thread.Sleep(1000);
                  Console.WriteLine(", and over again");
                  Thread.Sleep(2000);
                  Console.WriteLine("Until his body falls lifeless to the ground.");
                  Thread.Sleep(3500);
                  Console.WriteLine("You find 5 bucks in his pockets");
                  Thread.Sleep(2000);
                  items.Money += 5;
                }

                if (items.Crowbar)
                {
                  Console.Write("You swing the crowbar towards his head");
                  Thread.Sleep(2500);
                  Console.WriteLine(" almost taking his head off.");
                  Thread.Sleep(2000);
                  Console.Write("He falls over head first.");
                  Thread.Sleep(2000);
                  Console.WriteLine("His head opens as he hits the ground.");
                  Thread.Sleep(2500);
                  Console.WriteLine("Blood and brain pours out of his skull.");
                  Thread.Sleep(2000);
                  Console.WriteLine("You find 5 bucks in his pocket.");
                  Thread.Sleep(2000);
                  items.Money += 5;
                }

                break;
            }
          }
          else
          {
            Console.WriteLine("");
            Thread.Sleep(2000);
          }

          break;
        case 3:
          Console.Clear();
          Console.WriteLine("You sprint off as fast as you can.");
          Thread.Sleep(2500);
          Console.Write("The man does not follow you");
          Thread.Sleep(2000);
          Console.WriteLine(", he just looks bewildered and confused.");
          Thread.Sleep(3000);
          break;
      }

      pavilionToWarehouse = true;
    }

    locations.currentLocation = "AbandonedWarehouse";
    Console.Clear();
    Console.WriteLine($"You are at the  -{locations.currentLocation}-");
    Thread.Sleep(500);
    Console.WriteLine("---What do you want to do?---");
    Console.WriteLine("1. Travel to a different location");
    Console.WriteLine("2. Check status");
    Console.WriteLine("3. ");
    Console.WriteLine("4. ");
    try
    {
      locations.input = Convert.ToInt32(Console.ReadLine());
    }
    catch
    {
      Console.Clear();
      Console.WriteLine("Invalid input");
      Thread.Sleep(1500);
      Warehouse();
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
        break;
      }
      case 3:
      {
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
        Warehouse();
        break;
      }
    }
  }
}