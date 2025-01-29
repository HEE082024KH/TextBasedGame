public class Items
{
    public bool hasFlashlight;
    public bool hasHairpin;
    public bool hasCrowbar;
    public bool hasKnife;
    public bool hasGateKey;
    public bool hasKey;
    public bool hasBandage;
    public bool hasAlcohol;
    public int healthPoints = 80;
    public void HP()
    {
        if (healthPoints <= 0)
        {
            Console.WriteLine("You died from too many serious wounds");
            Thread.Sleep(2000);
            Console.WriteLine("--GAME OVER--");
            Thread.Sleep(1500);
            return;
        }
    }
}