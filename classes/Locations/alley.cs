using TextBasedGame.classes;

public class AlleyLocation(Locations locations, Lists lists, Status status)
{
  public void Alley()
  {
    while (true)
    {
      if (!lists.CheckBool("alley"))
      {
        Console.Clear();
        Console.Write("Between two shabby buildings");
        Thread.Sleep(2000);
        Console.WriteLine(" there is a murky alley leading away from the lights.");
        Thread.Sleep(4000);
        Console.Write("Faint sounds of people can be heard");
        Thread.Sleep(3000);
        Console.WriteLine(", hard to tell if friendly or not.");
        Thread.Sleep(3500);
        lists.AddItem("alley", -1, true);
      }

      lists.CurrentLocation = "Alley";
      Console.Clear();
      Console.WriteLine($"You are at the -{lists.CurrentLocation}-");
      Thread.Sleep(500);
      Console.WriteLine("");
      Console.WriteLine("--What do you want to do?--");
      Console.WriteLine("1. Travel to a different location");
      Console.WriteLine("2. Check status");
      Console.WriteLine("3. Enter the alley");
      try
      {
        lists.ModifyInt("Input", Convert.ToInt32(Console.ReadLine()));
      }
      catch
      {
        Console.Clear();
        Console.WriteLine("Invalid input");
        Thread.Sleep(1500);
        Alley();
      }

      switch (lists.GetValue("Input"))
      {
        case 1:
          locations.LocationSelector();
          break;
        case 2:
          Console.Clear();
          status.ShowStatus();
          continue;
        case 3:
          if (!lists.CheckBool("alleyMan"))
          {
            Console.Clear();
            Console.Write("As you walk down the alley");
            Thread.Sleep(2500);
            Console.WriteLine(" you come across a man blocking the road.");
            Thread.Sleep(3000);
            Console.WriteLine("The man is tall and wide, strong and intimidating.");
            Thread.Sleep(4000);
            lists.AddItem("alleyMan", -1, true);
            Console.WriteLine("");
          }

          alley:
          Console.WriteLine("--What do you want to do?--");
          Console.WriteLine("1. Approach the man");
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
            goto alley;
          }

          switch (lists.GetValue("Input"))
          {
            case 1:
              Console.Clear();
              if (lists.CheckBool("Gun"))
              {
                if (!lists.CheckBool("alleyManGun"))
                {
                  Console.Clear();
                  Console.WriteLine("Your approach the man.");
                  Thread.Sleep(2500);
                  Console.WriteLine("He just stares ominously at you.");
                  Thread.Sleep(3000);
                  Console.WriteLine("You pull out your Gun and points it at him.");
                  Thread.Sleep(3500);
                  Console.WriteLine("He continues staring at you.");
                  Thread.Sleep(3000);
                  Console.WriteLine("Without changing expressions he stand aside and lets you pass.");
                  Thread.Sleep(4000);
                  Console.Write("As you turn the corner");
                  Thread.Sleep(2500);
                  Console.WriteLine("the area opens up with people everywhere.");
                  Thread.Sleep(3500);
                  Console.WriteLine("Stands and shops, selling all kinds of things and services");
                  Thread.Sleep(4000);
                  Console.WriteLine("How can there be this many people here when it is dead everywhere else?");
                  Thread.Sleep(4500);
                  Console.WriteLine("There is a so much going on here you don't even know where to start.");
                  Thread.Sleep(4500);
                  Console.Write("The alley is a deadend");
                  Thread.Sleep(2500);
                  Console.WriteLine(", tall buildings surrounds the market on all sides.");
                  Thread.Sleep(3500);
                  Console.WriteLine("You notice a lone steel door along the left wall.");
                  Thread.Sleep(3500);
                  Console.Write("Looks like the kind of door that should be heavily guarded");
                  Thread.Sleep(3500);
                  Console.WriteLine(", but it is not.");
                  Thread.Sleep(2500);
                  lists.AddItem("alleyManGun", -1, true);
                  Console.WriteLine("");
                }
                else
                {
                  Console.Clear();
                  Console.WriteLine("");
                  Thread.Sleep(2000);
                }

                alleyBackyard:
                Console.WriteLine("--What do you want to do?--");
                Console.WriteLine("1. Try to enter the lone steel door");
                Console.WriteLine("2. Walk around the open area");
                Console.WriteLine("3. Check out the stand and shops");
                Console.WriteLine("4. Talk with people");
                Console.WriteLine("5. Leave");
                try
                {
                  lists.ModifyInt("Input", Convert.ToInt32(Console.ReadLine()));
                }
                catch
                {
                  Console.Clear();
                  Console.WriteLine("Invalid input");
                  Thread.Sleep(1500);
                  goto alleyBackyard;
                }

                switch (lists.GetValue("Input"))
                {
                  case 1:
                    Console.Clear();
                    Structures.SteelDoor();
                    if (!lists.CheckBool("alleyUnderground"))
                    {
                      Console.WriteLine("You approach the steel door.");
                      Thread.Sleep(2500);
                      Console.WriteLine("Carefully, you look around you.");
                      Thread.Sleep(2500);
                      Console.WriteLine("No one seems to care.");
                      Thread.Sleep(2500);
                      if (lists.CheckBool("Credit Card"))
                      {
                        Console.WriteLine("After trying a few things");
                        Thread.Sleep(2500);
                        Console.WriteLine(" you attempt using the Credit Card to open the door.");
                        Thread.Sleep(3500);
                        Console.WriteLine("Seems like the Credit Card works as some sort of access card.");
                        Thread.Sleep(4000);
                        Console.WriteLine("The door opens with a distinct metallic sound.");
                        Thread.Sleep(3500);
                        Console.WriteLine("It reveals a dimly lit staircase");
                        Thread.Sleep(3000);
                        Console.WriteLine(" leading down deep underground.");
                        Thread.Sleep(3500);
                        lists.AddItem("alleyUnderground", -1, true);
                        goto alleyUnderground;
                      }

                      Console.Write("You try to open the door");
                      Thread.Sleep(2500);
                      Console.WriteLine(", but it appears to be locked.");
                      Thread.Sleep(2500);
                      Console.Write("There is no key slot, however");
                      Thread.Sleep(2500);
                      Console.WriteLine(", not sure what opens this door.");
                      Thread.Sleep(4000);
                      goto alleyBackyard;
                    }

                    Console.WriteLine("You approach the steel door and use the Credit Card to enter.");
                    Thread.Sleep(4500);
                    alleyUnderground:
                    if (!lists.CheckBool("alleyUndergroundStart"))
                    {
                      Console.Clear();
                      Console.WriteLine("You proceed down the stairs");
                      Thread.Sleep(2500);
                      Console.WriteLine(" until finally you reach the bottom.");
                      Thread.Sleep(3000);
                      Console.Write("You walk out into a massive open area");
                      Thread.Sleep(3000);
                      Console.WriteLine(", looks like an old sewer system of some kind.");
                      Thread.Sleep(3000);
                      Console.WriteLine("There are people everywhere");
                      Thread.Sleep(2500);
                      Console.WriteLine(" doing all kinds of things.");
                      Thread.Sleep(2500);
                      Console.WriteLine("People dealing and using drugs");
                      Thread.Sleep(2500);
                      Console.WriteLine(" all out in the open.");
                      Thread.Sleep(3000);
                      Console.WriteLine("Prostitutes serving customers in plain view.");
                      Thread.Sleep(3500);
                      Console.WriteLine("People getting beaten to a pulp by what appears to be gangs.");
                      Thread.Sleep(4000);
                      Console.WriteLine("It is like there is a whole city living down here");
                      Thread.Sleep(4000);
                      Console.WriteLine(", a criminal safe haven of sin.");
                      Thread.Sleep(3000);
                      Console.Write("Suddenly, two scantily clothed women approaches you");
                      Thread.Sleep(3500);
                      Console.WriteLine(", touching you all over.");
                      Thread.Sleep(2500);
                      Console.WriteLine("They try to lead you inside one of the shabby buildings nearby.");
                      Thread.Sleep(4000);
                      Console.WriteLine("");
                      alleyUndergroundWomen:
                      Console.WriteLine("--What do you want to do?--");
                      Console.WriteLine("1. Go with them");
                      Console.WriteLine("2. Reject them");
                      try
                      {
                        lists.ModifyInt("Input", Convert.ToInt32(Console.ReadLine()));
                      }
                      catch
                      {
                        Console.Clear();
                        Console.WriteLine("Invalid input");
                        Thread.Sleep(1500);
                        goto alleyUndergroundWomen;
                      }

                      switch (lists.GetValue("Input"))
                      {
                        case 1:
                          Console.Clear();
                          Console.WriteLine("You follow the women into the building");
                          Thread.Sleep(3000);
                          Console.WriteLine("They start to move sensually as they undress each other.");
                          Thread.Sleep(4000);
                          Console.WriteLine("One of them start to remove your pants");
                          Thread.Sleep(3000);
                          Console.Write("As you prepare for the pleasure that awaits");
                          Thread.Sleep(3000);
                          Console.WriteLine(" you feel a sharp pain in your thigh.");
                          Thread.Sleep(3000);
                          Console.Write("You look down at a knife stuck in your thigh");
                          Thread.Sleep(3000);
                          Console.WriteLine(", blood trickles as you feel intense pain.");
                          Thread.Sleep(3000);
                          Console.WriteLine("-50 HP");
                          Thread.Sleep(3000);
                          lists.ModifyValue("HP", i => i - 50);
                          lists.Hp();
                          Console.Write("Before you can react");
                          Thread.Sleep(2500);
                          Console.WriteLine(" the other woman holds a knife to your throat.");
                          Thread.Sleep(3500);
                          Console.WriteLine("They start go through your pockets.");
                          Thread.Sleep(3000);
                          Console.WriteLine("");
                          alleyUndergroundWomenKnife:
                          Console.WriteLine("--What do you want to do?--");
                          Console.WriteLine("1. Let them");
                          Console.WriteLine("2. Resist");
                          try
                          {
                            lists.ModifyInt("Input", Convert.ToInt32(Console.ReadLine()));
                          }
                          catch
                          {
                            Console.Clear();
                            Console.WriteLine("Invalid input");
                            Thread.Sleep(1500);
                            goto alleyUndergroundWomenKnife;
                          }

                          switch (lists.GetValue("Input"))
                          {
                            case 1:
                              Console.Clear();
                              Console.Write("After going through your pockets");
                              Thread.Sleep(2500);
                              Console.WriteLine(" they take off with all your Money.");
                              Thread.Sleep(4000);
                              lists.ModifyInt("Money", 0);
                              break;
                            case 2:
                              Console.Clear();
                              Console.WriteLine("You try to stop them.");
                              Thread.Sleep(2500);
                              Console.WriteLine("With a swift motion the other woman slits your throat.");
                              Thread.Sleep(4000);
                              Console.WriteLine("Bloor pours out as you start to choke.");
                              Thread.Sleep(3000);
                              lists.ModifyInt("HP", 0);
                              lists.Hp();
                              break;
                          }

                          break;
                        case 2:
                          Console.Clear();
                          Console.WriteLine("You feel them tugging your arm as you break free.");
                          Thread.Sleep(3500);
                          Console.WriteLine("With a frown on their face they act all disappointed.");
                          Thread.Sleep(4000);
                          Console.Write("Missed opportunity?");
                          Thread.Sleep(2500);
                          Console.WriteLine(", or was something just off?");
                          Thread.Sleep(4000);
                          break;
                      }

                      lists.AddItem("alleyUndergroundStart", -1, true);
                    }

                    Console.Clear();
                    Console.WriteLine("You look around the big open area.");
                    Thread.Sleep(3000);
                    Console.WriteLine("There is a lot to explore here");
                    Thread.Sleep(2500);
                    Console.WriteLine("");
                    alleyUndergroundStart:
                    Console.WriteLine("--What do you want to do?--");
                    Console.WriteLine("1. Check out the buildings on the left");
                    Console.WriteLine("2. Check out the buildings on the right");
                    Console.WriteLine("3. Check out the courtyard area");
                    Console.WriteLine("4. Go forward, deeper underground");
                    Console.WriteLine("5. Leave");
                    try
                    {
                      lists.ModifyInt("Input", Convert.ToInt32(Console.ReadLine()));
                    }
                    catch
                    {
                      Console.Clear();
                      Console.WriteLine("Invalid input");
                      Thread.Sleep(1500);
                      goto alleyUndergroundStart;
                    }

                    switch (lists.GetValue("Input"))
                    {
                      case 1:
                        Console.Clear();
                        Console.WriteLine("There are three buildings on the left.");
                        Thread.Sleep(3000);
                        Console.Write("They look quite primitive");
                        Thread.Sleep(2500);
                        Console.WriteLine(", made of a combination of various materials.");
                        Thread.Sleep(3500);
                        Console.WriteLine("There are a few shady looking people hanging out by the last one.");
                        Thread.Sleep(4000);
                        Console.WriteLine("");
                        alleyUndergroundLeft:
                        Console.WriteLine("--What do you want to do?--");
                        Console.WriteLine("1. Check out the first building");
                        Console.WriteLine("2. Check out the second building");
                        Console.WriteLine("3. Check out the last building");
                        try
                        {
                          lists.ModifyInt("Input", Convert.ToInt32(Console.ReadLine()));
                        }
                        catch
                        {
                          Console.Clear();
                          Console.WriteLine("Invalid input");
                          Thread.Sleep(1500);
                          goto alleyUndergroundLeft;
                        }

                        switch (lists.GetValue("Input"))
                        {
                          case 1:
                            Console.Clear();
                            Console.WriteLine("You enter the first building.");
                            Thread.Sleep(2500);
                            Console.WriteLine("There are a bunch of boxes with a weapons logo on them.");
                            Thread.Sleep(3500);
                            Console.WriteLine("Not sure if it is smart to look inside or not.");
                            Thread.Sleep(3000);
                            Console.WriteLine("");
                            alleyUndergroundLeftFirst:
                            Console.WriteLine("--What do you want to do?--");
                            Console.WriteLine("1. Check out the boxes");
                            Console.WriteLine("2. Leave them");
                            try
                            {
                              lists.ModifyInt("Input", Convert.ToInt32(Console.ReadLine()));
                            }
                            catch
                            {
                              Console.Clear();
                              Console.WriteLine("Invalid input");
                              Thread.Sleep(1500);
                              goto alleyUndergroundLeftFirst;
                            }

                            switch (lists.GetValue("Input"))
                            {
                              case 1:
                                Console.Clear();
                                Console.WriteLine("You start searching the boxes for anything useful.");
                                Thread.Sleep(3500);
                                Console.WriteLine("While searching one of the boxes someone grabs you from behind.");
                                Thread.Sleep(4000);
                                Console.WriteLine("Before you realize what happened you get tossed out with ease.");
                                Thread.Sleep(4000);
                                Console.WriteLine("-15 HP");
                                Thread.Sleep(2000);
                                lists.ModifyValue("HP", i => i - 15);
                                Console.WriteLine("You look back a large man");
                                Thread.Sleep(2500);
                                Console.WriteLine(" expressing in no short terms, to not come back here.");
                                Thread.Sleep(4000);
                                Console.Clear();
                                goto alleyUndergroundLeft;
                              case 2:
                                Console.Clear();
                                goto alleyUndergroundLeft;
                            }

                            break;
                          case 2:
                            Console.Clear();
                            if (!lists.CheckBool("alleyUndergroundLeftGuard"))
                            {
                              Console.WriteLine("You enter the second building.");
                              Thread.Sleep(2500);
                              Console.Write("The place looks fairly empty");
                              Thread.Sleep(2500);
                              Console.WriteLine(", except for a few boxes in the corner");
                              Thread.Sleep(3000);
                              if (lists.CheckBool("alleyUndergroundLeftBox"))
                              {
                                Console.WriteLine("Looks there is a hole in the wall behind it");
                                Thread.Sleep(3000);
                                Console.WriteLine(" leading next door.");
                                Thread.Sleep(2500);
                                Console.WriteLine("");
                                alleyUndergroundLeftBox:
                                Console.WriteLine("--What do you want to do?--");
                                Console.WriteLine("1. Go through the hole");
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
                                  goto alleyUndergroundLeftBox;
                                }

                                switch (lists.GetValue("Input"))
                                {
                                  case 1:
                                    Console.Clear();
                                    Console.WriteLine("You sneak through the hole in the wall.");
                                    Thread.Sleep(3500);
                                    Console.WriteLine("The other side looks like a barracks or armoury of sorts.");
                                    Thread.Sleep(4000);
                                    Console.WriteLine("There are weapons and gear everywhere.");
                                    Thread.Sleep(3000);
                                    Console.Write("As you plan to clean out the place");
                                    Thread.Sleep(2500);
                                    Console.WriteLine(" a few guards walk in.");
                                    Thread.Sleep(2500);
                                    Console.Write("Rushing back through the whole");
                                    Thread.Sleep(2500);
                                    Console.WriteLine(" you grab whatever is near on the way out");
                                    Thread.Sleep(3000);
                                    Console.WriteLine("You get out in time");
                                    Thread.Sleep(2500);
                                    Console.WriteLine(", with a GUARD UNIFORM");
                                    Thread.Sleep(4000);
                                    lists.AddItem("Guard Uniform", 0, true);
                                    lists.AddItem("alleyUndergroundLeftGuard", -1, true);
                                    Console.Clear();
                                    goto alleyUndergroundLeft;
                                  case 2:
                                    Console.Clear();
                                    goto alleyUndergroundLeft;
                                }
                              }
                            }

                            Console.WriteLine("There no reason to go back here.");
                            Thread.Sleep(3000);

                            Console.Clear();
                            goto alleyUndergroundLeft;
                          case 3:
                            Console.Clear();
                            Console.WriteLine("You walk towards the last building.");
                            Thread.Sleep(2500);
                            Console.WriteLine("The shady guys there puff up as you approach.");
                            Thread.Sleep(3000);
                            Console.WriteLine("It appears they are not keen on letting anyone by.");
                            Thread.Sleep(3500);
                            Console.WriteLine("You get a small glimpse inside og what looks like a hangout.");
                            Thread.Sleep(3500);
                            Console.WriteLine("Might need to look for a different way in if you want to get inside");
                            Thread.Sleep(4500);
                            lists.AddItem("alleyUndergroundLeftBox", -1, true);
                            Console.Clear();
                            goto alleyUndergroundLeft;
                          default:
                            Console.Clear();
                            Console.WriteLine("Invalid input");
                            Thread.Sleep(1500);
                            Console.Clear();
                            goto alleyUndergroundLeft;
                        }

                        break;
                      case 2:
                        Console.Clear();
                        Console.WriteLine("");
                        Thread.Sleep(2000);
                        break;
                      case 3:
                        Console.Clear();
                        Console.WriteLine("The courtyard is full of people.");
                        Thread.Sleep(3000);
                        Console.Write("People everywhere are either drinking");
                        Thread.Sleep(4000);
                        Console.Write(", doing drugs");
                        Thread.Sleep(1500);
                        Console.Write(", fornicating");
                        Thread.Sleep(1500);
                        Console.WriteLine(", or all of them.");
                        Thread.Sleep(2500);
                        Console.WriteLine("It is like nothing you have seen before.");
                        Thread.Sleep(3000);
                        Console.Write("A haven of sin and immorality");
                        Thread.Sleep(3000);
                        Console.Write(", no judgement");
                        Thread.Sleep(2000);
                        Console.WriteLine(", no laws.");
                        Thread.Sleep(2000);
                        Console.Clear();
                        goto alleyUndergroundStart;
                      case 4:
                        Console.Clear();
                        Console.WriteLine("");
                        Thread.Sleep(2000);
                        break;
                      case 5:
                        break;
                      default:
                        Console.Clear();
                        Console.WriteLine("Invalid input");
                        Thread.Sleep(1500);
                        Console.Clear();
                        goto alleyUndergroundStart;
                    }

                    break;
                  case 2:
                    Console.Clear();
                    Console.WriteLine("You decide to walk around the alley on your own.");
                    Thread.Sleep(3500);
                    Console.WriteLine("It is interesting to observe how people act around here.");
                    Thread.Sleep(4000);
                    Console.WriteLine("Nothing like the rest of town");
                    Thread.Sleep(3000);
                    Console.WriteLine(", like a seperate society");
                    Thread.Sleep(2500);
                    Console.WriteLine(", hidden away");
                    Thread.Sleep(3000);
                    Console.WriteLine("They all walk around with purpose.");
                    Thread.Sleep(3000);
                    Console.WriteLine("There must be something unique about this place.");
                    Thread.Sleep(4000);
                    goto alleyBackyard;
                  case 3:
                    Console.Clear();
                    Console.WriteLine("You browse the different shops and stalls.");
                    Thread.Sleep(3000);
                    Console.Write("There are many interesting items and trinkets");
                    Thread.Sleep(3000);
                    Console.WriteLine(", but no one seems interested in trading.");
                    Thread.Sleep(4000);
                    Console.WriteLine("Not sure why.");
                    Thread.Sleep(3000);
                    goto alleyBackyard;
                  case 4:
                    Console.Clear();
                    Console.Write("You walk around for a bit");
                    Thread.Sleep(2500);
                    Console.WriteLine(" trying to strike a conversation with people");
                    Thread.Sleep(3500);
                    Console.WriteLine("But none of them seem particularly interested in talking with me.");
                    Thread.Sleep(4000);
                    Console.WriteLine("Most of them give me a frown and a stare as I talk to them.");
                    Thread.Sleep(4000);
                    Console.WriteLine("The rest just outright ignore me and walk the other way.");
                    Thread.Sleep(4000);
                    Console.WriteLine("Not sure why");
                    Thread.Sleep(3000);
                    goto alleyBackyard;
                  case 5:
                    break;
                }
              }
              else
              {
                Console.Clear();
                Console.WriteLine("Your approach the man.");
                Thread.Sleep(2500);
                Console.WriteLine("He just stares ominously at you.");
                Thread.Sleep(3000);
                Console.Write("As you start to open your mouth");
                Thread.Sleep(3000);
                Console.WriteLine(" he smacks you across the face.");
                Thread.Sleep(3000);
                Console.WriteLine("-10 HP");
                Thread.Sleep(3000);
                lists.ModifyValue("HP", i => i - 10);
                lists.Hp();
                Console.WriteLine("Does not seem like much of a talker.");
                Thread.Sleep(4000);
              }

              break;
            case 2:
              break;
          }

          continue;
        default:
          Console.Clear();
          Console.Write("Invalid input");
          Thread.Sleep(1500);
          continue;
      }

      break;
    }
  }
}