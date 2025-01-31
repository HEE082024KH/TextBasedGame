public class ApartmentsLocation(Locations locations)
{
  private Locations locations = locations;
  Status inventory = locations.inventory;
  Items items = locations.items;
  private bool insideApartmentsDoor2;
  private bool insideApartmentsDoor4;
  private bool insideApartmentsDoor4Talk;
  private bool insideApartmentsDoor4Steal;
  private bool insideApartmentsDoor4Kill;
  private bool insideApartmentsDoor4Done;
  public void Apartments()
  {
    locations.currentLocation = "Apartments";
    Console.Clear();
    Console.WriteLine($"You are at the  -{locations.currentLocation}-");
    Console.WriteLine("");
    Console.WriteLine("---What do you want to do?---");
    Console.WriteLine("1. Travel to a different location");
    Console.WriteLine("2. Check status");
    Console.WriteLine("3. Look around outside");
    Console.WriteLine("4. Go in the front door");
    Console.WriteLine("5. Look for an open window");
    try
    {
      locations.input = Convert.ToInt32(Console.ReadLine());
    }
    catch
    {
      Console.WriteLine("");
      Console.WriteLine("Invalid input");
      Thread.Sleep(1500);
      Apartments();
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
          inventory.ShowStatus();
          Apartments();
          break;
        }
      case 3:
        {
          Console.Clear();
          Console.WriteLine("There's a few bags of trash scattered along the walls");
          Console.WriteLine("");
          Console.WriteLine("---What do you want to do?---");
          Console.WriteLine("1. Search the bags");
          Console.WriteLine("2. Leave them alone");
          try
          {
            locations.input = Convert.ToInt32(Console.ReadLine());
          }
          catch
          {
            Console.WriteLine("Invalid input");
          }
          switch (locations.input)
          {
            case 1:
              {
                Console.Clear();
                Console.WriteLine("You rummage through the bags, looking for anything of use.");
                Thread.Sleep(2000);
                Console.WriteLine("Looking through one of the bags, you cut your hand on a sharp object");
                Thread.Sleep(3000);
                items.HealthPoints -= 10;
                items.Hp();
                Console.WriteLine("");
                Console.WriteLine("-10 HP");
                Thread.Sleep(2000);
                Apartments();
                break;
              }
            case 2:
              {
                Console.Clear();
                Console.WriteLine("You leave the bags alone.");
                Thread.Sleep(2000);
                Console.WriteLine("Who knows what kind of diseases are in those bags.");
                Thread.Sleep(2000);
                Apartments();
                break;
              }
          }
          break;
        }
      case 4:
        {
        insideApartments:
          Console.Clear();
          Console.WriteLine("The door opens with a nasty creak");
          Thread.Sleep(1000);
          Console.WriteLine(", sure to notify anyone nearby.");
          Thread.Sleep(2000);
          Console.WriteLine("Inside there's a small hallway with a door at the end,");
          Console.WriteLine("and 2 doors on either side.");
          Thread.Sleep(2000);
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
            locations.input = Convert.ToInt32(Console.ReadLine());
          }
          catch
          {
            goto insideApartments;
          }
          switch (locations.input)
          {
            case 1:
              {
                Console.Clear();
                if (items.Crowbar)
                {
                  Console.WriteLine("You use the crowbar to pry the door open.");
                  Thread.Sleep(1000);
                  Console.WriteLine("With a loud crack the door opens");
                  Thread.Sleep(2000);
                  Console.WriteLine("The room looks to be a maintenance room of sorts");
                  Thread.Sleep(1000);
                  Console.WriteLine("Not much to find here");
                  Thread.Sleep(2000);
                  goto insideApartments;
                }
                if (items.Hairpin)
                {
                  items.Hairpin = false;
                  Console.WriteLine("You use the hairpin to unlock the door.");
                  Thread.Sleep(2000);
                  Console.WriteLine("The room looks to be a maintenance room of sorts");
                  Thread.Sleep(1000);
                  Console.WriteLine("Not much to find here");
                  Thread.Sleep(2000);
                  goto insideApartments;
                }
                else
                {
                  Console.WriteLine("The door is locked");
                  Thread.Sleep(1000);
                  Console.WriteLine("If only I had a crowbar or something to unlock down the door");
                  Thread.Sleep(3000);
                  goto insideApartments;
                }
              }
            case 2:
              {
                if (items.Crowbar || items.Hairpin)
                {
                  Console.Clear();
                  if (items.Crowbar)
                  {
                    Console.WriteLine("You use the crowbar to pry the door open.");
                  }
                  else if (items.Hairpin)
                  {
                    items.Hairpin = false;
                    Console.WriteLine("You use the hairpin to unlock the door.");
                  }
                insideApartmentsDoor2:
                  Thread.Sleep(1000);
                  Console.WriteLine("The door opens with ease");
                  Thread.Sleep(500);
                  Console.Write(", almost too easy");
                  Thread.Sleep(1500);
                  Console.WriteLine("");
                  Console.WriteLine("What do you want to do?");
                  Console.WriteLine("1. Just walk in");
                  Console.WriteLine("2. Hug the wall and sneakily look inside");
                  try
                  {
                    locations.input = Convert.ToInt32(Console.ReadLine());
                  }
                  catch
                  {
                    Console.WriteLine("Invalid input");
                    Thread.Sleep(2000);
                    goto insideApartmentsDoor2;
                  }
                  switch (locations.input)
                  {
                    case 1:
                      if (!insideApartmentsDoor2)
                      {
                        Console.Clear();
                        Console.WriteLine("As you walk in man jumps you.");
                        Thread.Sleep(1000);
                        if (items.IsBuzzed)
                        {
                          Console.WriteLine("Despite feeling buzzed you manage to overpower the man");
                          Thread.Sleep(2500);
                          Console.Write(", ");
                          Console.WriteLine("however, you are hurt in the process.");
                          Thread.Sleep(2000);
                          items.HealthPoints -= 20;
                        }
                        else if (items.IsDrunk)
                        {
                          Console.WriteLine("You barely manage to fight him off");
                          Thread.Sleep(2000);
                          Console.Write(", turns out fighting while drunk is not easy");
                          items.HealthPoints -= 30;
                        }
                        else if (items.IsHammered)
                        {
                          Console.WriteLine("You are hammered.");
                          Thread.Sleep(2000);
                          Console.Write("Before you notice what is going on everything goes black.");
                          Thread.Sleep(3000);
                          items.HealthPoints = 0;
                        }
                        else
                        {
                          Console.WriteLine("During the struggle you hurt your arm.");
                          items.HealthPoints -= 15;
                        }
                        items.Hp();
                        Console.WriteLine("");
                        Console.WriteLine("-15 HP");
                        Thread.Sleep(2000);
                        items.Hp();
                        Thread.Sleep(1500);
                        Console.WriteLine("He's not much of a fighter, however, and eventually you knock him out.");
                        Thread.Sleep(2000);
                        Console.WriteLine("You go through his pockets and find a -Knife-");
                        items.Knife = true;
                        if (items.NecklaceQuest)
                        {
                          items.NecklaceQuest = false;
                          Console.WriteLine("You also find the woman's necklace");
                          items.Necklace = true;
                        }
                        insideApartmentsDoor2 = true;
                        Thread.Sleep(1500);
                      }
                      else if (!items.Necklace && items.NecklaceQuest)
                      {
                        Console.WriteLine("You see the man lying on the floor.");
                      };
                      goto insideApartments;
                    case 2:
                      {
                        if (!items.IsDrunk || !items.IsHammered)
                        {
                          Console.Clear();
                          Console.WriteLine("As you sneakily look inside");
                          Thread.Sleep(500);
                          Console.Write(", you notice a man waiting to jump you.");
                        }
                        else
                        {
                          Console.Clear();
                          Console.WriteLine("You look inside");
                          Thread.Sleep(500);
                          Console.Write(", but you do not notice anything.");
                        }
                        Thread.Sleep(1500);
                        if (items.IsBuzzed)
                        {
                          Console.WriteLine("Despite feeling buzzed you charge the man and knock him to the ground");
                          Thread.Sleep(3500);
                          Console.WriteLine("Eventually, with a bit of fumbling, you manage to knock him out.");
                          Thread.Sleep(3000);
                          items.HealthPoints -= 5;
                        }
                        else if (items.IsDrunk)
                        {
                          Console.WriteLine("You walk inside and get jumped by a strange man.");
                          Thread.Sleep(3500);
                          Console.WriteLine("You struggle to overpower him, but eventually you manage to knock him out.");
                          Thread.Sleep(3000);
                          items.HealthPoints -= 15;
                        }
                        else if (items.IsHammered)
                        {
                          Console.WriteLine("You are hammered.");
                          Thread.Sleep(1500);
                          Console.WriteLine("You walk inside and suddenly everything goes black.");
                          Thread.Sleep(3500);
                          items.HealthPoints = 0;
                        }
                        else
                        {
                          Console.WriteLine(
                            "You catch him off guard by quickly charging him and knocking him to the ground.");
                          Thread.Sleep(2000);
                          Console.WriteLine("With a quick strike you knock him out cold.");
                          Thread.Sleep(1500);
                        }
                        items.Hp();
                        Console.WriteLine("You go through his pockets and find a -Knife-");
                        items.Knife = true;
                        Thread.Sleep(1500);
                        goto insideApartments;
                      }
                    default:
                      {
                        goto insideApartments;
                      }
                  }
                }
                else
                {
                  Console.Clear();
                  Console.WriteLine("The door is locked");
                  Thread.Sleep(1000);
                  Console.WriteLine("If only I had a crowbar or something to unlock down the door");
                  Thread.Sleep(3000);
                  goto insideApartments;
                }
              }
            case 3:
            {
              ;
              break;
            }
            case 4:
            {
              if (!insideApartmentsDoor4Done || !insideApartmentsDoor4Kill || !insideApartmentsDoor4Steal || !insideApartmentsDoor4Talk)
              {
                Console.WriteLine("The door appears broken, and opens with ease.");
                Thread.Sleep(2000);
                Console.WriteLine("The place is a complete mess");
                Thread.Sleep(1500);
                Console.Write(", but somehow different");
                Thread.Sleep(1500);
                Console.Write(", man-made");
                Thread.Sleep(1000);
                Console.Write(", or rather destroyed.");
                Thread.Sleep(3000);
                Console.WriteLine("You look around for anything or anyone.");
                Thread.Sleep(2000);
                Console.WriteLine("There is not much to be found it seems");
                Thread.Sleep(2000);
                Console.WriteLine(", until you hear a faint sound from the next room.");
                Thread.Sleep(3000);
                Console.WriteLine("As you enter the room you notice a mattress on the floor");
                Thread.Sleep(3000);
                Console.Write(", and a small woman next to it");
                Thread.Sleep(2000);
                Console.Write(" trying to hide and make herself small.");
                Thread.Sleep(4000);
                Console.Clear();
                insideApartmentsDoor4:
                Console.WriteLine("As you enter the room you notice a mattress on the floor, " +
                                "and a small woman next to it trying to hide and make herself small.");
                Console.WriteLine("");
                Console.WriteLine("What do you do?");
                Console.WriteLine("1. Calmly try to talk to her.");
                Console.WriteLine("2. Aggressively threaten and steal her things.");
                Console.WriteLine("3. Try to kill her.");
                try
                {
                  locations.input = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                  Console.WriteLine("");
                  goto insideApartmentsDoor4;
                }
                switch (locations.input)
                {
                  case 1:
                  Console.WriteLine("Calmly you talk to her");
                  Thread.Sleep(2000);
                  Console.Write(", assuring that you mean no harm.");
                  Thread.Sleep(2500);
                  Console.WriteLine("With a careful voice she responds, and you talk for a minute");
                  Thread.Sleep(1500);
                  Console.Write("You learn she has lost a precious momento.");
                  Thread.Sleep(2500);
                  Console.WriteLine("The neighbor across the hall beat her up and took it from her.");
                  Thread.Sleep(4000);
                  Console.WriteLine("She wants you to recover her necklace and return it to her.");
                  Thread.Sleep(4000);
                  items.NecklaceQuest = true;
                  insideApartmentsDoor4Talk = true;
                  Console.WriteLine(">");
                  Console.ReadLine();
                  insideApartmentsDoor4Talk = true;
                  break;
                  case 2:
                  if (items.Knife)
                  {
                    Console.WriteLine("You pull out your knife and force her to give you what she has.");
                    Thread.Sleep(3500);
                    Console.WriteLine("Reluctantly, she pulls out 25 bucks from behind a dresser.");
                    items.Money += 25;
                  }
                  else if (items.Crowbar)
                  {
                    Console.WriteLine("You pull out your crowbar and force her to give you what she has.");
                    Thread.Sleep(3500);
                    Console.WriteLine("Reluctantly, gives you 20 bucks.");
                    items.Money += 20;
                  }
                  else
                  {
                    Console.WriteLine("You scream at her and force her to give you what she has.");
                    Thread.Sleep(3500);
                    Console.WriteLine("Reluctantly, gives you 10 bucks.");
                    items.Money += 10;
                  }

                  insideApartmentsDoor4Steal = true;
                  break;
                  case 3:
                    insideApartmentsDoor4Kill:
                    Console.WriteLine("What weapon do you want to use?");
                    Console.WriteLine("- Hands");
                    if (items.Knife)
                    {
                      Console.WriteLine("- Knife");
                    }
                    if (items.Crowbar)
                    {
                      Console.WriteLine("- Crowbar");
                    }
                    try
                    {
                      inventory.itemInput = Console.ReadLine().ToLower();
                    }
                    catch
                    {
                      Console.WriteLine("Invalid input");
                      goto insideApartmentsDoor4Kill;
                    }
                    switch (inventory.itemInput)
                    {
                      case "hands":
                        Console.WriteLine("You swiftly place your hands around her neck");
                        Thread.Sleep(3000);
                        Console.Write(", squeezing");
                        Thread.Sleep(1000);
                        Console.Write(", tightening your grip.");
                        Thread.Sleep(2000);
                        Console.WriteLine("You hear her gasping for air");
                        Thread.Sleep(2000);
                        Console.Write(", slowly turning quiet.");
                        Thread.Sleep(2000);
                        Console.WriteLine("Her eyes staring at you");
                        Thread.Sleep(2000);
                        Console.Write(", intensely");
                        Thread.Sleep(1000);
                        Console.Write(", begging.");
                        Thread.Sleep(1000);
                        Console.WriteLine("Until you feel the life leave her body");
                        Thread.Sleep(2000);
                        Console.Write(", and her eyes go empty.");
                        Thread.Sleep(4000);
                        Console.WriteLine("From her dead corpse");
                        Thread.Sleep(1500);
                        Console.Write(", you find 5 bucks");
                        items.Money += 5;
                        break;
                      case "knife":
                        Console.WriteLine("With a swift motion you stab her in the stomach.");
                        Thread.Sleep(3000);
                        Console.WriteLine("She gasps as the blade enter her body");
                        Thread.Sleep(2000);
                        Console.Write("She starts screaming in pain.");
                        Thread.Sleep(2000);
                        Console.WriteLine("You stab her again");
                        Thread.Sleep(2000);
                        Console.Write(", and again");
                        Thread.Sleep(1500);
                        Console.Write(", until she stops screaming.");
                        Thread.Sleep(2000);
                        Console.WriteLine("Her body collapses towards you");
                        Thread.Sleep(2000);
                        Console.Write(", cold");
                        Thread.Sleep(1000);
                        Console.Write(", lifeless.");
                        Thread.Sleep(3000);
                        Console.WriteLine("From her dead corpse");
                        Thread.Sleep(1500);
                        Console.Write(", you find 5 bucks");
                        items.Money += 5;
                        break;
                      case "crowbar":
                        ;
                        break;
                    }
                    insideApartmentsDoor4Kill = true;
                    break;
                }
              }
              else if (insideApartmentsDoor4Done)
              {
                
              }
              else if (insideApartmentsDoor4Talk)
              {
                if (items.Necklace)
                {
                  Console.WriteLine("Her face lights up as you enter.");
                  Thread.Sleep(2500);
                  Console.WriteLine("You hand the necklace over to her");
                  Thread.Sleep(2500);
                  Console.WriteLine("With great appreciation she thanks you.");
                  Thread.Sleep(2500);
                  Console.WriteLine("She gives you a -key- in return.");
                  Thread.Sleep(2000);
                  Console.WriteLine("She is unsure where it fits, but she found it on this floor.");
                  Thread.Sleep(3000);
                  Console.WriteLine("If I look around a bit I might figure where to use it.");
                  Thread.Sleep(2500);
                  insideApartmentsDoor4Done = true;
                }
              }
              else if (insideApartmentsDoor4Steal)
              {
                Console.WriteLine("You enter the apartment looking for the woman.");
                Thread.Sleep(2500);
                Console.WriteLine("You look around but she is nowhere to be found.");
                Thread.Sleep(3000);
                Console.WriteLine("");
              }
              else if (insideApartmentsDoor4Kill)
              {
                
              } 
              break;
            }
            case 5:
              {
                Console.WriteLine("It looks be some sort of janitors closet.");
                Thread.Sleep(3000);
                Console.WriteLine("It's messy and full of useless utility items");
                Thread.Sleep(2500);
                Console.Write(", but there is a medical cabinet on the wall");
                Thread.Sleep(2500);
                Console.WriteLine("Inside you find a -bandage- and a bottle of -Alcohol-.");
                items.Bandages = items.Bandages++;
                items.Alcohol = items.Alcohol++;
                Thread.Sleep(2500);
                Console.WriteLine(">");
                Console.ReadLine();
                goto insideApartments;
              }
            case 6:
            {
              Console.WriteLine("You get halfway up the stairs before you notice ");
              Thread.Sleep(2500);
              Console.Write("a big pile of rubble blocking the stairs.");
              Thread.Sleep(2500);
              Console.WriteLine("The stairs looks damaged");
              Thread.Sleep(1500);
              Console.Write(", enough so that even if you clear the rubble");
              Thread.Sleep(2500);
              Console.Write(" you doubt it is safe to pass");
              Console.WriteLine(">");
              Console.ReadLine();
              goto insideApartments;
            }
            case 7:
              {
                Console.WriteLine("You leave the apartments back the way you came.");
                Thread.Sleep(3000);
                Apartments();
                break;
              }
            default:
              {
                Console.Clear();
                Console.Write("---Invalid input---");
                Thread.Sleep(1000);
                Apartments();
                break;
              }
          }
          break;
        }
      case 5:
        {
          Console.Clear();
          Console.WriteLine("You walk around the building until you find an open window.");
          Thread.Sleep(2500);
          Console.WriteLine("Carefully, you climb through the window.");
          Thread.Sleep(2500);
          Console.WriteLine("There's not much to the room, other than your standard furniture");
          Thread.Sleep(500);
          Console.Write("...");
          Thread.Sleep(1500);
          Console.WriteLine("You spot a small box on a dresser");
          Thread.Sleep(2000);
          if (items.Key)
          {
            Console.WriteLine("You use the key to open the box.");
            Thread.Sleep(2000);
            Console.WriteLine("Inside you find, what looks to be, a valuable gem of some kind.");
            Thread.Sleep(3000);
          }
          else
          {
            Console.Write(", but it seems to be locked. I need to look for the key.");
            Thread.Sleep(2500);
          }
          Console.WriteLine("You try to exit through the door, but it is locked.");
          Thread.Sleep(2500);
          Console.WriteLine("You go back out through the window.");
          Thread.Sleep(2000);
          Console.WriteLine(">");
          Console.ReadLine();
          Apartments();
          break;
        }
      default:
        {
          Console.Clear();
          Console.Write("---Invalid input---");
          Thread.Sleep(1000);
          Apartments();
          break;
        }
    }
  }
}