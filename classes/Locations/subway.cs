using TextBasedGame.classes;

public class SubwayEntrance(Locations locations)
{
  private readonly Items items = locations.Items;
  private readonly Status? status = locations.Status;
  private bool subway;
  private bool subwayEntrance;
  private bool subwayFlashlight;
  private bool apartmentsToSubway;

  public void Subway()
  {
    if (locations.CurrentLocation == "Apartments" && !apartmentsToSubway)
    {
      Console.Clear();
      Console.Write("On your way to the Subway");
      Thread.Sleep(1500);
      Console.WriteLine(", you encounter a pack of thugs.");
      Thread.Sleep(2000);
      Console.WriteLine("They do not look friendly.");
      Thread.Sleep(2000);
      Console.WriteLine("");
      apartmentsToSubway:
      Console.WriteLine("--What do you want to do?");
      Console.WriteLine("1. Put your hands up");
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
        goto apartmentsToSubway;
      }

      switch (locations.Input)
      {
        case 1:
          Console.Clear();
          Console.Write("Right away");
          Thread.Sleep(1500);
          Console.WriteLine(" you put your hands in the air");
          Thread.Sleep(2000);
          Console.Write("They walk over to you");
          Thread.Sleep(1500);
          Console.WriteLine(" putting knives to your throat.");
          Thread.Sleep(2500);
          Console.WriteLine("They start going through your pockets");
          Thread.Sleep(2500);
          Console.WriteLine("You can feel the knives prodding you as they grab your things.");
          Thread.Sleep(3000);
          Console.WriteLine("");
          apartmentsToSubwayThugs:
          Console.WriteLine("--What do you want to do?--");
          Console.WriteLine("1. Let them");
          Console.WriteLine("2. Stop them");
          Thread.Sleep(2000);
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
            goto apartmentsToSubwayThugs;
          }

          switch (locations.Input)
          {
            case 1:
              Console.Clear();
              Console.WriteLine("You feel it is safer to let them.");
              Thread.Sleep(2000);
              Console.WriteLine("They end up taking all your money.");
              Thread.Sleep(2000);
              items.Money = 0;
              Console.Write("As they walk off");
              Thread.Sleep(1500);
              Console.WriteLine(", you are not sure whether you should be happy to be alive");
              Thread.Sleep(2500);
              Console.WriteLine(", or angry they took all of your money.");
              Thread.Sleep(2000);
              break;
            case 2:
              Console.Clear();
              Console.WriteLine("You push them off of you");
              Thread.Sleep(2000);
              Console.Write("Before you manage to do anything");
              Thread.Sleep(2500);
              Console.WriteLine(", you feel a cold sensation in your side.");
              Thread.Sleep(3000);
              Console.WriteLine("You look down and see a knife in your side.");
              Thread.Sleep(3000);
              Console.Write("You feel faint");
              Thread.Sleep(1500);
              Console.Write(" and fall to the ground.");
              Thread.Sleep(2000);
              Console.WriteLine("Blood pools around you.");
              Thread.Sleep(2000);
              Console.Write("As you lie there");
              Thread.Sleep(2000);
              Console.WriteLine(" you feel multiple knives piercing your body.");
              Thread.Sleep(3000);
              Console.Write("You start to feel numb");
              Thread.Sleep(2000);
              Console.WriteLine(" as everything turns black.");
              Thread.Sleep(3000);
              items.HealthPoints = 0;
              items.Hp();
              break;
          }

          break;
        case 2:
          if (items.MachineGun)
          {
            Console.Clear();
            Console.WriteLine("You pull out your machine gun and spray the thugs with bullet.");
            Thread.Sleep(3500);
            Console.WriteLine("All of the thugs are taken out before any of them could get close.");
            Thread.Sleep(3500);
            Console.WriteLine("You loot their corpses for 15 bucks.");
            Thread.Sleep(3000);
            items.Money += 15;
          }
          else if (items.Knife || items.Crowbar)
          {
            Console.Clear();
            if (items.Knife) Console.WriteLine("You pull out your knife and get ready to fight.");
            if (items.Crowbar) Console.WriteLine("You pull out your crowbar and get ready to fight.");
            Thread.Sleep(3000);
            Console.Write("You expect them to come at you all at once");
            Thread.Sleep(2500);
            Console.WriteLine(", but they circle around you like hawks.");
            Thread.Sleep(2500);
            Console.Write("They take turns taking jabs at you");
            Thread.Sleep(2500);
            Console.Write(" stabbing the air");
            Thread.Sleep(1500);
            Console.WriteLine(", mostly");
            Thread.Sleep(1500);
            Console.Write("Eventually");
            Thread.Sleep(1500);
            Console.WriteLine(", you manage to fend them off.");
            Thread.Sleep(2000);
            Console.WriteLine("They run off leaving one of their wounded.");
            Thread.Sleep(2500);
            Console.WriteLine("You search his pockets and find 5 bucks");
            Thread.Sleep(2500);
            items.Money += 5;
            Console.WriteLine("They got in a few good stabs and swipes.");
            Thread.Sleep(2500);
            Console.WriteLine("-25 HP");
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
          Console.WriteLine("You can see the Subway ahead of you in the distance.");
          Thread.Sleep(3000);
          Console.Write("As you get closer");
          Thread.Sleep(1500);
          Console.WriteLine(" you notice the thugs slow down and stop following you.");
          Thread.Sleep(3000);
          Console.WriteLine("That can not be a good sign, can it?");
          Thread.Sleep(3000);
          break;
      }

      apartmentsToSubway = true;
    }

