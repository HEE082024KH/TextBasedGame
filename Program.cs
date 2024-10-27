namespace TextBasedGame;

class Program
{
    static void Main(string[] args)
    {
        Map map = new();
        Travel travel = new();
        Controller controller = new();

        // Run Game
        controller.LocationSelector();
    }
}
