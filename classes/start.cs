public class Start
{
  public bool newGame = true;
  public void NewGame()
  {
    Console.Write("...");
    Thread.Sleep(1000);
    Console.Write("\"Mhmm ...\"");
    Thread.Sleep(1000);
    Console.Write("\"What ... \"");
    Thread.Sleep(1000);
    Console.WriteLine("Abruptly a cold gust of wind yanks you from your slumber");
    Thread.Sleep(1000);
    Console.WriteLine("");
    Thread.Sleep(1000);
    Console.WriteLine("");
    Thread.Sleep(1000);
    Console.WriteLine("");
    Thread.Sleep(1000);
    Console.WriteLine("");
    Thread.Sleep(1000);
    Console.WriteLine("");
    newGame = false;
  }
}