    if (!subway)
    {
      Console.Clear();
      Console.Write("Rundown and abandoned");
      Thread.Sleep(2000);
      Console.WriteLine(", this subway station is in a rough state.");
      Thread.Sleep(3000);
      Console.Write("Paint scraped off");
      Thread.Sleep(2000);
      Console.Write(", dust a dirt everywhere");
      Thread.Sleep(2000);
      Console.WriteLine(", structually falling apart");
      Thread.Sleep(3000);
      Console.WriteLine("Looks like it has been a while since it has been in use.");
      Thread.Sleep(4000);
      subway = true;
    }

    locations.CurrentLocation = "Subway Entrance";
    Console.Clear();
    Console.WriteLine($"You are at the -{locations.CurrentLocation}-");
    Thread.Sleep(500);
    Console.WriteLine("");
    Console.WriteLine("---What do you want to do?---");
    Console.WriteLine("1. Travel to a different location");
    Console.WriteLine("2. Check status");
    Console.WriteLine("3. Go down into the subway");
    Console.WriteLine("4. Check the area around the entrance");
    try
    {
      locations.Input = Convert.ToInt32(Console.ReadLine());
    }
    catch
    {
      Console.Clear();
      Console.WriteLine("Invalid input");
      Thread.Sleep(1500);
      Subway();
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
        status?.ShowStatus();
        Subway();
        break;
      }
      case 3:
      {
        if (subwayFlashlight)
        {
          Console.WriteLine("I have nothing more to do down here.");
          Thread.Sleep(2000);
          Subway();
        }
        else if (!subwayEntrance)
        {
          Console.Clear();
          Console.Write("As you walk down into the subway");
          Thread.Sleep(1500);
          Console.WriteLine(", it gets harder to see");
          Thread.Sleep(2500);
          Console.Write("The lights are out");
          Thread.Sleep(1500);
          Console.WriteLine(" and you can hear rats running around somewhere.");
          Thread.Sleep(3000);
          Console.Write("Despite the lack of lights");
          Thread.Sleep(1500);
          Console.WriteLine(", you notice all the dirt and grime on the floors.");
          Thread.Sleep(3000);
          Console.Write("From what you can see");
          Thread.Sleep(1500);
          Console.WriteLine(" it does not look like this subway is in use anymore.");
          Thread.Sleep(3000);
          Console.Write("I can go further down into the subway");
          Thread.Sleep(2000);
          Console.WriteLine(" but it might be hard to see anything without a flashlight.");
          Thread.Sleep(3500);
          Console.WriteLine("");
          subwayEntrance = true;
        }

        subwayEntrance:
        Console.WriteLine("--What do you want to do?--");
        Console.WriteLine("1. Go further down into the subway");
        Console.WriteLine("2. Leave");
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
          goto subwayEntrance;
        }

