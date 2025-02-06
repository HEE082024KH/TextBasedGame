public class ShopLocation(Locations locations)
{
  private readonly Items items = locations.items;
  private readonly Locations locations = locations;
  private readonly Status status = new(locations, locations.items);
  private bool shopOutside;

  public void Shop()
  {
    if (locations.currentLocation == "Subway Entrance")
    {
      Console.Clear();
      Console.Write("On your way to the Shop");
      Thread.Sleep(1500);
      Console.WriteLine(", you encounter a pack of dogs.");
      Thread.Sleep(2000);
      Console.WriteLine("It is hard to tell if they are aggressive or not.");
      Thread.Sleep(3000);
      Console.WriteLine("");
      subwayToShop:
      Console.WriteLine("--What do you want to do?");
      Console.WriteLine("1. Crouch and try to pet them");
      Console.WriteLine("2. Attack them");
      Console.WriteLine("3. Run");
      try
      {
        locations.input = Convert.ToInt32(Console.ReadLine());
      }
      catch
      {
        Console.WriteLine("Invalid input");
        Thread.Sleep(1500);
        Console.Clear();
        goto subwayToShop;
      }

      switch (locations.input)
      {
        case 1:
          Console.WriteLine("You crouch down and extend your hand to pet them.");
          Thread.Sleep(2500);
          Console.Write("Slowly");
          Thread.Sleep(1000);
          Console.WriteLine(", they approach you.");
          Thread.Sleep(1500);
          Console.WriteLine("As they get closer you notice their features.");
          Thread.Sleep(2500);
          Console.Write("Brown spotted fur");
          Thread.Sleep(1500);
          Console.Write(", spots of missing flesh");
          Thread.Sleep(1500);
          Console.WriteLine(", a few missing tails and ears.");
          Thread.Sleep(1500);
          Console.WriteLine("And you realize you might have made a bad choice.");
          Thread.Sleep(3000);
          Console.WriteLine("");
          subwayToShopDogs:
          Console.WriteLine("--What do you want to do?--");
          Console.WriteLine("1. Stay crouched and try to pet them");
          Console.WriteLine("2. Get up and run");
          try
          {
            locations.input = Convert.ToInt32(Console.ReadLine());
          }
          catch
          {
            Console.WriteLine("Invalid input");
            Thread.Sleep(1500);
            goto subwayToShopDogs;
          }

          switch (locations.input)
          {
            case 1:
              Console.WriteLine("You stay still holding your hand out.");
              Thread.Sleep(2000);
              Console.Write("As the dogs approach you");
              Thread.Sleep(1500);
              Console.WriteLine(", they start to circle around you.");
              Thread.Sleep(2500);
              Console.Write("Then");
              Thread.Sleep(1500);
              Console.WriteLine(", the biggest of the dogs approaches you.");
              Thread.Sleep(2500);
              Console.Write("He sniffs your hand");
              Thread.Sleep(1500);
              Console.WriteLine(", perhaps considering to have a bite.");
              Thread.Sleep(2500);
              Console.Write("He nudges your hand away");
              Thread.Sleep(1500);
              Console.Write(", jumps on top of you");
              Thread.Sleep(1500);
              Console.WriteLine(", and starts licking your face.");
              Thread.Sleep(2500);
              Console.WriteLine("You ruffle his fur as you pet him");
              Thread.Sleep(2000);
              Console.Write("He backs off you.");
              Thread.Sleep(1500);
              Console.WriteLine("One of the other dogs approaches a drops a BONE for you.");
              Thread.Sleep(3500);
              break;
            case 2:
              ;
              break;
          }

          break;
        case 2:
          ;
          break;
        case 3:
          ;
          break;
      }
    }

    locations.currentLocation = "Shop";
    Console.Clear();
    Console.WriteLine($"You are at the  -{locations.currentLocation}-");
    Thread.Sleep(500);
    Console.WriteLine("--What do you want to do?--");
    Console.WriteLine("1. Travel to a different location");
    Console.WriteLine("2. Check status");
    Console.WriteLine("3. Enter the shop");
    Console.WriteLine("4. Look around outside");
    try
    {
      locations.input = Convert.ToInt32(Console.ReadLine());
    }
    catch
    {
      Console.Clear();
      Console.WriteLine("Invalid input");
      Thread.Sleep(1500);
      Shop();
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
        Shop();
        break;
      }
      case 3:
      {
        break;
      }
      case 4:
      {
        if (!shopOutside)
        {
          Console.Write("You walk around outside the shop");
          Thread.Sleep(2500);
          Console.WriteLine(", looking for anything useful.");
          Thread.Sleep(2000);
          Console.WriteLine("Around the back you find a few bags of trash.");
          Thread.Sleep(2500);
          Console.WriteLine("");
          shopOutside:
          Console.WriteLine("--What do you want to do?--");
          Console.WriteLine("1. Search the bags");
          Console.WriteLine("2. Leave them alone");
          try
          {
            locations.input = Convert.ToInt32(Console.ReadLine());
          }
          catch
          {
            Console.Clear();
            Console.WriteLine("Invalid input");
            Thread.Sleep(1500);
            goto shopOutside;
          }

          switch (locations.input)
          {
            case 1:
              Console.WriteLine("You search the bags for anything useful.");
              Thread.Sleep(2000);
              Console.Write("To your surprise you find some loose change");
              Thread.Sleep(2000);
              Console.WriteLine(", about 5 bucks.");
              Thread.Sleep(2000);
              items.Money += 5;
              shopOutside = true;
              Shop();
              break;
            case 2:
              Shop();
              break;
          }
        }

        Console.WriteLine("There is nothing more to find here.");
        Thread.Sleep(2000);
        Shop();
        break;
      }
      default:
      {
        Console.Clear();
        Console.Write("--Invalid input--");
        Thread.Sleep(1000);
        Shop();
        break;
      }
    }
  }
}