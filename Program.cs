namespace TextBasedGame;

class Program
{
    static void Main(string[] args)
    {
        Map map = new();
        Travel travel = new();
        Locations locations = new();
        map.ShowMap();
        travel.MapOptions();
    }
}
