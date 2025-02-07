using System.Reflection.PortableExecutable;

public class Items(Locations locations)
{
  // MONEY AVAILABLE: $365
  // MONEY SPENDABLE: $585
  //
  // ITEMS
  // Flashlight (!exist)
  // GateKey (!exist)
  // DogBone (!used)

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
    Console.WriteLine("--GAME OVER--");
    Console.Write(">");
    Console.ReadLine();
    Environment.Exit(0);
  }

  public void BuyItems()
  {
    Console.WriteLine("--What do you want to buy?--");
    Console.WriteLine("1. Leave");
    Console.WriteLine("");
    Console.WriteLine("- Machine Gun");
    Console.WriteLine("- ");
    Console.WriteLine("- ");
    Console.WriteLine("- Bandages");
    Console.WriteLine("- Alcohol");
    try
    {
      locations.itemInput = Console.ReadLine()?.ToLower();
    }
    catch
    {
      Console.WriteLine("Invalid input");
      Thread.Sleep(1500);
      BuyItems();
    }

    switch (locations.itemInput)
    {
      case "machine gun":
      case "machinegun":
        Console.WriteLine("You bought the Machine Gun for $500");
        Thread.Sleep(2500);
        Money -= 500;
        MachineGun = true;
        break;
      case "2":
        break;
      case "3":
        break;
      case "alcohol":
        Console.WriteLine("You bought a bottle of Alcohol for $50");
        Thread.Sleep(2500);
        Alcohol += 1;
        Money -= 50;
        break;
      case "bandages":
      case "bandage":
        Console.WriteLine("You bought a Bandage for $25");
        Thread.Sleep(2500);
        Bandages += 1;
        Money -= 25;
        break;
      case "1":
        break;
      default:
        BuyItems();
        break;
    }
  }

  public void SellItems()
  {
    Console.WriteLine("--What do you want to sell?--");
    Console.WriteLine("1. Leave");
    Console.WriteLine("");
    if (Knife)
    {
      Console.WriteLine("Knife");
    }

    if (Necklace)
    {
      Console.WriteLine("Necklace");
    }

    if (GreenGem)
    {
      Console.WriteLine("Green Gem");
    }

    if (Alcohol > 0)
    {
      Console.WriteLine("Alcohol");
    }

    if (Bandages > 0)
    {
      Console.WriteLine("Bandages");
    }

    try
    {
      locations.itemInput = Console.ReadLine()?.ToLower();
    }
    catch
    {
      Console.WriteLine("Invalid input");
      Thread.Sleep(1500);
      SellItems();
    }

    switch (locations.itemInput)
    {
      case "knife":
        Console.WriteLine("You sold the Knife for $5");
        Thread.Sleep(2500);
        Money += 5;
        break;
      case "green gem":
      case "greengem":
        Console.WriteLine("You sold the Green Gem for $200");
        Thread.Sleep(2500);
        Money += 200;
        break;
      case "necklace":
        Console.WriteLine("You sold the necklace for $100");
        Thread.Sleep(2500);
        Money += 100;
        break;
      case "alcohol":
        sellAlcohol:
        Console.WriteLine($"How many do you want to sell? (Currently have {Alcohol})");
        try
        {
          locations.input = Convert.ToInt32(Console.ReadLine());
        }
        catch
        {
          Console.WriteLine("Invalid input");
          Thread.Sleep(1500);
          Console.Clear();
          goto sellAlcohol;
        }

        if (locations.input > 0 && locations.input <= Alcohol)
        {
          Console.WriteLine($"You sold {locations.input} bottles of Alcohol for ${locations.input * 20}");
          Thread.Sleep(2500);
          Alcohol -= Convert.ToInt32(locations.input);
          Money += 20 * Convert.ToInt32(locations.input);
        }
        else
        {
          Console.WriteLine("You do not have that much Alcohol.");
          Thread.Sleep(2000);
          goto sellAlcohol;
        }

        break;
      case "bandages":
      case "bandage":
        sellBandages:
        Console.WriteLine($"How many do you want to sell? (Currently have {Bandages})");
        try
        {
          locations.input = Convert.ToInt32(Console.ReadLine());
        }
        catch
        {
          Console.WriteLine("Invalid input");
          Thread.Sleep(1500);
          Console.Clear();
          goto sellBandages;
        }

        if (locations.input > 0 && locations.input <= Bandages)
        {
          Console.WriteLine($"You sold {locations.input} Bandages for ${locations.input * 10}");
          Thread.Sleep(2500);
          Bandages -= Convert.ToInt32(locations.input);
          Money += 10 * Convert.ToInt32(locations.input);
        }
        else
        {
          Console.WriteLine("You do not have that many Bandages.");
          Thread.Sleep(2000);
          goto sellBandages;
        }

        break;
      case "1":
        break;
      default:
        SellItems();
        break;
    }
  }
}