namespace TextBasedGame.classes;

public class Variable(string name, int amount, bool exists = false)
{
  public string Name { get; set; } = name;
  public bool Exists { get; set; } = exists;
  public int Amount { get; set; } = amount;
}

public class Lists(Locations locations)
{
  public List<Variable> Variables { get; set; } =
  [
    new("CurrentLocation", 0),
    new("Input", 0),
    new("ItemInput", 0),
    new("gate", 0),
    new("apartments", 0),
    new("insideApartments", 0),
    new("insideApartmentsWindow", 0),
    new("insideApartmentsDoor2", 0),
    new("insideApartmentsDoor2Done", 0),
    new("insideApartmentsDoor4Done", 0),
    new("insideApartmentsDoor4Kill", 0),
    new("insideApartmentsDoor4KillHands", 0),
    new("insideApartmentsDoor4Steal", 0),
    new("insideApartmentsDoor4Talk", 0),
    new("shop", 0),
    new("shopOutside", 0),
    new("subwayToShop", 0),
    new("insideShop", 0),
    new("subway", 0),
    new("subwayEntrance", 0),
    new("subwayFlashlight", 0),
    new("apartmentsToSubway", 0),
    new("pavilion", 0),
    new("pavilionCenter", 0),
    new("pavilionSearch", 0),
    new("pavilionAround", 0),
    new("pavilionBigFlower", 0),
    new("pavilionSmallFlower", 0),
    new("fountain", 0),
    new("fountainSit", 0),
    new("shelter", 0),
    new("insideShelter", 0),
    new("insideShelterTake", 0),
    new("travelFromShelter", 0),
    new("GateKey", 0),
    new("Flashlight", 0),
    new("Hairpin", 0),
    new("Crowbar", 0),
    new("Knife", 0),
    new("Bandages", 0),
    new("Alcohol", 0),
    new("IsBuzzed", 0),
    new("IsDrunk", 0),
    new("IsHammered", 0),
    new("Key", 0),
    new("GreenGem", 0),
    new("OfficeKeycard", 0),
    new("NecklaceQuest", 0),
    new("Necklace", 0),
    new("DogBone", 0),
    new("MachineGun", 0),
    new("Coin", 0),
    new("Gun", 0),
    new("GunMagazine", 0),
    new("ShelterKey", 0),
    new("Water", 0),
    new("Batteries", 0),
    new("CreditCard", 0),
    new("Money", 0),
    new("HealthPoints", 80),
    new("alley", 0),
    new("artGallery", 0),
    new("office", 0),
    new("shack", 0),
    new("warehouse", 0),
    new("pavilionToWarehouse", 0),
    // new("", 0),
  ];

  public void AddItem(string name, int amount, bool exists)
  {
    string? item = Console.ReadLine();
    Variables.Find(item => item.Name == name).Exists = exists;
    // Variables.Add(new Variable(name, amount, exists));
  }

  public void DisplayExistingItemsAndAmount()
  {
    Variables.ForEach(item =>
      Console.WriteLine($"- {item.Amount} {item.Name}"));
  }

  public void DisplayInventory()
  {
    Variables.Where(item => item.Exists).ToList()
      .ForEach(item => Console.WriteLine($"- {item.Amount} {item.Name}"));
  }
}

public class Items
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