public class Items
{
    public bool hasFlashlight;
    public bool hasHairpin;
    public bool hasCrowbar;
    public bool hasKnife;
    public bool hasGateKey;
    public int hasWound;
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