public class AbandonedWarehouse(Locations locations)
{
  private readonly Items items = locations.items;
  private readonly Locations locations = locations;
  private readonly Status status = new(locations, locations.items);
  private bool pavilionToWarehouse;

  public void Warehouse()
  {
    if (locations.currentLocation == "Pavilion" && !pavilionToWarehouse)
    {
      Console.Clear();
      Console.Write("On your way to the Warehouse");
      Thread.Sleep(1500);
      Console.WriteLine(", you encounter a pack of dogs.");
      Thread.Sleep(2000);
      Console.WriteLine("It is hard to tell if they are aggressive or not.");
      Thread.Sleep(3000);
      Console.WriteLine("");
      pavilionToWarehouse:
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
          break;
        case 3:
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
    Console.WriteLine("3. Exit through the gate");
    Console.WriteLine("4. Look around for anything useful");
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