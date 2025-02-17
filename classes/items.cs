namespace TextBasedGame.classes;

public class Item
{
  public required string Name;
  private readonly bool Exists;
  private readonly int Amount;

  public required List<Item> Items;

  public Item(string name, bool exists, int amount)
  {
    Name = name;
    Exists = exists;
    Amount = amount;
  }

  public void ShowInventory()
  {
    // Items.Add(new Item(Name, Exists, Amount));
  }
}

public class Items(Locations locations, Items items)
{
  // MONEY AVAILABLE: $375
  // MONEY SPENDABLE: $585
  //
  // UNUSED ITEMS:
  // Water, Batteries, Gun + GunMagazine, Credit Card
  //
  // ITEMS DON'T EXIST:
  // GateKey

  public bool GateKey;
  public bool Flashlight;
  public bool Hairpin;
  public bool Crowbar;
  public bool Knife;
  public int Bandages;
  public int Alcohol;
  public bool IsBuzzed;
  public bool IsDrunk;
  public bool IsHammered;
  public bool Key;
  public bool GreenGem;
  public bool OfficeKeycard;
  public bool NecklaceQuest;
  public bool Necklace;
  public bool DogBone;
  public bool MachineGun;
  public bool Coin;
  public bool Gun;
  public bool GunMagazine;
  public bool ShelterKey;
  public bool Water;
  public bool Batteries;
  public bool CreditCard;
  public int Money;
  public int HealthPoints = 80;

  public void Hp()
  {
    if (HealthPoints > 0)
    {
      return;
    }

    Console.WriteLine("You died from too many serious wounds");
    Thread.Sleep(2000);
    Console.WriteLine("---GAME OVER---");
    Console.WriteLine("");
    Console.WriteLine("Press Enter to exit");
    Console.ReadLine();
    Environment.Exit(0);
  }
}