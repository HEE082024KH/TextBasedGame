using TextBasedGame.classes;

public class ShopLocation(Locations locations)
{
  private readonly Items items = locations.items;
  private readonly Status status = locations.status;
  private bool shopOutside;
  private bool subwayToShop;
  private bool insideShop;

  private void BuyItems()
  {
    Console.Clear();
    Console.WriteLine("--What do you want to buy?--");
    Console.WriteLine("1. Leave");
    Console.WriteLine("");
    Console.WriteLine("- Machine Gun");
    Console.WriteLine("- Bandages");
    Console.WriteLine("- Alcohol");
    try
    {
      locations.ItemInput = Console.ReadLine()?.ToLower();
    }
    catch
    {
      Console.WriteLine("Invalid input");
      Thread.Sleep(1500);
      BuyItems();
    }

    switch (locations.ItemInput)
    {
      case "machine gun":
      case "machinegun":
        if (items.Money >= 500)
        {
          Console.WriteLine("You bought the Machine Gun for $500");
          Thread.Sleep(3000);
          items.Money -= 500;
          items.MachineGun = true;
        }
        else
        {
          Console.WriteLine("You do not have enough money.");
          Thread.Sleep(2500);
        }

        Console.Clear();
        break;
      case "alcohol":
        if (items.Money >= 50)
        {
          Console.WriteLine("You bought a bottle of Alcohol for $50");
          Thread.Sleep(2500);
          items.Alcohol += 1;
          items.Money -= 50;
        }
        else
        {
          Console.WriteLine("You do not have enough money.");
          Thread.Sleep(2500);
        }

        Console.Clear();
        break;
      case "bandages":
      case "bandage":
        if (items.Money >= 25)
        {
          Console.WriteLine("You bought a Bandage for $25");
          Thread.Sleep(2500);
          items.Bandages += 1;
          items.Money -= 25;
        }
        else
        {
          Console.WriteLine("You do not have enough money.");
          Thread.Sleep(2500);
        }

        Console.Clear();
        break;
      case "1":
        Console.Clear();
        break;
      default:
        BuyItems();
        break;
    }
  }

