using TextBasedGame.classes;

public class ShopLocation(Locations locations, Lists lists, Status status)
{
  private void BuyItems()
  {
    while (true)
    {
      Console.Clear();
      Console.WriteLine("--What do you want to buy?--");
      Console.WriteLine("0. Leave");
      Console.WriteLine("");
      Console.WriteLine("1. Machine Gun");
      Console.WriteLine("2. Bandages");
      Console.WriteLine("3. Alcohol");
      try
      {
        lists.ModifyInt("Input", Convert.ToInt32(Console.ReadLine()));
      }
      catch
      {
        Console.Clear();
        Console.WriteLine("Invalid input");
        Thread.Sleep(1500);
        BuyItems();
      }

      switch (lists.GetValue("Input"))
      {
        case 1:
          if (lists.GetValue("Money") >= 500)
          {
            Console.WriteLine("You bought the Machine Gun for $500");
            Thread.Sleep(3000);
            lists.ModifyValue("Money", i => i - 500);
            lists.AddItem("Machine Gun", 0, true);
          }
          else
          {
            Console.WriteLine("You do not have enough money.");
            Thread.Sleep(2500);
          }

          break;
        case 2:
          if (lists.GetValue("Money") >= 50)
          {
            Console.WriteLine("You bought a bottle of Alcohol for $50");
            Thread.Sleep(2500);
            lists.ModifyValue("Alcohol", i => i + 1);
            lists.ModifyValue("Money", i => i - 50);
          }
          else
          {
            Console.WriteLine("You do not have enough money.");
            Thread.Sleep(2500);
          }

          break;
        case 3:
          if (lists.GetValue("Money") >= 25)
          {
            Console.WriteLine("You bought a Bandage for $25");
            Thread.Sleep(2500);
            lists.ModifyValue("Bandages", i => i + 1);
            lists.ModifyValue("Money", i => i - 25);
          }
          else
          {
            Console.WriteLine("You do not have enough money.");
            Thread.Sleep(2500);
          }

          break;
        case 0:
          break;
        default:
          continue;
      }

      Console.Clear();
      break;
    }
  }

  private void SellItems()
  {
    Console.Clear();
    Console.WriteLine("--What do you want to sell?--");
    Console.WriteLine("1. Leave");
    Console.WriteLine("");
    var sellables = lists.Variables.Where(item => item.Tradeable && item.Amount >= 1);
    foreach (var item in sellables)
    {
      Console.WriteLine($"{lists.Variables.IndexOf(item)}. {item.Name}");
    }

    try
    {
      lists.ModifyInt("Input", Convert.ToInt32(Console.ReadLine()));
    }
    catch
    {
      Console.Clear();
      Console.WriteLine("Invalid input");
      Thread.Sleep(1500);
      SellItems();
    }

    var items = sellables.Where((_, index) => index == lists.GetValue("Input"))
      .FirstOrDefault();
    if (items.Name == "Bandages" || items.Name == "Alcohol")
    {
      sell:
      Console.WriteLine($"How many do you want to sell? (Currently have {lists.GetValue($"{items.Name}")})");
      Console.WriteLine("0. Leave");
      try
      {
        lists.ModifyInt("Input", Convert.ToInt32(Console.ReadLine()));
      }
      catch
      {
        Console.Clear();
        Console.WriteLine("Invalid input");
        Thread.Sleep(1500);
        Console.Clear();
        goto sell;
      }

      if (lists.GetValue("Input") > 0 && lists.GetValue("Input") <= lists.GetValue($"{items.Amount}"))
      {
        Console.WriteLine(
          $"You sold {lists.GetValue("Input")} {items.Name} for ${lists.GetValue("Input")} * {items.SellAmount}");
        Thread.Sleep(2500);
        lists.ModifyValue("Bandages", i => i - lists.GetValue("Input"));
        lists.ModifyValue("Money", i => i + 10 * Convert.ToInt32(lists.GetValue("Input")));
        SellItems();
      }
      else if (lists.GetValue("Input") == 0)
      {
        SellItems();
      }
      else
      {
        Console.Clear();
        Console.WriteLine("You do not have that many Bandages.");
        Thread.Sleep(2000);
        goto sell;
      }
    }

    Console.WriteLine($"You sold the {items.Name} for ${items.SellAmount}");
    Thread.Sleep(2500);
    lists.ModifyValue("Money", i => i + items.SellAmount);
  }

  public void Shop()
  {
    if (lists.CurrentLocation == "Subway Entrance" && !lists.CheckBool("subwayToShop"))
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
        lists.ModifyInt("Input", Convert.ToInt32(Console.ReadLine()));
      }
      catch
      {
        Console.Clear();
        Console.WriteLine("Invalid input");
        Thread.Sleep(1500);
        Console.Clear();
        goto subwayToShop;
      }

