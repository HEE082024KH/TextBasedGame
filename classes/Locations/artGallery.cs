using TextBasedGame.classes;

public class ArtGallery(Locations locations)
{
  private readonly Items items = locations.Items;
  private readonly Status? status = locations.Status;
  private bool artGallery;

  public void Art()
  {
    while (true)
    {
      if (!artGallery)
      {
        Console.Clear();
        Console.WriteLine("");
        Thread.Sleep(2000);
        artGallery = true;
      }

      locations.CurrentLocation = "ArtGallery";
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
        Art();
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
          status?.ShowStatus();
          continue;
        }
        case 3:
        {
          continue;
        }
        case 4:
        {
          continue;
        }
        default:
        {
          Console.Clear();
          Console.Write("Invalid input");
          Thread.Sleep(1500);
          break;
        }
      }

      break;
    }
  }
}