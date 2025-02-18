namespace TextBasedGame.classes;

public class Variable(string name, int amount, bool exists = false)
{
  public string Name { get; set; } = name;

  public bool Exists { get; set; } = exists;
  public int Amount { get; set; } = amount;
}

public class Lists()
{
  public required List<Variable> Variables { get; set; }
  public required List<Variable> Inventory { get; set; }

  public void Item()
  {
  }

  public void AddItem(string name, bool exists, int amount)
  {
    Variables.Add(new Variable(name, amount, exists));
  }

  public void DisplayExistingItemsAndAmount()
  {
    Variables.ForEach(item => Console.WriteLine($"{item.Name} amount is: {item.Amount}"));
  }

  public void DisplayInventory()
  {
    Variables.Where(item => item.Exists).ToList()
      .ForEach(item => Console.WriteLine($"{item.Name} amount is: {item.Amount}"));
  }
}

public class Items()
{
  // MONEY AVAILABLE: $475
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