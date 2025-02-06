public class Start()
{
  private Structures structures;
  public bool newGame = false;

  public void NewGame()
  {
    Console.Write("... ");
    Thread.Sleep(1000);
    Console.Write("hmm ... ");
    Thread.Sleep(1000);
    Console.Write("what ... ");
    Thread.Sleep(1000);
    Console.Write("slowly");
    Thread.Sleep(1000);
    Console.WriteLine(", you start to regain consciousness.");
    Thread.Sleep(3000);
    Console.Write("You try to get on your feet");
    Thread.Sleep(2500);
    Console.Write(", clumsily");
    Thread.Sleep(1500);
    Console.WriteLine(", stumbling.");
    Thread.Sleep(2000);
    Console.WriteLine("Your eyes finally open enough for you to realize your surroundings.");
    Thread.Sleep(3500);
    Console.Clear();
    structures.Clouds();
    Thread.Sleep(2000);
    Console.WriteLine("");
    Console.Write("It's dark");
    Thread.Sleep(2000);
    Console.Write(", almost pitch black");
    Thread.Sleep(2000);
    Console.WriteLine(", only the moon adding some semblance of light.");
    Thread.Sleep(3000);
    Console.Write("This place feels unfamiliar to you");
    Thread.Sleep(2000);
    Console.WriteLine(", uncomfortable.");
    Thread.Sleep(2000);
    Console.Write("It's quiet");
    Thread.Sleep(2000);
    Console.Write(", too quiet");
    Thread.Sleep(2000);
    Console.WriteLine(", gives you an eerie feeling in your stomach.");
    Thread.Sleep(3000);
    Console.Write("Unsure of where, what, and how");
    Thread.Sleep(2000);
    Console.WriteLine(", you look around for somewhere to start finding a way out of here.");
    Thread.Sleep(5000);
    Console.Clear();
  }
}