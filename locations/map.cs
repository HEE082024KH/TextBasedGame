public class Map
{
    public string currentLocation = "";
    public static string ShowMap()
    {
        Console.WriteLine("");
        Console.WriteLine("                              +---+           +-----------------------------+");
        Console.WriteLine("  +-----------+               | B |           |                             |");
        Console.WriteLine("  |           |               +---+           |                             |");
        Console.WriteLine("  |           |____             |             |                             |");
        Console.WriteLine("  |           |    |       +--------+         |                    +--------+");
        Console.WriteLine("  |           |    |       |        |         |                    |");
        Console.WriteLine("  +-----------+    --------|        |-----    |                    |");
        Console.WriteLine("    Abandoned      |       |        |    |    +--------------------+");
        Console.WriteLine("    Warehouse      |       +--------+    |       |  Office Building");
        Console.WriteLine("                   |        Pavilion     --------|");
        Console.WriteLine("                   |                             |");
        Console.WriteLine(" +----------+      | +---+                       |        +---------------+");
        Console.WriteLine(" |          |      |-| A |                       |        |               |");
        Console.WriteLine(" |          |      | +---+                       |        |               |");
        Console.WriteLine(" |          |      |          +--------+         |        |               |");
        Console.WriteLine(" |          |      |          |        |       +---+      |               |");
        Console.WriteLine(" |          |-----------------|        |-------| F |------|               |");
        Console.WriteLine(" |          |      |          |        |       +---+      |               |");
        Console.WriteLine(" |          |      |          +--------+         |        |               |");
        Console.WriteLine(" |          |      |            Subway           |        +---------------+");
        Console.WriteLine(" |          |      |           Entrance          |           Art Gallery");
        Console.WriteLine(" +----------+      |  +---+                  +--------+");
        Console.WriteLine("  Apartments       |--| S |                  |        |");
        Console.WriteLine("                   |  +---+                  |        |");
        Console.WriteLine("                   |                         |        |");
        Console.WriteLine("                   |                         +--------+");
        Console.WriteLine("                  Gate                          Shop");
        Console.WriteLine("");
        Console.WriteLine($"You are at: currentLocation");
        return "";
    }

}