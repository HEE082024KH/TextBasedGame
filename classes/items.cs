public class Items
{
  // ITEMS NOT IMPLEMENTED YET:
  // Flashlight
  // GateKey

  public bool Flashlight;
  public bool Hairpin;
  public bool Crowbar;
  public bool Knife;
  public bool GateKey;
  public bool Key;
  public int Bandages;
  public int Alcohol;
  public bool IsBuzzed;
  public bool IsDrunk;
  public bool IsHammered;
  public bool NecklaceQuest;
  public bool Necklace;
  public bool OfficeKeycard;
  public bool GreenGem;
  public int Money;
  public int HealthPoints = 80;

  public void Hp()
  {
    if (HealthPoints <= 0)
    {
      Console.WriteLine("You died from too many serious wounds");
      Thread.Sleep(2000);
      Console.WriteLine("--GAME OVER--");
      Console.Write(">");
      Console.ReadLine();
      Environment.Exit(0);
    }
  }
}