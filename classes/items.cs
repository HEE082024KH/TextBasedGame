public class Items
{
    public int hasWound;
    public bool hasFlashlight = false;
    public bool hasHairpin = false;
    public void Wounds()
    {
        if (hasWound <= 3)
        {
            hasWound++;
        }
        if (hasWound >= 3)
        {
            Console.WriteLine("You died from too many serious wounds");
            Thread.Sleep(2000);
            Console.WriteLine("--GAME OVER--");
            Thread.Sleep(1500);
            return;
        }
    }
}