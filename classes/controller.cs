public class Controller
{
  Locations locations = new();
  public void LocationSelector()
  {
    switch (locations.input)
    {
      case 1:
        locations.currentLocation = "Gate";
        break;
      case 2:
        locations.currentLocation = "Apartments";
        break;
      case 3:
        locations.currentLocation = "Subway Entrance";
        break;
      case 4:
        locations.currentLocation = "Shop";
        break;
      case 5:
        locations.currentLocation = "Art Gallery";
        break;
      case 6:
        locations.currentLocation = "Office Building";
        break;
      case 7:
        locations.currentLocation = "Pavilion";
        break;
      case 8:
        locations.currentLocation = "Abandoned Warehouse";
        break;
      case 9:
        locations.currentLocation = "Bomb Shelter";
        break;
      case 10:
        locations.currentLocation = "Fountain";
        break;
      case 11:
        locations.currentLocation = "Alley";
        break;
      case 12:
        locations.currentLocation = "Shack";
        break;
    }
  }
}