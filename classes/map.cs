namespace TextBasedGame.classes;

public static class Map
{
  public static void ShowMap()
  {
    Console.WriteLine("");
    Console.WriteLine("                   _       ,");
    Console.WriteLine("                  / \\_    / \\_                      /\\ __                    ");
    Console.WriteLine("           /\\    /    \\  /    \\,                  _/  /  \\                  ");
    Console.WriteLine("    _   __/  \\  /\\/\\  /\\/ :' __ \\_             _^/  ^/    `--.    /\\     ");
    Console.WriteLine("   / \\ /      \\/    \\/  \\  _/  \\-'\\           /.' ^_   \\_   .'\\  /  \\__    _");
    Console.WriteLine("  /   \\ .-'.--/\\  .-   `. \\/     \\ /==~=-=~=-=-;.  _/ \\ -. `_/  \\      \\^_/ ^\\");
    Console.WriteLine(" /.-'   /    /  `-.__ ^   / .-'.--\\ =-=~_=-=~=^/  _ `--./ .-'  `-  `--./  \\   \\ ");
    Console.WriteLine("/`._        /        `.  / /       `.~-^=-=~=^=.-'      '-._ `._   _.` _.-'    \\ ");
    Console.WriteLine("|                                                                               |");
    Console.WriteLine("|    +-------+              +--------+                                          |");
    Console.WriteLine("|    |       |              |  |  |  |                      /*_\\               |");
    Console.WriteLine("|    |       |--------------|  |  |  |---------------------/_ ^|                |");
    Console.WriteLine("|    +-------+      |       |  |  |  |           |         +---+                |");
    Console.WriteLine("|    6. Shelter     |       +--------+           |        1. Shack              |");
    Console.WriteLine("|                   |      3. Pavilion           |                              |");
    Console.WriteLine("|                   |                            |                              |");
    Console.WriteLine("| +-----------+     |   +----+                   |                              |");
    Console.WriteLine("| | ⬛ ⬛ ⬛ |     |---|    |                   |                              |");
    Console.WriteLine("| | ⬛ ⬛ ⬛ |     |   +----+                   |                              |");
    Console.WriteLine("| | ⬛ ⬛ ⬛ |     |  8. Alley                  |                              |");
    Console.WriteLine("| | ⬛ ⬛ ⬛ |     |                            |         +-----------------+  |");
    Console.WriteLine("| | ⬛ ⬛ ⬛ |     |        +--------+          |         |                 |  |");
    Console.WriteLine("| | ⬛ ⬛ ⬛ |     |        |        |        +---+       |                 |  |");
    Console.WriteLine("| | ⬛ ⬛ ⬛ |--------------|        |--------| o |-------|                 |  |");
    Console.WriteLine("| | ⬛ ⬛ ⬛ |     |        |        |        +---+       |                 |  |");
    Console.WriteLine("| | ⬛ ⬛ ⬛ |     |        +--------+     5. Fountain    |                 |  |");
    Console.WriteLine("| +-----------+     |        2. Subway                     +-----------------+  |");
    Console.WriteLine("| 4. Apartments     |          Entrance                         9. Shop         |");
    Console.WriteLine("|                   |                                                           |");
    Console.WriteLine("+--------------- 7. Gate -------------------------------------------------------+");
    Console.WriteLine("");
  }
}