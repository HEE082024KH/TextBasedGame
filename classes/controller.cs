public class Controller
{
  Locations locations = new();
  Map map = new();
  public void LocationSelector()
  {
    map.ShowMap();
    Console.WriteLine("Where do you want to travel to?");
    Console.Write(">");
    locations.input = Convert.ToInt32(Console.ReadLine());
    switch (locations.input)
    {
      case 1:
        locations.currentLocation = "Gate";
        locations.Gate();
        break;
      case 2:
        locations.currentLocation = "Apartments";
        locations.Apartments();
        break;
      case 3:
        locations.currentLocation = "Subway Entrance";
        locations.SubwayEntrance();
        break;
      case 4:
        locations.currentLocation = "Shop";
        locations.Shop();
        break;
      case 5:
        locations.currentLocation = "Art Gallery";
        locations.ArtGallery();
        break;
      case 6:
        locations.currentLocation = "Office Building";
        locations.OfficeBuilding();
        break;
      case 7:
        locations.currentLocation = "Pavilion";
        locations.Pavilion();
        break;
      case 8:
        locations.currentLocation = "Abandoned Warehouse";
        locations.AbandonedWarehouse();
        break;
      case 9:
        locations.currentLocation = "Bomb Shelter";
        locations.BombShelter();
        break;
      case 10:
        locations.currentLocation = "Fountain";
        locations.Fountain();
        break;
      case 11:
        locations.currentLocation = "Alley";
        locations.Alley();
        break;
      case 12:
        locations.currentLocation = "Shack";
        locations.Shack();
        break;
      default:
        Console.WriteLine("Invalid input");
        break;
    }
  }
}