public class Map
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
    Console.WriteLine("|                              +---+           +-----------------------------+  |");
    Console.WriteLine("|  +-----------+               | B |           |                             |  |");
    Console.WriteLine("|  |           |            9. +---+           |                             |  |");
    Console.WriteLine("|  |           |____             |             |                             |  |");
    Console.WriteLine("|  |           |    |       +--------+         |                    +--------+  |");
    Console.WriteLine("|  |           |    |       |        |         |                    |           |");
    Console.WriteLine("|  +-----------+    --------|        |-----    |                    |           |");
    Console.WriteLine("|  8. Abandoned     |       |        |    |    +--------------------+           |");
    Console.WriteLine("|     Warehouse     |       +--------+    |       |  6. Office Building         |");
    Console.WriteLine("|                   |      7. Pavilion    --------|                             |");
    Console.WriteLine("|                   |                             |                             |");
    Console.WriteLine("| +----------+      |  +---+                      |        +-----------------+  |");
    Console.WriteLine("| |          |      |--| A |                      |        |                 |  |");
    Console.WriteLine("| |          |      |  +---+                      |        |                 |  |");
    Console.WriteLine("| |          |      |   12.    +--------+         |        |                 |  |");
    Console.WriteLine("| |          |      |          |        |       +---+      |                 |  |");
    Console.WriteLine("| |          |-----------------|        |-------| F |------|                 |  |");
    Console.WriteLine("| |          |      |          |        |       +---+      |                 |  |");
    Console.WriteLine("| |          |      |          +--------+     10. |        |                 |  |");
    Console.WriteLine("| |          |      |          3. Subway          |        +-----------------+  |");
    Console.WriteLine("| |          |      |            Entrance         |         5. Art Gallery      |");
    Console.WriteLine("| +----------+      |  +---+                  +--------+                        |");
    Console.WriteLine("| 2. Apartments     |--| S |                  |        |                        |");
    Console.WriteLine("|                   |  +---+                  |        |                        |");
    Console.WriteLine("|                   |       12.               |        |           +------------+");
    Console.WriteLine("|                   |                         +--------+           |");
    Console.WriteLine("|                   |                          4. Shop             |");
    Console.WriteLine("+--------------- 1. Gate ------------------------------------------+");
    Console.WriteLine("");
  }
}

public class Structures
{
  public static void Office()
  {
    Console.WriteLine("");
    Console.WriteLine("███████████████");
    Console.WriteLine("█⬛⬛⬛⬛⬛⬛█");
    Console.WriteLine("█⬛⬛⬛⬛⬛⬛█");
    Console.WriteLine("█⬛⬛⬛⬛⬛⬛█");
    Console.WriteLine("█⬛⬛⬛⬛⬛⬛█");
    Console.WriteLine("█⬛⬛⬛⬛⬛⬛█");
    Console.WriteLine("█⬛⬛⬛⬛⬛⬛█");
    Console.WriteLine("█⬛⬛⬛⬛⬛⬛█");
    Console.WriteLine("█⬛⬛⬛⬛⬛⬛█");
    Console.WriteLine("█⬛⬛⬛⬛⬛⬛█");
    Console.WriteLine("█⬛⬛⬛⬛⬛⬛█");
    Console.WriteLine("█⬛⬛⬛⬛⬛⬛█");
    Console.WriteLine("█⬛⬛⬛⬛⬛⬛█");
    Console.WriteLine("█⬛⬛⬛⬛⬛⬛█");
    Console.WriteLine("█⬛⬛⬛⬛⬛⬛█");
    Console.WriteLine("█⬛⬛⬛⬛⬛⬛█");
    Console.WriteLine("");
  }

  public static void Gate()
  {
    Console.WriteLine("");
    Console.WriteLine("                   _                      _                _");
    Console.WriteLine("    ____________ .' '.    _____/----/-\\ .' './========\\   / \\");
    Console.WriteLine("   //// ////// /V_.-._\\  |.-.-.|===| _ |-----| u    u |  /___\\");
    Console.WriteLine("  // /// // ///==\\ u |.  || | ||===||||| |T| |   ||   | .| u |_ _ _ _ _ _");
    Console.WriteLine(" ///////-\\////====\\==|:::::::::::::::::::::::::::::::::::|u u| U U U U U");
    Console.WriteLine(" |----/\\u |--|++++|..|'''''''''''::::::::::::::''''''''''|+++|+-+-+-+-+-+");
    Console.WriteLine(" |u u|u | |u ||||||..|              '::::::::'           |===|>=== _ _ ==");
    Console.WriteLine(" |===|  |u|==|++++|==|              .::::::::.           | T |....| V |..");
    Console.WriteLine(" |u u|u | |u ||HH||         \\|/    .::::::::::.");
    Console.WriteLine(" |===|_.|u|_.|+HH+|_              .::::::::::::.              _");
    Console.WriteLine("                __(_)___         .::::::::::::::.         ___(_)__");
    Console.WriteLine("---------------/  / \\  /|       .:::::;;;:::;;:::.       |\\  / \\  \\-------");
    Console.WriteLine("______________/_______/ |      .::::::;;:::::;;:::.      | \\_______\\_______");
    Console.WriteLine("|       |     [===  =] /|     .:::::;;;::::::;;;:::.     |\\ [==  = ]   |");
    Console.WriteLine("|_______|_____[ = == ]/ |    .:::::;;;:::::::;;;::::.    | \\[ ===  ]___|___");
    Console.WriteLine("     |       |[  === ] /|   .:::::;;;::::::::;;;:::::.   |\\ [=  ===] |");
    Console.WriteLine("_____|_______|[== = =]/ |  .:::::;;;::::::::::;;;:::::.  | \\[ ==  =]_|_____");
    Console.WriteLine(" |       |    [ == = ] /| .::::::;;:::::::::::;;;::::::. |\\ [== == ]      |");
    Console.WriteLine("_|_______|____[=  == ]/ |.::::::;;:::::::::::::;;;::::::.| \\[  === ]______|");
    Console.WriteLine("   |       |  [ === =] /.::::::;;::::::::::::::;;;:::::::.\\ [===  =]   |");
    Console.WriteLine("___|_______|__[ == ==]/.::::::;;;:::::::::::::::;;;:::::::.\\[=  == ]___|___");
    Console.WriteLine("");
  }

