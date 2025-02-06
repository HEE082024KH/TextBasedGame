public class ShopLocation(Locations locations)
{
  private readonly Items items = locations.items;
  private readonly Locations locations = locations;
  private readonly Status status = new(locations, locations.items);

  public void Shop()
  {
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
            ;
            break;
          case 2:
            ;
            break;
        }

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