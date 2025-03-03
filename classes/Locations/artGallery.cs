using TextBasedGame.classes;

public class ArtGallery(Locations locations, Lists lists, Status status)
{
  public void Art()
  {
    while (true)
    {
      if (!lists.CheckBool("artGallery"))
      {
        Console.Clear();
        Console.WriteLine("");
        Thread.Sleep(2000);
        lists.AddItem("artGallery", -1, true);
      }

      lists.CurrentLocation = "ArtGallery";
      Console.Clear();
      Console.WriteLine($"You are at the -{lists.CurrentLocation}-");
      Thread.Sleep(500);
      Console.WriteLine("");
      Console.WriteLine("--What do you want to do?--");
      Console.WriteLine("1. Travel to a different location");
      Console.WriteLine("2. Check status");
      Console.WriteLine("3. ");
      Console.WriteLine("4. ");
      try
      {
        lists.ModifyInt("Input", Convert.ToInt32(Console.ReadLine()));
      }
      catch
      {
        Console.Clear();
        Console.WriteLine("Invalid input");
        Thread.Sleep(1500);
        Art();
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