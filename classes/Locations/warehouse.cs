public class AbandonedWarehouse(Locations locations)
{
  private readonly Items items = locations.items;
  private readonly Locations locations = locations;
  private readonly Status status = new(locations, locations.items);
  private bool pavilionToWarehouse;

  public void Warehouse()
  {
    if (locations.currentLocation == "Pavilion" && !pavilionToWarehouse)
    {
      Console.Clear();
      Console.Write("On your way to the Warehouse");
      Thread.Sleep(1500);
      Console.WriteLine(", you encounter a pack of dogs.");
      Thread.Sleep(2000);
      Console.WriteLine("It is hard to tell if they are aggressive or not.");
      Thread.Sleep(3000);
      Console.WriteLine("");
      pavilionToWarehouse:
      Console.WriteLine("--What do you want to do?");
      Console.WriteLine("1. Crouch and try to pet them");
      Console.WriteLine("2. Attack them");
      Console.WriteLine("3. Run");
      try
      {
        locations.input = Convert.ToInt32(Console.ReadLine());
      }
      catch
      {
        Console.WriteLine("Invalid input");
        Thread.Sleep(1500);
        Console.Clear();
        goto pavilionToWarehouse;
      }

      switch (locations.input)
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
          pavilionToWarehouseDogs:
          Console.WriteLine("--What do you want to do?--");
          Console.WriteLine("1. Stay crouched and try to pet them");
          Console.WriteLine("2. Get up and run");
          try
          {
            locations.input = Convert.ToInt32(Console.ReadLine());
          }
          catch
          {
            Console.WriteLine("Invalid input");
            Thread.Sleep(1500);
            goto pavilionToWarehouseDogs;
          }

          switch (locations.input)
          {
            case 1:
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
          Console.WriteLine("You can see the Warehouse ahead of you in the distance.");
          Thread.Sleep(3000);
          Console.Write("You reach the Warehouse and manage to jump the fence");
          Thread.Sleep(2000);
          Console.WriteLine(", just as they leap forward to have a nibble");
          Thread.Sleep(3000);
          Console.Write("Breathing heavily");
          Thread.Sleep(1500);
          Console.WriteLine(", you look through the fence at the rapid dogs just out of reach.");
          Thread.Sleep(4000);
          break;
      }

      pavilionToWarehouse = true;
    }

    locations.currentLocation = "AbandonedWarehouse";
    Console.Clear();
    Console.WriteLine($"You are at the  -{locations.currentLocation}-");
    Thread.Sleep(500);
    Console.WriteLine("---What do you want to do?---");
    Console.WriteLine("1. Travel to a different location");
    Console.WriteLine("2. Check status");
    Console.WriteLine("3. Exit through the gate");
    Console.WriteLine("4. Look around for anything useful");
    try
    {
      locations.input = Convert.ToInt32(Console.ReadLine());
    }
    catch
    {
      Console.Clear();
      Console.WriteLine("Invalid input");
      Thread.Sleep(1500);
      Warehouse();
    }

    switch (locations.input)
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
        break;
      }
      case 3:
      {
        break;
      }
      case 4:
      {
        break;
      }
      default:
      {
        Console.Clear();
        Console.Write("Invalid input");
        Thread.Sleep(1500);
        Warehouse();
        break;
      }
    }
  }
}