      switch (lists.GetValue("Input"))
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
            lists.ModifyInt("Input", Convert.ToInt32(Console.ReadLine()));
          }
          catch
          {
            Console.Clear();
            Console.WriteLine("Invalid input");
            Thread.Sleep(1500);
            Console.Clear();
            goto subwayToShopDogs;
          }

          switch (lists.GetValue("Input"))
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
              lists.AddItem("Dog Bone", 0, true);
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
              lists.ModifyInt("HP", 0);
              lists.Hp();
              break;
          }

          break;
        case 2:
          if (lists.CheckBool("MachineGun"))
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
            lists.ModifyInt("HP", 0);
            lists.Hp();
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

      lists.AddItem("subwayToShop", 0, true);
    }

    if (!lists.CheckBool("shop"))
    {
      Console.Clear();
      Console.Write("The area around the shop looks empty");
      Thread.Sleep(3000);
      Console.WriteLine(", scavanged and picked clean.");
      Thread.Sleep(2500);
      Console.Write("A big ass neon sign sit atop the building");
      Thread.Sleep(3000);
      Console.Write(", missing a few light bulbs");
      Thread.Sleep(2000);
      Console.WriteLine(" but still lighting up the area.");
      Thread.Sleep(3000);
      Console.Write("Items are visible in the shop windows");
      Thread.Sleep(3000);
      Console.WriteLine(", secure behind metal bars.");
      Thread.Sleep(2500);
      Console.Write("Traps are scattered around the perimeter");
      Thread.Sleep(3000);
      Console.WriteLine(", spikes and barbed wire.");
      Thread.Sleep(2500);
      lists.AddItem("shop", -1, true);
    }

    lists.CurrentLocation = "Shop";
    Console.Clear();
    Console.WriteLine($"You are at the -{lists.CurrentLocation}-");
    Thread.Sleep(500);
    Console.WriteLine("");
    Console.WriteLine("--What do you want to do?--");
    Console.WriteLine("1. Travel to a different location");
    Console.WriteLine("2. Check status");
    Console.WriteLine("3. Enter the shop");
    Console.WriteLine("4. Look around outside");
    try
    {
      lists.ModifyInt("Input", Convert.ToInt32(Console.ReadLine()));
    }
    catch
    {
      Console.Clear();
      Console.WriteLine("Invalid input");
      Thread.Sleep(1500);
      Shop();
    }

    switch (lists.GetValue("Input"))
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
        if (!lists.CheckBool("insideShop"))
        {
          Console.Clear();
          Console.WriteLine("As you enter the shop you hear faint music humming in the background.");
          Thread.Sleep(4000);
          Console.WriteLine("The walls are sparsely filled with random trinkets and items.");
          Thread.Sleep(3500);
          Console.Write("There does not seem to be anyone here.");
          Thread.Sleep(2500);
          Console.Write(" It all seems a bit");
          Thread.Sleep(2000);
          Console.WriteLine(", off.");
          Thread.Sleep(1500);
          Console.Write("You go over to the register");
          Thread.Sleep(2500);
          Console.WriteLine(", a small creature behind the counter groans towards you.");
          Thread.Sleep(3500);
          Console.WriteLine("You jump, as they stare at you with a stern look.");
          Thread.Sleep(3500);
          Console.Write("As you are about to ask");
          Thread.Sleep(2500);
          Console.WriteLine(" he just points to a sign behind him.");
          Thread.Sleep(3000);
          Console.WriteLine("before grunting and retreating to the back room.");
          Thread.Sleep(3500);
          Console.Write("The sign seams simple enough though");
          Thread.Sleep(2500);
          Console.WriteLine(", luckily.");
          Thread.Sleep(3500);
          Console.WriteLine("");

          lists.AddItem("insideShop", -1, true);
        }

        insideShop:
        Console.WriteLine("--What do you want to do?--");
        Console.WriteLine("1. Buy something");
        Console.WriteLine("2. Sell something");
        Console.WriteLine("3. Look around the shop");
        Console.WriteLine("4. Leave");
        try
        {
          lists.ModifyInt("Input", Convert.ToInt32(Console.ReadLine()));
        }
        catch
        {
          Console.Clear();
          Console.WriteLine("Invalid input");
          Thread.Sleep(1500);
          Console.Clear();
          goto insideShop;
        }

        switch (lists.GetValue("Input"))
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
        if (!lists.CheckBool("shopOutside"))
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
            lists.ModifyInt("Input", Convert.ToInt32(Console.ReadLine()));
          }
          catch
          {
            Console.Clear();
            Console.WriteLine("Invalid input");
            Thread.Sleep(1500);
            Console.Clear();
            goto shopOutside;
          }

          switch (lists.GetValue("Input"))
          {
            case 1:
              Console.WriteLine("You search the bags for anything useful.");
              Thread.Sleep(2000);
              Console.Write("To your surprise you find some loose change");
              Thread.Sleep(2000);
              Console.WriteLine(", about 5 bucks.");
              Thread.Sleep(2000);
              lists.ModifyValue("Money", i => i + 5);
              lists.AddItem("shopOutside", -1, true);
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