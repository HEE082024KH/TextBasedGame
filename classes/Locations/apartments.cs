public class ApartmentsLocation(Locations locations)
{
  private Locations locations = locations;
  Status inventory = locations.inventory;
  Items items = locations.items;
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
                items.healthPoints -= 10;
                items.HP();
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
                if (items.hasCrowbar == true)
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
                if (items.hasHairpin == true)
                {
                  items.hasHairpin = false;
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
                if (items.hasCrowbar == true || items.hasHairpin == true)
                {
                  Console.Clear();
                  if (items.hasCrowbar == true)
                  {
                    Console.WriteLine("You use the crowbar to pry the door open.");
                  }
                  else if (items.hasHairpin == true)
                  {
                    items.hasHairpin = false;
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
                      {
                        Console.Clear();
                        Console.WriteLine("As you walk in man jumps you.");
                        Thread.Sleep(1000);
                        if (items.isBuzzed == true)
                        {
                          Console.WriteLine("Despite feeling buzzed you manage to overpower the man");
                          Thread.Sleep(2500);
                          Console.Write(", ");
                          Console.WriteLine("however, you are hurt in the process.");
                          Thread.Sleep(2000);
                          items.healthPoints -= 20;
                        }
                        else if (items.isDrunk == true)
                        {
                          Console.WriteLine("You barely manage to fight him off");
                          Thread.Sleep(2000);
                          Console.Write(", turns out fighting while drunk is not easy");
                          items.healthPoints -= 30;
                        }
                        else if (items.isHammered == true)
                        {
                          Console.WriteLine("You are hammered.");
                          Thread.Sleep(2000);
                          Console.Write("Before you notice what is going on everything goes black.");
                          Thread.Sleep(3000);
                          items.healthPoints = 0;
                        }
                        else
                        {
                          Console.WriteLine("During the struggle you hurt your arm.");
                          items.healthPoints -= 15;
                        }
                        items.HP();
                        Console.WriteLine("");
                        Console.WriteLine("-15 HP");
                        Thread.Sleep(2000);
                        items.HP();
                        Thread.Sleep(1500);
                        Console.WriteLine("He's not much of a fighter, however, and eventually you knock him out.");
                        Thread.Sleep(2000);
                        Console.WriteLine("You go through his pockets and find a -Knife-");
                        items.hasKnife = true;
                        Thread.Sleep(1500);
                        Console.WriteLine("");
                        goto insideApartments;
                      }
                    case 2:
                      {
                        if (items.isDrunk == false || items.isHammered == false)
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
                        if (items.isBuzzed == true)
                        {
                          Console.WriteLine("Despite feeling buzzed you charge the man and knock him to the ground");
                          Thread.Sleep(3500);
                          Console.WriteLine("Eventually, with a bit of fumbling, you manage to knock him out.");
                          Thread.Sleep(3000);
                          items.healthPoints -= 5;
                        }
                        else if (items.isDrunk == true)
                        {
                          Console.WriteLine("You walk inside and get jumped by a strange man.");
                          Thread.Sleep(3500);
                          Console.WriteLine("You struggle to overpower him, but eventually you manage to knock him out.");
                          Thread.Sleep(3000);
                          items.healthPoints -= 15;
                        }
                        else if (items.isHammered == true)
                        {
                          Console.WriteLine("You are hammered.");
                          Thread.Sleep(1500);
                          Console.WriteLine("You walk inside and suddenly everything goes black.");
                          Thread.Sleep(3500);
                          items.healthPoints = 0;
                        }
                        else
                        {
                          Console.WriteLine(
                            "You catch him off guard by quickly charging him and knocking him to the ground.");
                          Thread.Sleep(2000);
                          Console.WriteLine("With a quick strike you knock him out cold.");
                          Thread.Sleep(1500);
                        }
                        items.HP();
                        Console.WriteLine("You go through his pockets and find a -Knife-");
                        items.hasKnife = true;
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
                  Console.WriteLine("With a careful voice she responds");
                  Thread.Sleep(1500);
                  Console.Write(", and you learn she has lost a precious momento.");
                  Thread.Sleep(2500);
                  Console.WriteLine("The neighbor across the hall beat her up and took it from her.");
                  Thread.Sleep(4000);
                  Console.WriteLine("She wants you to recover her necklace and return it to her.");
                  Thread.Sleep(4000);
                  items.hasNecklaceQuest = true;
                  Console.WriteLine(">");
                  Console.ReadLine();
                  break;
                case 2:
                  if (items.hasKnife == true)
                  { 
                    Console.WriteLine("You pull out your knife and force her to give you what she has.");
                    Thread.Sleep(3500);
                    Console.WriteLine();
                  }
                  else if (items.hasCrowbar == true)
                  {
                    Console.WriteLine("");
                  }
                  else
                  {
                    Console.WriteLine("");
                  }
                  break;
                case 3:
                  Console.WriteLine("");
                  break;
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
                Console.WriteLine("Inside you find a bandage and a bottle of alcohol.");
                items.hasBandages = true;
                items.bandages = items.bandages++;
                items.hasAlcohol = true;
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
          if (items.hasKey == true)
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