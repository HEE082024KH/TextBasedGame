using TextBasedGame.classes;

public class ApartmentsLocation(Locations locations, Lists lists)
{
  private readonly Status? status = locations.Status;

  public void Apartments()
  {
    if (lists.CheckBool("apartments"))
    {
      Console.Clear();
      Console.Write("Walking up to the Apartments");
      Thread.Sleep(2000);
      Console.WriteLine(" you notice there is only one apartment block left.");
      Thread.Sleep(3000);
      Console.Write("There are rubbles of bricks and steel");
      Thread.Sleep(2000);
      Console.WriteLine(" scattered all around where the apartment blocks used to be.");
      Thread.Sleep(3500);
      Console.WriteLine("Even the one left standing looks to be in rough shape.");
      Thread.Sleep(3500);
      Console.Write("The top floors looks badly damaged");
      Thread.Sleep(2500);
      Console.WriteLine(", some of it gone altogether.");
      Thread.Sleep(3000);
      lists.AddItem("apartments", -1, true);
    }

    lists.CurrentLocation = "Apartments";
    Console.Clear();
    Console.WriteLine($"You are at the -{locations.CurrentLocation}-");
    Thread.Sleep(500);
    Console.WriteLine("");
    Console.WriteLine("--What do you want to do?--");
    Console.WriteLine("1. Travel to a different location");
    Console.WriteLine("2. Check status");
    Console.WriteLine("3. Look around outside");
    Console.WriteLine("4. Go in the front door");
    Console.WriteLine("5. Look for an open window");
    try
    {
      lists.ModifyInt("Input", Convert.ToInt32(Console.ReadLine()));
    }
    catch
    {
      Console.Clear();
      Console.WriteLine("Invalid input");
      Thread.Sleep(1500);
      Apartments();
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
        status?.ShowStatus();
        Apartments();
        break;
      }
      case 3:
      {
        outsideApartments:
        Console.Clear();
        Console.WriteLine("There's a few bags of trash scattered along the walls");
        Console.WriteLine("");
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
          goto outsideApartments;
        }

        switch (lists.GetValue("Input"))
        {
          case 1:
          {
            Console.Clear();
            Console.WriteLine("You rummage through the bags, looking for anything of use.");
            Thread.Sleep(3500);
            Console.WriteLine("Looking through one of the bags, you cut your hand on a sharp object");
            Thread.Sleep(2500);
            Console.WriteLine("-10 HP");
            lists.ModifyValue("HP", hp => hp - 10);
            lists.Hp();
            Thread.Sleep(2500);
            Apartments();
            break;
          }
          case 2:
          {
            Console.Clear();
            Console.WriteLine("You leave the bags alone.");
            Thread.Sleep(2000);
            Console.WriteLine("Who knows what kind of diseases are in those bags.");
            Thread.Sleep(3000);
            Apartments();
            break;
          }
        }

        break;
      }
      case 4:
      {
        if (!lists.CheckBool("insideApartments"))
        {
          Console.Clear();
          Structures.Apartments();
          Console.WriteLine("");
          Console.Write("The door opens with a nasty creak");
          Thread.Sleep(2000);
          Console.WriteLine(", sure to notify anyone nearby.");
          Thread.Sleep(1500);
          Console.Write("Inside there's a small hallway with a door at the end");
          Thread.Sleep(2500);
          Console.WriteLine(", and 2 doors on either side.");
          Thread.Sleep(3000);
          Console.WriteLine("");
          lists.AddItem("insideApartments", -1, true);
        }

        insideApartments:
        Console.Clear();
        Structures.Apartments();
        Console.WriteLine("");
        Console.WriteLine("What do you want to do?");
        Console.WriteLine("1. Enter the first door on the right");
        Console.WriteLine("2. Enter the second door on the right");
        Console.WriteLine("3. Enter the first door on the left");
        Console.WriteLine("4. Enter the second door on the left");
        Console.WriteLine("5. Enter the door at the end");
        Console.WriteLine("6. Use the stairs to go up a floor");
        Console.WriteLine("7. Go back out");
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
          Structures.Apartments();
          Console.WriteLine("");
          goto insideApartments;
        }

