using TextBasedGame.classes;

public class OfficeBuilding(Locations locations)
{
  private readonly Items items = locations.Items;
  private readonly Status? status = locations.Status;
  private bool office;

  public void Office()
  {
    if (!office)
    {
      Console.Clear();
      Console.WriteLine("");
      Thread.Sleep(2000);
      office = true;
    }

    locations.CurrentLocation = "OfficeBuilding";
    Console.Clear();
    Console.WriteLine($"You are at the -{locations.CurrentLocation}-");
    Thread.Sleep(500);
    Console.WriteLine("");
    Console.WriteLine("--What do you want to do?--");
    Console.WriteLine("1. Travel to a different location");
    Console.WriteLine("2. Check status");
    Console.WriteLine("3. Exit through the gate");
    Console.WriteLine("4. Look around for anything useful");
    try
    {
      locations.Input = Convert.ToInt32(Console.ReadLine());
    }
    catch
    {
      Console.Clear();
      Console.WriteLine("Invalid input");
      Thread.Sleep(1500);
      Office();
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
        Office();
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
        Office();
        break;
      }
    }
  }
}