  public static void Warehouse()
  {
    Console.WriteLine("");
    Console.WriteLine("            )   )                       (       )  (");
    Console.WriteLine("           (    (             _____       )     (    )");
    Console.WriteLine("   __[]___[]___[]___[]___[]__/_____\\[]___[]___[]___[]___[]___    )");
    Console.WriteLine("  /__________________________|     |__________________________\\   (");
    Console.WriteLine("  |  [] []     [] []     [] []     [] []     [] []     [] []  |     )");
    Console.WriteLine("  |         |         |         |         |         |         |    (");
    Console.WriteLine("  |  [] []     [] []     [] []     [] []     [] []     [] []  |___[]___");
    Console.WriteLine("  |         |         |         |         |         |         |        \\");
    Console.WriteLine("  |||||||[]||||||||[]||||||||[]||||||||[]||||||||[]||||||||[]||         \\");
    Console.WriteLine("  |         |         |         |         |         |         |__________\\");
    Console.WriteLine("  |  [] []     [] []     [] []     [] []     [] []     [] []     [] []   |");
    Console.WriteLine("  |         |         |         |         |         |                    |");
    Console.WriteLine("  |  [] []     [] []     [] []     [] []     [] []     [] []     [] []   |");
    Console.WriteLine("  |         |         |         |         |         |                    |");
    Console.WriteLine("  ||[]||||||||[]||||||||[]||||||||[]||||||||[]||||||||[]||||||||[]||||||||");
    Console.WriteLine("  ========================================================================");
    Console.WriteLine("");
  }

  public static void Apartments()
  {
    Console.WriteLine("");
    Console.WriteLine(" _____________________________________________");
    Console.WriteLine("|.'',                                     ,''.|");
    Console.WriteLine("|.'.'',                                 ,''.'.|");
    Console.WriteLine("|.'.'.'',                             ,''.'.'.|");
    Console.WriteLine("|.'.'.'.'',                         ,''.'.'.'.|");
    Console.WriteLine("|.'.'.'.'.|                         |.'.'.'.'.|");
    Console.WriteLine("|.'.'.'.'.|===;                 ;===|.'.'.'.'.|");
    Console.WriteLine("|.'.'.'.'.|:::|',             ,'|:::|.'.'.'.'.|");
    Console.WriteLine("|.'.'.'.'.|---|'.|, _______ ,|.'|---|.'.'.'.'.|");
    Console.WriteLine("|.'.'.'.'.|:::|'.|'|???????|'|.'|:::|.'.'.'.'.|");
    Console.WriteLine("|,',',',',|---|',|'|???????|'|,'|---|,',',',',|");
    Console.WriteLine("|.'.'.'.'.|:::|'.|'|???????|'|.'|:::|.'.'.'.'.|");
    Console.WriteLine("|.'.'.'.'.|---|','   /%%%\\   ','|---|.'.'.'.'.|");
    Console.WriteLine("|.'.'.'.'.|===:'    /%%%%%\\    ':===|.'.'.'.'.|");
    Console.WriteLine("|.'.'.'.'.|%%%%%%%%%%%%%%%%%%%%%%%%%|.'.'.'.'.|");
    Console.WriteLine("|.'.'.'.','       /%%%%%%%%%\\       ','.'.'.'.|");
    Console.WriteLine("|.'.'.','        /%%%%%%%%%%%\\        ','.'.'.|");
    Console.WriteLine("|.'.','         /%%%%%%%%%%%%%\\         ','.'.|");
    Console.WriteLine("|.','          /%%%%%%%%%%%%%%%\\          ','.|");
    Console.WriteLine("|;____________/%%%%%%%%%%%%%%%%%\\____________;|");
    Console.WriteLine("");
  }