        switch (lists.GetValue("Input"))
        {
          case 1:
          {
            Console.Clear();
            if (lists.CheckBool("Crowbar"))
            {
              Console.Clear();
              Console.WriteLine("You use the crowbar to pry the door open.");
              Thread.Sleep(1000);
              Console.WriteLine("With a loud crack the door opens");
              Thread.Sleep(2000);
              Console.WriteLine("The room looks to be a maintenance room of sorts");
              Thread.Sleep(1000);
              Console.WriteLine("Not much to find here");
              Thread.Sleep(2000);
              Console.Clear();
              Structures.Apartments();
              Console.WriteLine("");
              goto insideApartments;
            }

            if (lists.CheckBool("Hairpin"))
            {
              lists.AddItem("Hairpin", 0, true);
              Console.Clear();
              Console.WriteLine("You use the hairpin to unlock the door.");
              Thread.Sleep(2000);
              Console.WriteLine("The room looks to be a maintenance room of sorts");
              Thread.Sleep(1000);
              Console.WriteLine("Not much to find here");
              Thread.Sleep(2000);
              Console.Clear();
              Structures.Apartments();
              Console.WriteLine("");
              goto insideApartments;
            }

            Console.WriteLine("The door is locked");
            Thread.Sleep(1000);
            Console.WriteLine("If only you had a crowbar or something to unlock the door");
            Thread.Sleep(3000);
            Console.Clear();
            Structures.Apartments();
            Console.WriteLine("");
            goto insideApartments;
          }
          case 2:
          {
            insideApartmentsDoor2:
            Console.Clear();
            Console.Write("The door opens with ease");
            Thread.Sleep(1500);
            Console.WriteLine(", almost too easy");
            Thread.Sleep(1000);
            Console.WriteLine("");
            Console.WriteLine("What do you want to do?");
            Console.WriteLine("1. Just walk in");
            Console.WriteLine("2. Hug the wall and sneakily look inside");
            try
            {
              lists.ModifyInt("Input", Convert.ToInt32(Console.ReadLine()));
            }
            catch
            {
              Console.Clear();
              Console.WriteLine("Invalid input");
              Thread.Sleep(2000);
              Console.Clear();
              goto insideApartmentsDoor2;
            }

            switch (lists.GetValue("Input"))
            {
              case 1:
                if (!lists.CheckBool("insideApartmentsDoor2"))
                {
                  Console.Clear();
                  Console.WriteLine("As you walk in a man jumps you from behind.");
                  Thread.Sleep(1000);
                  if (lists.CheckBool("IsBuzzed"))
                  {
                    Console.Write("Despite feeling buzzed you manage to overpower the man");
                    Thread.Sleep(2500);
                    Console.WriteLine(", however, you are hurt in the process.");
                    Thread.Sleep(2000);
                    Console.WriteLine("\t-20 HP");
                    Thread.Sleep(2000);
                    lists.ModifyValue("HP", hp => hp - 20);
                    lists.Hp();
                  }
                  else if (lists.CheckBool("IsDrunk"))
                  {
                    Console.WriteLine("You barely manage to fight him off");
                    Thread.Sleep(2000);
                    Console.Write(", turns out fighting while drunk is not easy");
                    Thread.Sleep(2000);
                    Console.WriteLine("\t-30 HP");
                    Thread.Sleep(2000);
                    lists.ModifyValue("HP", hp => hp - 30);
                    lists.Hp();
                  }
                  else if (lists.CheckBool("IsHammered"))
                  {
                    Console.WriteLine("You are hammered.");
                    Thread.Sleep(2000);
                    Console.Write("Before you notice what is going on everything goes black.");
                    Thread.Sleep(3000);
                    lists.AddItem("HP", 0, false);
                    lists.Hp();
                  }
                  else
                  {
                    Console.WriteLine("During the struggle you hurt your arm.");
                    Thread.Sleep(2000);
                    Console.WriteLine("\t-15 HP");
                    Thread.Sleep(2000);
                    lists.ModifyValue("HP", hp => hp - 15);
                    lists.Hp();
                  }

                  lists.Hp();
                  Console.WriteLine(
                    "He's not much of a fighter, however, and eventually you knock him out.");
                  Thread.Sleep(3000);
                  Console.WriteLine("You go through his pockets and find a KNIFE");
                  Thread.Sleep(2000);
                  lists.AddItem("Knife", 0, true);
                  if (lists.CheckBool("necklaceQuest"))
                  {
                    lists.AddItem("necklaceQuest", -1, false);
                    Console.WriteLine("You also find the woman's NECKLACE");
                    Thread.Sleep(2000);
                    lists.AddItem("Necklace", 0, true);
                  }

                  lists.AddItem("insideApartmentsDoor2", -1, true);
                }
                else if (!lists.CheckBool("Necklace") && lists.CheckBool("necklaceQuest") &&
                         lists.CheckBool("insideApartmentsDoor2"))
                {
                  Console.WriteLine("You see the man lying on the floor.");
                  Thread.Sleep(2000);
                  Console.WriteLine("You go through his pockets and find the woman's NECKLACE");
                  Thread.Sleep(3500);
                  lists.AddItem("Necklace", 0, true);
                }
                else
                {
                  Console.WriteLine("You see the man lying on the floor.");
                  Thread.Sleep(2000);
                  Console.WriteLine("There is not much left to find here, however.");
                  Thread.Sleep(2500);
                }

                Console.Clear();
                Structures.Apartments();
                Console.WriteLine("");
                goto insideApartments;
              case 2:
                if (!lists.CheckBool("insideApartmentsDoor2Done"))
                {
                  {
                    if (!lists.CheckBool("IsDrunk") || !lists.CheckBool("IsHammered"))
                    {
                      Console.Clear();
                      Console.Write("As you look inside");
                      Thread.Sleep(1500);
                      Console.WriteLine(", you notice a man waiting to jump you.");
                      Thread.Sleep(2000);
                    }
                    else
                    {
                      Console.Clear();
                      Console.Write("You look inside");
                      Thread.Sleep(500);
                      Console.WriteLine(", but you do not notice anything.");
                    }

                    Thread.Sleep(1500);
                    if (lists.CheckBool("IsBuzzed"))
                    {
                      Console.WriteLine(
                        "Despite feeling buzzed you charge the man and knock him to the ground");
                      Thread.Sleep(3500);
                      Console.WriteLine(
                        "Eventually, with a bit of fumbling, you manage to knock him out.");
                      Console.WriteLine("\t-5 HP");
                      Thread.Sleep(3000);
                      lists.ModifyValue("HP", hp => hp - 5);
                    }
                    else if (lists.CheckBool("IsDrunk"))
                    {
                      Console.WriteLine("You walk inside and get jumped by a strange man.");
                      Thread.Sleep(3500);
                      Console.WriteLine(
                        "You struggle to overpower him, but eventually you manage to knock him out.");
                      Console.WriteLine("\t-15 HP");
                      Thread.Sleep(3000);
                      lists.ModifyValue("HP", hp => hp - 15);
                      lists.Hp();
                    }
                    else if (lists.CheckBool("IsHammered"))
                    {
                      Console.WriteLine("You are hammered.");
                      Thread.Sleep(1500);
                      Console.WriteLine("You walk inside and suddenly everything goes black.");
                      Thread.Sleep(3500);
                      lists.AddItem("HP", 0, false);
                      lists.Hp();
                    }
                    else
                    {
                      Console.WriteLine(
                        "You catch him off guard by quickly charging him and knocking him to the ground.");
                      Thread.Sleep(3500);
                      Console.WriteLine("With a quick strike you knock him out cold.");
                      Thread.Sleep(2500);
                    }

                    lists.Hp();
                    Console.WriteLine("You go through his pockets and find a KNIFE");
                    lists.AddItem("Knife", 0, true);
                    Thread.Sleep(3000);
                    lists.AddItem("insideApartmentsDoor2Done", -1, true);
                    Console.Clear();
                    Structures.Apartments();
                    Console.WriteLine("");
                    goto insideApartments;
                  }
                }

                Console.WriteLine("You see the man lying on the floor.");
                Thread.Sleep(2000);
                Console.WriteLine("There is not much left to find here, however.");
                Thread.Sleep(2500);
                Console.Clear();
                Structures.Apartments();
                Console.WriteLine("");
                goto insideApartments;
            }

            Console.Clear();
            Structures.Apartments();
            Console.WriteLine("");
            goto insideApartments;
          }
          case 3:
          {
            Console.Clear();
            Console.Write("As you approach the door");
            Thread.Sleep(1500);
            Console.WriteLine(", you notice a weird substance covering the door and door handle.");
            Thread.Sleep(3000);
            Console.WriteLine("");
            insideApartmentsDoor3:
            Console.WriteLine("--What do you want to do?");
            Console.WriteLine("1. Open the door");
            Console.WriteLine("2. Leave");
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
              goto insideApartmentsDoor3;
            }

            switch (lists.GetValue("Input"))
            {
              case 1:
                Console.Clear();
                Console.WriteLine("Your hand feels icky as you touch the door handle.");
                Thread.Sleep(3000);
                Console.WriteLine("As you open the door a foul odor slaps you across the face.");
                Thread.Sleep(3500);
                Console.Write("Inside, the walls are covered in dirt, blood and feces");
                Thread.Sleep(2000);
                Console.WriteLine(", a disgusting spectacle!");
                Thread.Sleep(3000);
                Console.Write("The floor, however, is pristine");
                Thread.Sleep(2000);
                Console.Write(" like something has been covering it");
                Thread.Sleep(2500);
                Console.Write(", \nshielded from whatever monstrosity happened here.");
                Thread.Sleep(3000);
                Console.WriteLine("");
                Console.WriteLine("");
                insideApartmentsDoor3Open:
                Console.WriteLine("--What do you want to do?--");
                Console.WriteLine("1. Enter the room");
                Console.WriteLine("2. Leave");
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
                  goto insideApartmentsDoor3Open;
                }

                switch (lists.GetValue("Input"))
                {
                  case 1:
                    Console.Clear();
                    Console.WriteLine("You enter the room, against your best judgement.");
                    Thread.Sleep(3000);
                    Console.Write("You look around the room");
                    Thread.Sleep(2000);
                    Console.WriteLine(", looking for anything or something explaining all this.");
                    Thread.Sleep(3500);
                    Console.WriteLine("");
                    insideApartmentsDoor3OpenInside:
                    Console.WriteLine("--What do you want to do?--");
                    Console.WriteLine("1. Keep looking");
                    Console.WriteLine("2. Leave");
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
                      goto insideApartmentsDoor3OpenInside;
                    }

                    switch (lists.GetValue("Input"))
                    {
                      case 1:
                        Console.Clear();
                        Console.Write("You keep looking around");
                        Thread.Sleep(2500);
                        Console.WriteLine(", touching things you maybe shouldn't.");
                        Thread.Sleep(3000);
                        Console.Write("You do not find anything useful");
                        Thread.Sleep(2500);
                        Console.WriteLine(", but you might have overstayed your welcome.");
                        Thread.Sleep(2000);
                        Console.WriteLine("\t-15 HP");
                        Thread.Sleep(3000);
                        lists.ModifyValue("HP", hp => hp - 15);
                        lists.Hp();
                        Thread.Sleep(2500);
                        Console.Write("Just as you are about to leave");
                        Thread.Sleep(2000);
                        Console.WriteLine(
                          ", you notice a keycard stuck to the wall just next to the door.");
                        Thread.Sleep(3500);
                        Console.WriteLine(
                          "You pick up what looks like a keycard for an office or something.");
                        Thread.Sleep(4000);
                        Console.WriteLine("You got the OFFICE KEYCARD");
                        Thread.Sleep(3000);
                        lists.AddItem("Office Keycard", 0, true);
                        Console.Clear();
                        Structures.Apartments();
                        Console.WriteLine("");
                        goto insideApartments;
                      case 2:
                        Console.Clear();
                        Structures.Apartments();
                        Console.WriteLine("");
                        goto insideApartments;
                    }

                    break;
                }

