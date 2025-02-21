namespace TextBasedGame.classes;

public class Variable(string name, int amount, bool exists = false, bool tradeable = false)
{
  public string Name { get; } = name;
  public int Amount { get; set; } = amount;
  public bool Exists { get; set; } = exists;
  public bool Tradeable { get; set; } = tradeable;
}

public class Lists(Locations locations)
{
  public string CurrentLocation = "";

  private List<Variable> Variables { get; } =
  [
    // Permanent items/states
    new("HP", 80),
    new("Money", 0),
    new("Input", 0),
    new("ItemInput", 0),
    new("IsBuzzed", -1),
    new("IsDrunk", -1),
    new("IsHammered", -1),

    // Location/events
    new("gate", -1),
    new("apartments", -1),
    new("insideApartments", -1),
    new("insideApartmentsWindow", -1),
    new("insideApartmentsDoor2", -1),
    new("insideApartmentsDoor2Done", -1),
    new("insideApartmentsDoor4Done", -1),
    new("insideApartmentsDoor4Kill", -1),
    new("insideApartmentsDoor4KillHands", -1),
    new("insideApartmentsDoor4Steal", -1),
    new("insideApartmentsDoor4Talk", -1),
    new("necklaceQuest", -1),
    new("shop", -1),
    new("shopOutside", -1),
    new("subwayToShop", -1),
    new("insideShop", -1),
    new("subway", -1),
    new("subwayEntrance", -1),
    new("subwayFlashlight", -1),
    new("apartmentsToSubway", -1),
    new("pavilion", -1),
    new("pavilionCenter", -1),
    new("pavilionSearch", -1),
    new("pavilionAround", -1),
    new("pavilionBigFlower", -1),
    new("pavilionSmallFlower", -1),
    new("fountain", -1),
    new("fountainSit", -1),
    new("shelter", -1),
    new("insideShelter", -1),
    new("insideShelterTake", -1),
    new("travelFromShelter", -1),
    new("alley", -1),
    new("artGallery", -1),
    new("office", -1),
    new("shack", -1),
    new("warehouse", -1),
    new("pavilionToWarehouse", -1),

    // Items
    new("Gate Key", 0),
    new("Flashlight", 0, tradeable: true),
    new("Hairpin", 0),
    new("Crowbar", 0, tradeable: true),
    new("Knife", 0, tradeable: true),
    new("Bandages", 0, tradeable: true),
    new("Alcohol", 0, tradeable: true),
    new("Key", 0),
    new("Green Gem", 0, tradeable: true),
    new("Office Keycard", 0),
    new("Necklace", 0, tradeable: true),
    new("Dog Bone", 0),
    new("Machine Gun", 0, tradeable: true),
    new("Coin", 0, tradeable: true),
    new("Gun", 0, tradeable: true),
    new("Gun Magazine", 0),
    new("Shelter Key", 0),
    new("Water", 0, tradeable: true),
    new("Batteries", 0, tradeable: true),
    new("Credit Card", 0),
    // new("", 0),
  ];

  public void AddItem(string name, int amount, bool exists)
  {
    var item = Variables.FirstOrDefault(v => v.Name == name);
    if (item != null)
    {
      item.Amount = amount; // Update the amount
      item.Exists = exists; // Update the exists flag
    }
  }

  public void ModifyInt(string name, int amount)
  {
    var item = Variables.FirstOrDefault(v => v.Name == name);
    if (item != null)
    {
      item.Amount = amount;
      item.Amount = Convert.ToInt32(Console.ReadLine());
      ;
    }
  }

  public void ModifyValue(string name, Func<int, int> amount)
  {
    var item = Variables.FirstOrDefault(v => v.Name == name);
    if (item != null)
    {
      item.Amount = amount(item.Amount);
    }
  }

  public bool CheckBool(string name)
  {
    return Variables.Where(i => i.Name == name).Select(i => i.Exists).FirstOrDefault();
  }

  public int GetValue(string name)
  {
    return Variables.Where(i => i.Name == name).Select(i => i.Amount).FirstOrDefault();
  }

  public void DisplayInventory()
  {
    // perm items, >1, false - Hidden
    // Variables.Where(item => !item.Exists && item.Amount >= 1).ToList()
    //   .ForEach(item => Console.WriteLine($"- {item.Amount} {item.Name}"));

    // add items, >=1, true - Top of inventory
    Variables.Where(item => item.Exists && item.Amount >= 1).ToList()
      .ForEach(item => Console.WriteLine($"- {item.Amount} {item.Name}"));
    Console.WriteLine("");
    // add items, 0, true - Bottom of inventory
    Variables.Where(item => item.Exists && item.Amount == 0).ToList()
      .ForEach(item => Console.WriteLine($"- {item.Name}"));
  }

  public void DisplayExistingItemsAndAmount()
  {
    // all items 0, false - Hidden, json?, for save/load
    Variables.ForEach(item =>
      Console.WriteLine($"- {item.Amount} {item.Name} {item.Exists}"));
  }

  public void Hp()
  {
    if (GetValue("HP") > 0)
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