        switch (locations.Input)
        {
          case 1:
            if (items.Flashlight && !subwayFlashlight)
            {
              Console.WriteLine("You venture down into the subway.");
              Thread.Sleep(2000);
              Console.Write("Your flashlight makes it easier to see");
              Thread.Sleep(2000);
              Console.WriteLine(", but it is still rather dark.");
              Thread.Sleep(2000);
              Console.Write("The subway is fairly empty");
              Thread.Sleep(2000);
              Console.WriteLine(", if you look past the dirt and trash.");
              Thread.Sleep(2000);
              Console.Write("As you walk around");
              Thread.Sleep(1500);
              Console.WriteLine(" it feels like there is someone of something watching you.");
              Thread.Sleep(3000);
              Console.Write("You try every door you find");
              Thread.Sleep(2000);
              Console.WriteLine(", but they are all locked.");
              Thread.Sleep(2500);
              Console.WriteLine("Eventually, you find an unlocked door.");
              Thread.Sleep(3000);
              Console.Clear();
              Console.Write("Slowly");
              Thread.Sleep(1000);
              Console.Write(", you open the door");
              Thread.Sleep(1000);
              Console.WriteLine("and walk in.");
              Thread.Sleep(2000);
              Console.Write("Inside there are shelves everywhere");
              Thread.Sleep(2000);
              Console.WriteLine(", filled with boxes on boxes.");
              Thread.Sleep(2000);
              Console.WriteLine("");
              subwayShelves:
              Console.WriteLine("--What do you do want to do?--");
              Console.WriteLine("1. Search left side first");
              Console.WriteLine("2. Search right side first");
              Console.WriteLine("3. Leave");
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
                goto subwayShelves;
              }

              switch (locations.Input)
              {
                case 1:
                  Console.WriteLine("You start searching the boxes on the left side.");
                  Thread.Sleep(2500);
                  Console.Write("While searching one of the boxes");
                  Thread.Sleep(1500);
                  Console.WriteLine(", you cut your hand on something sharp");
                  Thread.Sleep(2500);
                  Console.WriteLine("-10 HP");
                  items.HealthPoints -= 10;
                  items.Hp();
                  Console.Clear();
                  goto subwayShelves;
                case 2:
                  if (!items.Crowbar)
                  {
                    Console.WriteLine("You start searching the boxes on the right side.");
                    Thread.Sleep(2500);
                    Console.Write("After going through a lot of empty boxes");
                    Thread.Sleep(2500);
                    Console.WriteLine(", you find a box with a tool label.");
                    Thread.Sleep(2000);
                    Console.WriteLine("Inside you find a CROWBAR");
                    Thread.Sleep(2500);
                    items.Crowbar = true;
                  }
                  else
                  {
                    Console.WriteLine("I have already searched these boxes before.");
                    Thread.Sleep(2500);
                  }

                  Console.Clear();
                  goto subwayShelves;
                case 3:
                  Subway();
                  break;
              }

              subwayFlashlight = true;
            }
            else if (subwayFlashlight)
            {
              Console.WriteLine("I have nothing more to do down here.");
              Thread.Sleep(2000);
            }
            else
            {
              Console.WriteLine("You venture down into the subway.");
              Thread.Sleep(2000);
              Console.WriteLine("Before you know it everything is pitch black.");
              Thread.Sleep(3500);
              Console.WriteLine("You start hearing unintelligible noises");
              Thread.Sleep(2000);
              Console.Write("Humans?");
              Thread.Sleep(1000);
              Console.Write(" Animals?");
              Thread.Sleep(1000);
              Console.WriteLine(" Or maybe something worse?");
              Thread.Sleep(1500);
              Console.Write("You keep walking down corridors");
              Thread.Sleep(2000);
              Console.WriteLine(", or what you think are corridors.");
              Thread.Sleep(2000);
              Console.WriteLine("You get the feeling someone or something is watching you");
              Thread.Sleep(3000);
              Console.Write("...");
              Thread.Sleep(1000);
              Console.WriteLine(" Everything goes black.");
              Thread.Sleep(2000);
              items.HealthPoints = 0;
              items.Hp();
            }

            break;
          case 2:
            Subway();
            break;
        }

        break;
      }
      case 4:
      {
        Console.Clear();
        Console.WriteLine("You look around the entrance for anything useful.");
        Thread.Sleep(2500);
        Console.WriteLine("There is a few bags of trash scattered around.");
        Thread.Sleep(2500);
        Console.Write("Some of them torn apart");
        Thread.Sleep(1500);
        Console.Write(", trash scattered everywhere");
        Thread.Sleep(1500);
        Console.WriteLine(", rats roaming.");
        Thread.Sleep(2000);
        Console.WriteLine("");
        subwayEntrance:
        Console.WriteLine("--What do you want to do?--");
        Console.WriteLine("1. Search the unopened bags");
        Console.WriteLine("2. Leave");
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
          goto subwayEntrance;
        }

        switch (locations.Input)
        {
          case 1:
            Console.WriteLine("You search the few unopened bags that are left.");
            Thread.Sleep(3000);
            Console.Write("The bags are dirty");
            Thread.Sleep(1000);
            Console.Write(", and full of trash");
            Thread.Sleep(1500);
            Console.WriteLine(", and likely a few diseases.");
            Thread.Sleep(2000);
            Console.WriteLine("-20 HP");
            items.HealthPoints -= 20;
            items.Hp();
            Thread.Sleep(2000);
            Subway();
            break;
          case 2:
            Subway();
            break;
        }

        break;
      }
      default:
      {
        Console.Clear();
        Console.Write("Invalid input");
        Thread.Sleep(1500);
        Subway();
        break;
      }
    }
  }
}