                break;
              case 2:
                Console.Clear();
                Structures.Apartments();
                Console.WriteLine("");
                goto insideApartments;
            }

            break;
          }
          case 4:
          {
            if (lists.CheckBool("insideApartmentsDoor4Done"))
            {
              Console.Clear();
              Console.WriteLine("You do not have any reason to go back here.");
              Thread.Sleep(3000);
              Console.Clear();
              Structures.Apartments();
              Console.WriteLine("");
              goto insideApartments;
            }

            if (lists.CheckBool("insideApartmentsDoor4Talk"))
            {
              if (lists.CheckBool("Necklace"))
              {
                Console.Clear();
                Console.WriteLine("Her face lights up as you enter.");
                Thread.Sleep(2500);
                Console.WriteLine("You hand the necklace over to her");
                Thread.Sleep(2500);
                Console.WriteLine("With great appreciation she thanks you.");
                Thread.Sleep(2500);
                Console.WriteLine("She gives you a KEY in return.");
                Thread.Sleep(2000);
                lists.AddItem("Key", 0, true);
                Console.WriteLine("She is unsure where it fits, but she found it on this floor.");
                Thread.Sleep(3000);
                Console.WriteLine("If you look around a bit you might figure where to use it.");
                Thread.Sleep(2500);
                lists.AddItem("insideApartmentsDoor4Done", -1, true);
                Console.Clear();
                Structures.Apartments();
                Console.WriteLine("");
                goto insideApartments;
              }

              Console.Clear();
              Console.WriteLine("Her face lights up as you enter.");
              Thread.Sleep(2500);
              Console.Write("When she learns you have not found the necklace");
              Thread.Sleep(3000);
              Console.WriteLine(", her smile fades.");
              Thread.Sleep(1500);
              Console.WriteLine("You should find the necklace before coming back here.");
              Thread.Sleep(4000);
              Console.Clear();
              Structures.Apartments();
              Console.WriteLine("");
              goto insideApartments;
            }

            if (lists.CheckBool("insideApartmentsDoor4Steal"))
            {
              Console.Clear();
              Console.WriteLine("You enter the apartment looking for the woman.");
              Thread.Sleep(2500);
              Console.WriteLine("You look around but she is nowhere to be found.");
              Thread.Sleep(3000);
              Console.WriteLine("Her sleeping bag and things are gone.");
              Thread.Sleep(2500);
              lists.AddItem("insideApartmentsDoor4Steal", -1, true);
            }
            else if (lists.CheckBool("insideApartmentsDoor4Kill"))
            {
              Console.Clear();
              if (lists.CheckBool("insideApartmentsDoor4KillHands"))
              {
                Console.WriteLine("The apartment has blood everywhere.");
                Thread.Sleep(2000);
              }

              Console.WriteLine("You see her body lying there, where you left it");
              Thread.Sleep(3000);
              Console.WriteLine("There is nothing more to find here.");
              Thread.Sleep(2500);
              lists.AddItem("insideApartmentsDoor4Done", -1, true);
              Console.Clear();
              Structures.Apartments();
              Console.WriteLine("");
              goto insideApartments;
            }
            else
            {
              Console.Clear();
              Console.WriteLine("The door appears broken, and opens with ease.");
              Thread.Sleep(2000);
              Console.Write("The place is a complete mess");
              Thread.Sleep(1500);
              Console.Write(", but somehow different");
              Thread.Sleep(1500);
              Console.Write(", man-made");
              Thread.Sleep(1000);
              Console.WriteLine(", or rather destroyed.");
              Thread.Sleep(3000);
              Console.WriteLine("You look around for anything or anyone.");
              Thread.Sleep(2000);
              Console.Write("There is not much to be found it seems");
              Thread.Sleep(2000);
              Console.WriteLine(", until you hear a faint sound from the next room.");
              Thread.Sleep(3000);
              Console.Write("As you enter the room you notice a mattress on the floor");
              Thread.Sleep(3000);
              Console.Write(", and a small woman next to it");
              Thread.Sleep(2000);
              Console.WriteLine(" trying to hide and make herself small.");
              Thread.Sleep(4000);
              insideApartmentsDoor4:
              Console.WriteLine("");
              Console.WriteLine("What do you do?");
              Console.WriteLine("1. Calmly try to talk to her.");
              Console.WriteLine("2. Aggressively threaten and steal her things.");
              Console.WriteLine("3. Kill her and take her stuff.");
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
                goto insideApartmentsDoor4;
              }

              switch (lists.GetValue("Input"))
              {
                case 1:
                  Console.Clear();
                  Console.Write("Calmly you talk to her");
                  Thread.Sleep(2000);
                  Console.WriteLine(", assuring that you mean no harm.");
                  Thread.Sleep(2500);
                  Console.WriteLine("With a careful voice she responds, and you talk for a minute");
                  Thread.Sleep(1500);
                  Console.WriteLine("You learn she has lost a precious momento.");
                  Thread.Sleep(2500);
                  Console.WriteLine("The neighbor across the hall beat her up and took it from her.");
                  Thread.Sleep(4000);
                  Console.WriteLine("She wants you to recover her necklace and return it to her.");
                  Thread.Sleep(4000);
                  lists.AddItem("necklaceQuest", -1, true);
                  lists.AddItem("insideApartmentsDoor4Talk", -1, true);
                  Console.Clear();
                  Structures.Apartments();
                  Console.WriteLine("");
                  goto insideApartments;
                case 2:
                  Console.Clear();
                  if (lists.CheckBool("Knife"))
                  {
                    Console.WriteLine(
                      "You pull out your knife and force her to give you what she has.");
                    Thread.Sleep(3500);
                    Console.WriteLine("Reluctantly, she pulls out 25 bucks from behind a dresser.");
                    lists.ModifyValue("Money", i => i + 25);
                  }
                  else if (lists.CheckBool("Crowbar"))
                  {
                    Console.WriteLine(
                      "You pull out your crowbar and force her to give you what she has.");
                    Thread.Sleep(3500);
                    Console.WriteLine("Reluctantly, gives you 20 bucks.");
                    Thread.Sleep(2500);
                    lists.ModifyValue("Money", i => i + 20);
                  }
                  else
                  {
                    Console.WriteLine("You scream at her and force her to give you what she has.");
                    Thread.Sleep(3500);
                    Console.WriteLine("Reluctantly, gives you 10 bucks.");
                    Thread.Sleep(2500);
                    lists.ModifyValue("Money", i => i + 10);
                  }

                  lists.AddItem("insideApartmentsDoor4Steal", -1, true);
                  Console.Clear();
                  Structures.Apartments();
                  Console.WriteLine("");
                  goto insideApartments;
                case 3:
                  insideApartmentsDoor4Kill:
                  Console.Clear();
                  Console.WriteLine("What weapon do you want to use?");
                  Console.WriteLine("- Hands");
                  if (lists.CheckBool("Knife")) Console.WriteLine("- Knife");
                  if (lists.CheckBool("Crowbar")) Console.WriteLine("- Crowbar");
                  try
                  {
                    ItemInput = Console.ReadLine()?.ToLower();
                  }
                  catch
                  {
                    Console.Clear();
                    Console.WriteLine("Invalid input");
                    Thread.Sleep(1500);
                    Console.Clear();
                    goto insideApartmentsDoor4Kill;
                  }

                  switch (ItemInput)
                  {
                    case "hands":
                      Console.Write("You swiftly place your hands around her neck");
                      Thread.Sleep(3000);
                      Console.Write(", squeezing");
                      Thread.Sleep(1000);
                      Console.WriteLine(", tightening your grip.");
                      Thread.Sleep(2000);
                      Console.Write("You hear her gasping for air");
                      Thread.Sleep(2000);
                      Console.WriteLine(", slowly turning quiet.");
                      Thread.Sleep(2000);
                      Console.Write("Her eyes staring at you");
                      Thread.Sleep(2000);
                      Console.Write(", intensely");
                      Thread.Sleep(1000);
                      Console.WriteLine(", begging.");
                      Thread.Sleep(1000);
                      Console.Write("Until you feel the life leave her body");
                      Thread.Sleep(2000);
                      Console.WriteLine(", and her eyes go empty.");
                      Thread.Sleep(4000);
                      Console.Write("From her dead corpse");
                      Thread.Sleep(1500);
                      Console.WriteLine(", you find 5 bucks");
                      lists.ModifyValue("Money", i => i + 5);
                      lists.AddItem("insideApartmentsDoor4KillHands", -1, true);
                      break;
                    case "knife":
                      Console.WriteLine("With a swift motion you stab her in the stomach.");
                      Thread.Sleep(3000);
                      Console.WriteLine("She gasps as the blade enter her body");
                      Thread.Sleep(2000);
                      Console.WriteLine("She starts screaming in pain.");
                      Thread.Sleep(2000);
                      Console.Write("You stab her again");
                      Thread.Sleep(2000);
                      Console.Write(", and again");
                      Thread.Sleep(1500);
                      Console.WriteLine(", until she stops screaming.");
                      Thread.Sleep(2000);
                      Console.Write("Her body collapses towards you");
                      Thread.Sleep(2000);
                      Console.Write(", cold");
                      Thread.Sleep(1000);
                      Console.WriteLine(", lifeless.");
                      Thread.Sleep(3000);
                      Console.Write("From her dead corpse");
                      Thread.Sleep(1500);
                      Console.WriteLine(", you find 5 bucks");
                      Thread.Sleep(2000);
                      lists.ModifyValue("Money", i => i + 5);
                      break;
                    case "crowbar":
                      Console.Write("You swing the crowbar with force");
                      Thread.Sleep(2500);
                      Console.WriteLine(", striking her across the face.");
                      Thread.Sleep(2000);
                      Console.Write("You hear the sound of bones breaking");
                      Thread.Sleep(2500);
                      Console.WriteLine(", as blood splatters across the wall.");
                      Thread.Sleep(2500);
                      Console.Write("She falls to the ground");
                      Thread.Sleep(2000);
                      Console.Write(", her eyes staring at you");
                      Thread.Sleep(2000);
                      Console.WriteLine(", pleading.");
                      Thread.Sleep(1500);
                      insideApartmentsDoor4KillCrowbar:
                      Console.WriteLine("--Do you hit her again?--");
                      Console.WriteLine("1. Yes");
                      Console.WriteLine("2. No");
                      try
                      {
                        Input = Convert.ToInt32(Console.ReadLine());
                      }
                      catch
                      {
                        Console.Clear();
                        Console.WriteLine("Invalid input");
                        Thread.Sleep(1500);
                        Console.Clear();
                        goto insideApartmentsDoor4KillCrowbar;
                      }

                      switch (lists.GetValue("Input"))
                      {
                        case 1:
                          Console.Write("You strike her again");
                          Thread.Sleep(2000);
                          Console.Write(", and again");
                          Thread.Sleep(1500);
                          Console.WriteLine(", until she stops moving.");
                          Thread.Sleep(3000);
                          Console.Write("From her dead corpse");
                          Thread.Sleep(1500);
                          Console.WriteLine(", you find 5 bucks");
                          Thread.Sleep(2000);
                          lists.ModifyValue("Money", i => i + 5);
                          break;
                        case 2:
                          Console.WriteLine("You stand around");
                          Thread.Sleep(1500);
                          Console.Write(" looking at her");
                          Thread.Sleep(1500);
                          Console.WriteLine(", wheezing as she tries stay alive.");
                          Thread.Sleep(2500);
                          Console.Write("The blood is pooling around her head");
                          Thread.Sleep(2500);
                          Console.Write(", as she takes her final breath");
                          Thread.Sleep(2500);
                          Console.WriteLine(", and her eyes goes blank.");
                          Thread.Sleep(3000);
                          Console.Write("From her dead corpse");
                          Thread.Sleep(1500);
                          Console.Write(", you find 5 bucks");
                          lists.ModifyValue("Money", i => i + 5);
                          break;
                      }

                      lists.AddItem("insideApartmentsDoor4Done", -1, true);
                      break;
                    default:
                      goto insideApartmentsDoor4Kill;
                  }

                  lists.AddItem("insideApartmentsDoor4Kill", -1, true);
                  Console.Clear();
                  Structures.Apartments();
                  Console.WriteLine("");
                  goto insideApartments;
              }
            }

            break;
          }
          case 5:
          {
            Console.Clear();
            Console.WriteLine("It looks be some sort of janitors closet.");
            Thread.Sleep(3000);
            Console.Write("It's messy and full of useless utility items");
            Thread.Sleep(2500);
            Console.WriteLine(", but there is a medical cabinet on the wall");
            Thread.Sleep(2500);
            Console.WriteLine("Inside you find a BANDAGE and a bottle of ALCOHOL.");
            lists.ModifyValue("Bandages", i => i + 1);
            lists.ModifyValue("Alchohol", i => i + 1);
            Thread.Sleep(3500);
            Console.Clear();
            Structures.Apartments();
            Console.WriteLine("");
            goto insideApartments;
          }
          case 6:
          {
            Console.Write("You get halfway up the stairs before you notice");
            Thread.Sleep(2500);
            Console.WriteLine(" a big pile of rubble blocking the stairs.");
            Thread.Sleep(2500);
            Console.Write("The stairs looks damaged");
            Thread.Sleep(1500);
            Console.Write(", enough so that even if you clear the rubble");
            Thread.Sleep(2500);
            Console.WriteLine(" you doubt it is safe to pass.");
            Thread.Sleep(3000);
            Console.Clear();
            Structures.Apartments();
            Console.WriteLine("");
            goto insideApartments;
          }
          case 7:
          {
            Console.Clear();
            Console.WriteLine("You leave the apartments back the way you came.");
            Thread.Sleep(3000);
            Apartments();
            break;
          }
          default:
          {
            Console.Clear();
            Console.Write("Invalid input");
            Thread.Sleep(1500);
            Apartments();
            break;
          }
        }

        break;
      }
      case 5:
      {
        if (!lists.CheckBool("Green Gem"))
        {
          if (!lists.CheckBool("insideApartmentsWindow"))
          {
            Console.Clear();
            Console.WriteLine("You walk around the building until you find an open window.");
            Thread.Sleep(2500);
            Console.WriteLine("Carefully, you climb through the window.");
            Thread.Sleep(2500);
            Console.WriteLine("There's not much to the room, other than your standard furniture");
            Thread.Sleep(500);
            Console.Write("...");
            lists.AddItem("insideApartmentsWindow", -1, true);
          }

          Thread.Sleep(1500);
          Console.WriteLine("You spot a small box on a dresser");
          Thread.Sleep(2000);
          if (lists.CheckBool("Key"))
          {
            Console.WriteLine("You use the key to open the box.");
            Thread.Sleep(2000);
            Console.WriteLine("Inside you find, what looks to be, a valuable gem of some kind.");
            Thread.Sleep(3000);
            Console.WriteLine("You got a GREEN GEM.");
            Thread.Sleep(2000);
            lists.AddItem("Green Gem", 0, true);
          }
          else
          {
            Console.Write(", but it seems to be locked. You need to look for the key.");
            Thread.Sleep(2500);
          }

          Console.WriteLine("");
          Console.WriteLine("You try to exit through the door, but it is locked.");
          Thread.Sleep(2500);
          Console.WriteLine("You go back out through the window.");
          Thread.Sleep(2500);
          Apartments();
          break;
        }

        Console.WriteLine("There not anything more for me to do here.");
        Thread.Sleep(2500);
        Apartments();
        break;
      }

      default:
      {
        Console.Clear();
        Console.Write("Invalid input");
        Thread.Sleep(1500);
        Apartments();
        break;
      }
    }
  }
}