  public static void FancyHouse()
  {
    Console.WriteLine("");
    Console.WriteLine("                 _ _.-'`-._ _");
    Console.WriteLine("                ;.'________'.;");
    Console.WriteLine("     _________n.[____________].n_________");
    Console.WriteLine("    |\"\"_\"\"_\"\"_\"\"||==||==||==||\"\"_\"\"_\"\"_\"\"]");
    Console.WriteLine("    |\"\"\"\"\"\"\"\"\"\"\"||..||..||..||\"\"\"\"\"\"\"\"\"\"\"|");
    Console.WriteLine("    |LI LI LI LI||LI||LI||LI||LI LI LI LI|");
    Console.WriteLine("    |.. .. .. ..||..||..||..||.. .. .. ..|");
    Console.WriteLine("    |LI LI LI LI||LI||LI||LI||LI LI LI LI|");
    Console.WriteLine(" ,,;;,;;;,;;;,;;;,;;;,;;;,;;;,;;,;;;,;;;,;;,,");
    Console.WriteLine(";;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;");
    Console.WriteLine("");
  }

  public static void Clouds()
  {
    Console.WriteLine("");
    Console.WriteLine("                _         ");
    Console.WriteLine("              (`  ).                   _");
    Console.WriteLine("             (     ).              .:(`  )`. ");
    Console.WriteLine(")           _(       '`.          :(   .    )");
    Console.WriteLine("        .=(`(      .   )     .--  `.  (    ) )");
    Console.WriteLine("       ((    (..__.:'-'   .+(   )   ` _`  ) )");
    Console.WriteLine("`.     `(       ) )       (   .  )     (   )  ._");
    Console.WriteLine("  )      ` __.:'   )     (   (   ))     `-'.-(`  )");
    Console.WriteLine(")  )  ( )       --'       `- __.'         :(      ))");
    Console.WriteLine(".-'  (_.'          .')                    `(    )  ))");
    Console.WriteLine("                  (_  )                     ` __.:'");
    Console.WriteLine("");
    Console.WriteLine("--..,___.--,--'`,---..-.--+--.,,-,,..._.--..-._.--:---.");
    Console.WriteLine("");
  }

  public static void Computer()
  {
    Console.WriteLine("");
    Console.WriteLine("                       .,,uod8B8bou,,.");
    Console.WriteLine("              ..,uod8BBBBBBBBBBBBBBBBRPFT?l!i:.");
    Console.WriteLine("         ,=m8BBBBBBBBBBBBBBBRPFT?!||||||||||||||");
    Console.WriteLine("         !...:!TVBBBRPFT||||||||||!!^^\"\"'   ||||");
    Console.WriteLine("         !.......:!?|||||!!^^\"\"'            ||||");
    Console.WriteLine("         !.........||||                     ||||");
    Console.WriteLine("         !.........||||  ##                 ||||");
    Console.WriteLine("         !.........||||                     ||||");
    Console.WriteLine("         !.........||||                     ||||");
    Console.WriteLine("         !.........||||                     ||||");
    Console.WriteLine("         !.........||||                     ||||");
    Console.WriteLine("         `.........||||                    ,||||");
    Console.WriteLine("          .;.......||||               _.-!!|||||");
    Console.WriteLine("   .,uodWBBBBb.....||||       _.-!!|||||||||!:'");
    Console.WriteLine("!YBBBBBBBBBBBBBBb..!|||:..-!!|||||||!iof68BBBBBb....");
    Console.WriteLine("!..YBBBBBBBBBBBBBBb!!||||||||!iof68BBBBBBRPFT?!::   `.");
    Console.WriteLine("!....YBBBBBBBBBBBBBBbaaitf68BBBBBBRPFT?!:::::::::     `.");
    Console.WriteLine("!......YBBBBBBBBBBBBBBBBBBBRPFT?!::::::;:!^\"`;:::       `.");
    Console.WriteLine("!........YBBBBBBBBBBRPFT?!::::::::::^''...::::::;         iBBbo.");
    Console.WriteLine("`..........YBRPFT?!::::::::::::::::::::::::;iof68bo.      WBBBBbo.");
    Console.WriteLine("  `..........:::::::::::::::::::::::;iof688888888888b.     `YBBBP^'");
    Console.WriteLine("    `........::::::::::::::::;iof688888888888888888888b.     `");
    Console.WriteLine("      `......:::::::::;iof688888888888888888888888888888b.");
    Console.WriteLine("        `....:::;iof688888888888888888888888888888888899fT!");
    Console.WriteLine("          `..::!8888888888888888888888888888888899fT|!^\"'");
    Console.WriteLine("            `' !!988888888888888888888888899fT|!^\"'");
    Console.WriteLine("                `!!8888888888888888899fT|!^\"'");
    Console.WriteLine("                  `!988888888899fT|!^\"'");
    Console.WriteLine("                    `!9899fT|!^\"'");
    Console.WriteLine("                      `!^\"'");
    Console.WriteLine("");
  }
}