  private void SellItems()
  {
    Console.Clear();
    Console.WriteLine("--What do you want to sell?--");
    Console.WriteLine("1. Leave");
    Console.WriteLine("");
    if (items.Knife)
    {
      Console.WriteLine("- Knife");
    }

    if (items.Necklace)
    {
      Console.WriteLine("- Necklace");
    }

    if (items.GreenGem)
    {
      Console.WriteLine("- Green Gem");
    }

    if (items.Coin)
    {
      Console.WriteLine("- Coin");
    }

    if (items.Gun)
    {
      Console.WriteLine("- Gun");
    }

    if (items.Alcohol > 0)
    {
      Console.WriteLine("- Alcohol");
    }

    if (items.Bandages > 0)
    {
      Console.WriteLine("- Bandages");
    }

    try
    {
      locations.ItemInput = Console.ReadLine()?.ToLower();
    }
    catch
    {
      Console.WriteLine("Invalid input");
      Thread.Sleep(1500);
      SellItems();
    }

    switch (locations.ItemInput)
    {
      case "knife":
        Console.WriteLine("You sold the Knife for $5");
        Thread.Sleep(2500);
        items.Money += 5;
        break;
      case "green gem":
      case "greengem":
        Console.WriteLine("You sold the Green Gem for $200");
        Thread.Sleep(2500);
        items.Money += 200;
        break;
      case "necklace":
        Console.WriteLine("You sold the necklace for $100");
        Thread.Sleep(2500);
        items.Money += 100;
        break;
      case "coin":
        Console.WriteLine("You sold the Coin for $25");
        Thread.Sleep(2500);
        items.Money += 25;
        break;
      case "gun":
        Console.WriteLine("You sold the Gun for $50");
        Thread.Sleep(2500);
        items.Money += 50;
        break;
      case "alcohol":
        sellAlcohol:
        Console.WriteLine($"How many do you want to sell? (Currently have {items.Alcohol})");
        try
        {
          locations.Input = Convert.ToInt32(Console.ReadLine());
        }
        catch
        {
          Console.WriteLine("Invalid input");
          Thread.Sleep(1500);
          Console.Clear();
          goto sellAlcohol;
        }

        if (locations.Input > 0 && locations.Input <= items.Alcohol)
        {
          Console.WriteLine($"You sold {locations.Input} bottles of Alcohol for ${locations.Input * 20}");
          Thread.Sleep(2500);
          items.Alcohol -= Convert.ToInt32(locations.Input);
          items.Money += 20 * Convert.ToInt32(locations.Input);
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
        Console.WriteLine($"How many do you want to sell? (Currently have {items.Bandages})");
        Console.WriteLine($"1. Leave");
        try
        {
          locations.Input = Convert.ToInt32(Console.ReadLine());
        }
        catch
        {
          Console.WriteLine("Invalid input");
          Thread.Sleep(1500);
          Console.Clear();
          goto sellBandages;
        }

        if (locations.Input > 0 && locations.Input <= items.Bandages)
        {
          Console.WriteLine($"You sold {locations.Input} Bandages for ${locations.Input * 10}");
          Thread.Sleep(2500);
          items.Bandages -= Convert.ToInt32(locations.Input);
          items.Money += 10 * Convert.ToInt32(locations.Input);
          SellItems();
        }
        else if (locations.ItemInput == "1")
        {
          SellItems();
        }
        else
        {
          Console.WriteLine("You do not have that many Bandages.");
          Thread.Sleep(2000);
          goto sellBandages;
        }

        break;
      case "1":
        Console.Clear();
        break;
      default:
        SellItems();
        break;
    }
  }

  public void Shop()
  {
    if (locations.CurrentLocation == "Subway Entrance" && !subwayToShop)
    {
      Console.Clear();
      Console.Write("On your way to the Shop");
      Thread.Sleep(1500);
      Console.WriteLine(", you encounter a pack of dogs.");
      Thread.Sleep(2000);
      Console.WriteLine("It is hard to tell if they are aggressive or not.");
      Thread.Sleep(3000);
      Console.WriteLine("");
      subwayToShop:
      Console.WriteLine("--What do you want to do?");
      Console.WriteLine("1. Crouch and try to pet them");
      Console.WriteLine("2. Attack them");
      Console.WriteLine("3. Run");
      try
      {
        locations.Input = Convert.ToInt32(Console.ReadLine());
      }
      catch
      {
        Console.Clear();
        Console.WriteLine("Invalid input");
        Thread.Sleep(1500);
        Console.Clear();
        goto subwayToShop;
      }

      switch (locations.Input)
      {
        case 1:
          Console.Clear();
          Console.WriteLine("You crouch down and extend your hand to pet them.");
          Thread.Sleep(2500);
          Console.Write("Slowly");
          Thread.Sleep(1000);
          Console.WriteLine(", they approach you.");
          Thread.Sleep(1500);
          Console.WriteLine("As they get closer you notice their features.");
          Thread.Sleep(2500);
          Console.Write("Brown spotted fur");
          Thread.Sleep(1500);
          Console.Write(", spots of missing flesh");
          Thread.Sleep(1500);
          Console.WriteLine(", a few missing tails and ears.");
          Thread.Sleep(1500);
          Console.WriteLine("And you realize you might have made a bad choice.");
          Thread.Sleep(3000);
          Console.WriteLine("");
          subwayToShopDogs:
          Console.WriteLine("--What do you want to do?--");
          Console.WriteLine("1. Stay crouched and try to pet them");
          Console.WriteLine("2. Get up and run");
          try
          {
            locations.Input = Convert.ToInt32(Console.ReadLine());
          }
          catch
          {
            Console.Clear();
            Console.WriteLine("Invalid input");
            Thread.Sleep(1500);
            Console.Clear();
            goto subwayToShopDogs;
          }

          switch (locations.Input)
          {
            case 1:
              Console.Clear();
              Console.WriteLine("You stay still holding your hand out.");
              Thread.Sleep(2000);
              Console.Write("As the dogs approach you");
              Thread.Sleep(1500);
              Console.WriteLine(", they start to circle around you.");
              Thread.Sleep(2500);
              Console.Write("Then");
              Thread.Sleep(1500);
              Console.WriteLine(", the biggest of the dogs approaches you.");
              Thread.Sleep(2500);
              Console.Write("He sniffs your hand");
              Thread.Sleep(1500);
              Console.WriteLine(", perhaps considering to have a bite.");
              Thread.Sleep(2500);
              Console.Write("He nudges your hand away");
              Thread.Sleep(1500);
              Console.Write(", jumps on top of you");
              Thread.Sleep(1500);
              Console.WriteLine(", and starts licking your face.");
              Thread.Sleep(2500);
              Console.WriteLine("You ruffle his fur as you pet him");
              Thread.Sleep(2000);
              Console.WriteLine("He backs off you.");
              Thread.Sleep(1500);
              Console.WriteLine("One of the other dogs approaches a drops a BONE for you.");
              Thread.Sleep(3500);
              Console.WriteLine("Then they nonchalantly walk off");
              Thread.Sleep(3000);
              items.DogBone = true;
              break;
            case 2:
              Console.Clear();
              Console.Write("You are barely able to stand up");
              Thread.Sleep(1500);
              Console.WriteLine(", before they jump you.");
              Thread.Sleep(2000);
              Console.Write("You feel searing pain");
              Thread.Sleep(1500);
              Console.WriteLine(" as they all sink their teeth into your flesh.");
              Thread.Sleep(3500);
              Console.Write("You can see your blood");
              Thread.Sleep(1500);
              Console.WriteLine(" pooling around you.");
              Thread.Sleep(2000);
              Console.Write("You vision blurs");
              Thread.Sleep(1500);
              Console.WriteLine(" as you violently scream in agony and pain.");
              Thread.Sleep(3000);
              Console.WriteLine("Until everything goes black-");
              Thread.Sleep(2000);
              items.HealthPoints = 0;
              items.Hp();
              break;
          }

          break;
        case 2:
          if (items.MachineGun)
          {
            Console.Clear();
            Console.WriteLine("You pull out your machine gun and spray the dogs with bullet.");
            Thread.Sleep(3500);
            Console.WriteLine("All of the dogs are taken out before any of them could get close.");
            Thread.Sleep(3500);
          }
          else
          {
            Console.Clear();
            Console.Write("You look for a viable weapon amongst your things");
            Thread.Sleep(3000);
            Console.WriteLine(", but none seem powerful enough.");
            Thread.Sleep(2000);
            Console.WriteLine("Desperately you start throwing what you have at them");
            Thread.Sleep(3000);
            Console.Write("Except for a few bumps and scratches");
            Thread.Sleep(2000);
            Console.WriteLine(" they keep charging you.");
            Thread.Sleep(2000);
            Console.Write("As they reach you");
            Thread.Sleep(1500);
            Console.Write(" they all jump fangs first");
            Thread.Sleep(2000);
            Console.Write("You feel searing pain");
            Thread.Sleep(1500);
            Console.WriteLine(" as they all sink their teeth into your flesh.");
            Thread.Sleep(3500);
            Console.Write("You can see your blood");
            Thread.Sleep(1500);
            Console.WriteLine(" pooling around you.");
            Thread.Sleep(2000);
            Console.Write("You vision blurs");
            Thread.Sleep(1500);
            Console.WriteLine(" as you violently scream in agony and pain.");
            Thread.Sleep(3000);
            Console.WriteLine("Until everything goes black-");
            Thread.Sleep(2000);
            items.HealthPoints = 0;
            items.Hp();
          }

          break;
        case 3:
          Console.Clear();
          Console.Write("Without hesitation");
          Thread.Sleep(1000);
          Console.WriteLine(" you start running as fast as you can.");
          Thread.Sleep(2000);
          Console.Write("As you look back");
          Thread.Sleep(1500);
          Console.Write(" you see them chasing after you");
          Thread.Sleep(2000);
          Console.WriteLine(", catching up quickly.");
          Thread.Sleep(2000);
          Console.WriteLine("You can see the Shop ahead of you in the distance.");
          Thread.Sleep(3000);
          Console.Write("You reach the Shop and manage to jump the fence");
          Thread.Sleep(2000);
          Console.WriteLine(", just as they leap forward to have a nibble");
          Thread.Sleep(3000);
          Console.Write("Breathing heavily");
          Thread.Sleep(1500);
          Console.WriteLine(", you look through the fence at the rapid dogs just out of reach.");
          Thread.Sleep(4000);
          break;
      }

      subwayToShop = true;
    }

    locations.CurrentLocation = "Shop";
    Console.Clear();
    Console.WriteLine($"You are at the -{locations.CurrentLocation}-");
    Thread.Sleep(500);
    Console.WriteLine("");
    Console.WriteLine("--What do you want to do?--");
    Console.WriteLine("1. Travel to a different location");
    Console.WriteLine("2. Check status");
    Console.WriteLine("3. Enter the shop");
    Console.WriteLine("4. Look around outside");
    try
    {
      locations.Input = Convert.ToInt32(Console.ReadLine());
    }
    catch
    {
      Console.Clear();
      Console.WriteLine("Invalid input");
      Thread.Sleep(1500);
      Shop();
    }

    switch (locations.Input)
    {
      case 1:
      {
        locations.LocationSelector();
        break;
      }
      case 2:
      {
        Console.Clear();
        status.ShowStatus();
        Shop();
        break;
      }
      case 3:
      {
        if (!insideShop)
        {
          Console.Clear();
          Console.WriteLine("As you enter the shop you hear faint music humming in the background.");
          Thread.Sleep(3000);
          Console.WriteLine("The walls are sparsely filled with random trinkets and items.");
          Thread.Sleep(3000);
          Console.Write("There does not seem to be anyone here.");
          Thread.Sleep(2500);
          Console.Write(" It all seems a bit");
          Thread.Sleep(1500);
          Console.WriteLine(", off.");
          Thread.Sleep(1500);
          Console.Write("You go over to the register");
          Thread.Sleep(1500);
          Console.WriteLine(", a small creature behind the counter groans towards you.");
          Thread.Sleep(3000);
          Console.WriteLine("You jump, as they stare at you with a stern look.");
          Thread.Sleep(2500);
          Console.Write("You try asking him about what he sells");
          Thread.Sleep(2000);
          Console.WriteLine(" but he just points to a sign behind him,");
          Thread.Sleep(2000);
          Console.WriteLine("before grunting and retreating to the back room.");
          Thread.Sleep(3000);
          Console.Write("The sign seams simple enough though");
          Thread.Sleep(2000);
          Console.WriteLine(", luckily.");
          Thread.Sleep(1500);
          Console.Write("Pick item.");
          Thread.Sleep(1500);
          Console.Write(" Have money.");
          Thread.Sleep(1500);
          Console.Write(" Ring bell.");
          Thread.Sleep(1500);
          Console.Write(" Pay.");
          Thread.Sleep(1500);
          Console.WriteLine(" Fuck off!");
          Thread.Sleep(3000);
          Console.WriteLine("");
          insideShop = true;
        }

        insideShop:
        Console.WriteLine("--What do you want to do?--");
        Console.WriteLine("1. Buy something");
        Console.WriteLine("2. Sell something");
        Console.WriteLine("3. Look around the shop");
        Console.WriteLine("4. Leave");
        try
        {
          locations.Input = Convert.ToInt32(Console.ReadLine());
        }
        catch
        {
          Console.Clear();
          Console.WriteLine("Invalid input");
          Thread.Sleep(1500);
          Console.Clear();
          goto insideShop;
        }

        switch (locations.Input)
        {
          case 1:
            BuyItems();
            goto insideShop;
          case 2:
            SellItems();
            goto insideShop;
          case 3:
            break;
          case 4:
            Shop();
            break;
        }

        break;
      }
      case 4:
      {
        if (!shopOutside)
        {
          Console.Write("You walk around outside the shop");
          Thread.Sleep(2500);
          Console.WriteLine(", looking for anything useful.");
          Thread.Sleep(2000);
          Console.WriteLine("Around the back you find a few bags of trash.");
          Thread.Sleep(2500);
          Console.WriteLine("");
          shopOutside:
          Console.WriteLine("--What do you want to do?--");
          Console.WriteLine("1. Search the bags");
          Console.WriteLine("2. Leave them alone");
          try
          {
            locations.Input = Convert.ToInt32(Console.ReadLine());
          }
          catch
          {
            Console.Clear();
            Console.WriteLine("Invalid input");
            Thread.Sleep(1500);
            Console.Clear();
            goto shopOutside;
          }

          switch (locations.Input)
          {
            case 1:
              Console.WriteLine("You search the bags for anything useful.");
              Thread.Sleep(2000);
              Console.Write("To your surprise you find some loose change");
              Thread.Sleep(2000);
              Console.WriteLine(", about 5 bucks.");
              Thread.Sleep(2000);
              items.Money += 5;
              shopOutside = true;
              Shop();
              break;
            case 2:
              Shop();
              break;
          }
        }

        Console.WriteLine("There is nothing more to find here.");
        Thread.Sleep(2000);
        Shop();
        break;
      }
      default:
      {
        Console.Clear();
        Console.Write("Invalid input");
        Thread.Sleep(1500);
        Shop();
        break;
      }
    }
  }
}