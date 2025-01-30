public class Items
{
    public bool hasFlashlight;
    public bool hasHairpin;
    public bool hasCrowbar;
    public bool hasKnife;
    public bool hasGateKey;
    public bool hasKey;
    public bool hasBandages;
    public int bandages;
    public bool hasAlcohol;
    public int alcohol;
    public bool isBuzzed;
    public bool isDrunk;
    public bool isHammered;
    public bool hasNecklaceQuest;
    public int healthPoints = 80;
    public void HP()
    {
        if (healthPoints <= 0)
        {
            Console.WriteLine("You died from too many serious wounds");
            Thread.Sleep(2000);
            Console.WriteLine("--GAME OVER--");
            Thread.Sleep(1500);
        }
    }
}