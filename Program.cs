namespace TextBasedGame;

class Program
{
  static void Main(Controller controller)
  {
    // Run Game
    Console.SetWindowSize(Console.LargestWindowWidth, Console.LargestWindowHeight);
    controller.Run();
  }
}