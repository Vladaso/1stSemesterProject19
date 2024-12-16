using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Runtime.CompilerServices;
using WorldOfZuul;

namespace WorldOfZuul
{
    public class NPC
    {
        private string name;
        public int RoomNumber { get; private set; }
        public int MissionStatus = 0;
        public NPC(string name, int roomNumber)
        {
            this.name = name;
            RoomNumber = roomNumber;
        }


        //Could be made static doesn't matter too much
        public void StartDialogue(Game game)
        {
            if (game.player.Position == 3)
            {
                OctopusDialogue(game);
            }
            else if (game.player.Position == 2)
            {
                WhaleDialogue(game);
            }
            else if (game.player.Position == 5)
            {
                DolphinDialogue(game);
            }
            else if (game.player.Position == 1)
            {

                SeaLionDialogue(game);

            }
            else if (game.player.Position == 4)
            {
                TurtleDialogue(game);
            }
            else
            {
                throw new Exception("Something went wrong with the NPC dialogue.");
            }
        }

        // DONE THROUGH DIALOGUE FUNCTIONS BECAUSE MAKING DIALOGUE NODES IS A LITTLE OUT OF SCOPE FOR THE FIRST SEMESTER

        private void OctopusDialogue(Game game)
        {
            while (true)
            {
                Console.WriteLine("\nHello, I am the Octopus, the brain of Finlandia. What do you want to know?");
                Console.WriteLine("\n1. Tell me about Finlandia.");
                Console.WriteLine("2. Do you have any items?");
                Console.WriteLine("3. Do you know something about the Fintastic pearls?");
                Console.WriteLine("4. Goodbye.");
                int choice = GetPlayerChoice(4);

                if (choice == 1)
                {
                    Console.WriteLine("\nFinlandia is the last surviving city in this dystopian world. The oceans are mostly dead due to pollution.");
                    Console.WriteLine("\n1. Why did this happen?");
                    Console.WriteLine("2. Is there hope for the oceans?");
                    Console.WriteLine("3. Thank you for explaining.");
                    choice = GetPlayerChoice(3);

                    if (choice == 1)
                    {
                        Console.WriteLine("\nPollution became unstoppable, and now the ratio of plastic to plankton is about 40:1. The oceans can barely sustain life.");
                        Console.WriteLine("\n1. Thank you for sharing.");
                        GetPlayerChoice(1);
                    }
                    else if (choice == 2)
                    {
                        Console.WriteLine("\nThere might be hope. With enough effort, we can restore balance—but it will take centuries.");
                        Console.WriteLine("\n1. Thank you for your insight.");
                        GetPlayerChoice(1);
                    }
                    else
                    {
                        Console.WriteLine("\nGoodbye!");
                        break;
                    }
                }
                else if (choice == 2)
                {
                    Console.WriteLine("\nI don't carry items, but I do have knowledge that might aid you.");
                    Console.WriteLine("\n1. What kind of knowledge?");
                    Console.WriteLine("2. Thank you, that's all.");
                    choice = GetPlayerChoice(2);

                    if (choice == 1)
                    {
                        Console.WriteLine("\nMy knowledge is vast, but I sense your journey's success depends on your own perseverance.");
                        Console.WriteLine("Seek the pearls, for they hold the key to a brighter future.");
                        Console.WriteLine("\n1. Thank you for the advice.");
                        GetPlayerChoice(1);
                    }
                    else
                    {
                        Console.WriteLine("\nGoodbye!");
                        break;
                    }
                }
                else if (choice == 3)
                {
                    Console.WriteLine("\nAh, the Fintastic pearls. They are crucial for restoring the balance of this world.");
                    Console.WriteLine("\n1. Where can I find one?");
                    Console.WriteLine("2. Why are they important?");
                    Console.WriteLine("3. Thank you for your wisdom.");
                    choice = GetPlayerChoice(3);

                    if (choice == 1)
                    {
                        Console.WriteLine("\nThe purple Fintastic pearl is in the pyramid room powering the filtering system. Be careful when taking it out.");
                        if (this.MissionStatus == 0)
                        {
                            game.items.Add(new Item(name: "Purple Pearl", description: "Fintastic Pearl", x: 21, y: 6, roomNumber: 7, symbol: "🟣"));
                            this.MissionStatus = 1;
                        }
                        Console.WriteLine("\n1. Thank you for the information.");
                        GetPlayerChoice(1);
                        break;
                    }
                    else if (choice == 2)
                    {
                        Console.WriteLine("\nThe pearls are ancient artifacts. Together, they have the power to revitalize the oceans and bring life back to this planet.");
                        Console.WriteLine("\n1. Thank you for explaining.");
                        GetPlayerChoice(1);
                    }
                    else
                    {
                        Console.WriteLine("\nGoodbye!");
                        break;
                    }
                }
                else if (choice == 4)
                {
                    Console.WriteLine("\nGoodbye!");
                    break;
                }
                ConsoleUtils.ClearConsole();
                game.screen.Display();
            }
        }


        private void WhaleDialogue(Game game)
        {
            while (true)
            {
                Console.WriteLine("\nUgh, I'm the Whale... What do you want?");
                Console.WriteLine("\n1. Tell me about this place.");
                Console.WriteLine("2. Why are you annoyed?");
                Console.WriteLine("3. Goodbye.");
                int choice = GetPlayerChoice(3);

                if (choice == 1)
                {
                    Console.WriteLine("\nThis place? It's where I float around, tired and annoyed. What else do you want?");
                    Console.WriteLine("\n1. Why are you so tired?");
                    Console.WriteLine("2. Thank you, that's all.");
                    choice = GetPlayerChoice(2);

                    if (choice == 1)
                    {
                        Console.WriteLine("\nHave you ever tried filtering plankton all day? And it's not even just plankton anymore—it's mostly plastic now!");
                        Console.WriteLine("\n1. Thank you for telling me.");
                        GetPlayerChoice(1);
                    }
                    else
                    {
                        Console.WriteLine("\nGoodbye!");
                        break;
                    }
                }
                else if (choice == 2)
                {
                    Console.WriteLine("\nWhy am I annoyed? Do you even know what the ratio of plastic to plankton is in the water? It's driving me mad!");
                    Console.WriteLine("\n1. I think I know. Let me tell you.");
                    Console.WriteLine("2. Thank you, never mind.");
                    choice = GetPlayerChoice(2);

                    if (choice == 1)
                    {
                        Console.WriteLine("\nAlright, genius. What's the ratio of plastic to plankton? (Enter your answer in the format 'X:Y')");
                        string? ratioAnswer = Console.ReadLine();

                        if (ratioAnswer == "40:1")
                        {
                            if (this.MissionStatus == 0)
                            {
                                Console.WriteLine("\nHmph. You're right... It is 40:1. Terrible, isn't it?");
                                Console.WriteLine("\nWell, since you actually know something, I'll tell you a secret: The orange Fintastic pearl has a special power.");
                                Console.WriteLine("\nAnd here it is btw, it's all yours.");
                                game.items.Add(new Item(name: "Orange Pearl", description: "Fintastic Pearl", x: 15, y: 15, roomNumber: this.RoomNumber, symbol: "🟠"));
                                Console.WriteLine("Now go away, I'm tired.");
                                this.MissionStatus = 1;
                            }
                            else
                            {
                                Console.WriteLine("\nYou already told me this schmuck. Go away.");
                                Console.WriteLine("\n1. Oh yeah, I remember that.");
                                GetPlayerChoice(1);
                                break;
                            }
                            Console.WriteLine("\n1. Thank you.");
                            GetPlayerChoice(1);
                            break;
                        }
                        else
                        {
                            Console.WriteLine("\nMy intuition tells me that is incorrect.");
                            Console.WriteLine("\n1. I'll try again.");
                            GetPlayerChoice(1);
                        }
                    }
                    else
                    {
                        Console.WriteLine("\nFine. Goodbye!");
                        break;
                    }
                }
                else if (choice == 3)
                {
                    Console.WriteLine("\nGoodbye. Finally, some peace and quiet...");
                    break;
                }
                ConsoleUtils.ClearConsole();
                game.screen.Display();
            }
        }
        private void SeaLionDialogue(Game game)
{
    // Assuming the elder sea lion is at index 1 and baby sea lion at index 0
    NPC babySeaLion = game.npcs[0];
    NPC elderSeaLion = game.npcs[1];

    while (true)
    {
        Console.WriteLine("\nHello, I am the elder sea lion. How may I help you?");
        Console.WriteLine("1. Do you know anything about the orange Fintastic pearl?");
        Console.WriteLine("2. Eh, I don't feel like talking to you right now.");
        int choice = GetPlayerChoice(2);

        if (choice == 1)
        {
            if (babySeaLion.MissionStatus == 0) // Baby sea lion mission not started
            {
                Console.WriteLine("\nMy baby is stuck in some nets! Please help rescue them.");
                Console.WriteLine("1. I will help.");
                Console.WriteLine("2. Sorry, I can't help right now.");
                choice = GetPlayerChoice(2);

                if (choice == 1)
                {
                    Console.WriteLine("\nThank you! You can find my baby nearby. Please rescue them!");
                    babySeaLion.SeaLionBabyDialogue(game); // Trigger the baby sea lion dialogue
                }
                else
                {
                    Console.WriteLine("\nI understand. Please come back if you change your mind.");
                }
            }
            else if (babySeaLion.MissionStatus == 1) // Baby sea lion mission complete
            {
                Console.WriteLine("\nThank you for saving my baby! As a reward, here is the orange Fintastic pearl.");
                game.items.Add(new Item("Orange Pearl", "Fintastic Pearl", 15, 15, this.RoomNumber, "🟠"));
                this.MissionStatus = 1; // Mark elder sea lion's mission as complete
                Console.WriteLine("Mission complete!");
                break;
            }
        }
        else if (choice == 2)
        {
            Console.WriteLine("\nGoodbye then!");
            break;
        }
    }
}


    

    private void SeaLionBabyDialogue(Game game)
{
    while (true)
    {
        Console.WriteLine("\nHey there, stranger, please help me. I am stuck in these nets!");
        Console.WriteLine("1. How did that happen?");
        Console.WriteLine("2. Meh, I'm too old for this.");
        int choice = GetPlayerChoice(2);

        if (choice == 1)
        {
            Console.WriteLine("\nWell, I saw this beautifully shaped pebble and tried to come closer to see it. The nets, they got me!!!");
            Console.WriteLine("1. I'll help you.");
            Console.WriteLine("2. This is a waste of time, I'll try to figure this out on my own.");
            choice = GetPlayerChoice(2);

            if (choice == 1)
            {
                if (game.inventory.HasItem("Scissors"))
                {
                    Console.WriteLine("\nYou use the scissors to cut the nets and free the baby sea lion!");
                    Console.WriteLine("The baby sea lion swims away happily.");
                    this.MissionStatus = 1; 
                    Console.WriteLine("You should return to the elder sea lion.");
                    break;
                }
                else
                {
                    Console.WriteLine("\nYou don't have the scissors needed to free the baby sea lion.");
                    break;
                }
            }
            else
            {
                Console.WriteLine("\nI've lost all hope. Goodbye!");
                break;
            }
        }
        else if (choice == 2)
        {
            Console.WriteLine("\nGoodbye then!");
            break;
        }
    }
}

        private void TurtleDialogue(Game game)
        {
            while (true)
            {
                if (this.MissionStatus == 0)
                {
                    Console.WriteLine("          O  o ");
                    Console.WriteLine("            o ");
                    Console.WriteLine("Bloop bloop .  Oh! Hi there, friend! I’m Tauri the Turtle, and we’ve got a big problem in my turlte-family. Can you help us?.");
                    Console.WriteLine("\n1. Tell me more—what’s happening?");
                    Console.WriteLine("2. I believe I have what you are looking for!");
                    Console.WriteLine("3. Sorry, Tauri, I can’t right now.");
                    int choice = GetPlayerChoice(3);

                    if (choice == 1)
                    {
                        Console.WriteLine("\nOh no, oh no, oh no! It’s a disaster, my kids thought those floating microplastics were jellyfish and gobbled them up!");
                        Console.WriteLine("Now they’re not feeling well, and I need help to save them.");
                        Console.WriteLine("\n1. That's horrifying! How can I help?");
                        Console.WriteLine("2. Oh! I see! I'll come back later.");
                        int choice_1 = GetPlayerChoice(2);

                        if (choice_1 == 1)
                        {
                            Console.WriteLine("\nMy kids need Bubble Berries to cleanse their tummies! They’re tiny, purple glowing berries that float near the reefs.");
                            Console.WriteLine("Hurry up! My kids are in danger!");
                            game.items.Add(new Item(name: "Bubble Berries", description: "Healing Bubble", x: 22, y: 4, roomNumber: 5, symbol: "🫧"));
                            Console.WriteLine("\n1. I'll be be back soon with the Bubble Berries!");
                            int choice_11 = GetPlayerChoice(1);
                            break;
                        }
                        else if (choice_1 == 2)
                        {
                            Console.WriteLine("\nOh... alright. I guess I’ll try to keep them calm while you’re away.");
                            Console.WriteLine("Please don’t forget about us! We are counting on you...");
                            Console.WriteLine("\n1. I’ll do my best!.");
                            Console.WriteLine("2. Can’t promise, I am busy today.");
                            int choice_2 = GetPlayerChoice(2);
                            break;
                        }
                    }
                    else if (choice == 2)
                    {
                        if (!game.inventory.items.Any(item => item.Name == "Bubble Berries"))
                        {
                            Console.WriteLine("\nWait a second... you don’t have any Bubble Berries yet! They’re small, glowing, and float near the reefs. Keep searching—you’re so close, I can feel it!");
                            Console.WriteLine("\n1. I'll search better!");
                            int choice_2 = GetPlayerChoice(1);
                            break;

                        }
                        else
                        {
                            game.inventory.items.RemoveAll(item => item.Name == "Bubble Berries");
                            Console.WriteLine("\nYou found them! Bubble-tastic work! These berries saved our family. I can’t thank you enough—you’ve saved the day!");
                            Console.WriteLine("Here, take this Green Pearl as a token of my gratitude. You’ve got the heart of a true ocean hero!");
                            game.items.Add(new Item("Green Pearl", "Fintastic Pearl", 30, 17, this.RoomNumber, "🟢"));
                            this.MissionStatus = 1;
                            Console.WriteLine("\nMission complete!");
                            Console.WriteLine("1. I am happy to help!");

                            int choice_2 = GetPlayerChoice(1);
                            break;

                        }
                    }
                    else if (choice == 3)
                    {
                        Console.WriteLine("\nOh… I see. Well, I understand. But please don’t forget about us. My little ones really need help!");
                        Console.WriteLine("Please come back soon. Their health depends on you.");
                        Console.WriteLine("\n1. I’ll do my best!.");
                        Console.WriteLine("2. Can’t promise, I am busy today.");

                        int choice_3 = GetPlayerChoice(2);

                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Hi again! My kids are feeling better thanks to those Bubble Berries you found for us!");
                    Console.WriteLine("But there are more problems going on in Finlandia");
                    Console.WriteLine("\nKeep on searching for more challenges!");
                    Console.WriteLine("1. Goodbye");
                    int choice_c = GetPlayerChoice(1);
                    break;

                }

                ConsoleUtils.ClearConsole();
                game.screen.Display();
            }
        }
        
private void DolphinDialogue(Game game)
{
    while (true)
    {
        Console.WriteLine("\n*crying* oh hey... I'm the dolphin... *sob*");
        Console.WriteLine("\n1. What happened? Why are you crying?");
        Console.WriteLine("2. oh... Sorry, bye");
        int choice = GetPlayerChoice(2);

        if (choice == 1)
        {
            Console.WriteLine("\nWell... *sob* You see, the coral reef is dying. And even though I'm a big mammal,");
            Console.WriteLine("I'm really concerned about all my friends that rely on the reef to live. *sob*");
            Console.WriteLine("\n1. What can I do to help?");
            Console.WriteLine("2. Can You explain to me why the reefs are so important?");
            Console.WriteLine("3. Sorry. I need to go.");
            choice = GetPlayerChoice(3);

            if (choice == 1)
            {
                if (this.MissionStatus == 0)
                {
                    Console.WriteLine("\nMy friend Tauri the Turtle mentioned that he needs something from the reef,");
                    Console.WriteLine("but I don't remember what it was, please find him and talk with him!");
                    Console.WriteLine("\n1. OK! I'll go talk to him right now!");
                    Console.WriteLine("2. Why does he need something from the reef?");
                    Console.WriteLine("3. I don't have the time now. Bye.");
                    choice = GetPlayerChoice(3);

                    if (choice == 1)
                    {
                        Console.WriteLine("\nOh thank you so much! Here, I have a gift for You!");
                        game.items.Add(new Item(name:"Blue Pearl", description:"Fintastic Pearl", x: 76, y: 18, roomNumber: this.RoomNumber, symbol: "🔵"));
                        this.MissionStatus = 1;
                        Console.WriteLine("\n1. Thank you! Bye!");
                        GetPlayerChoice(1);
                        break;
                    }


                    else if (choice == 2)
                    {
                        // source = https://www.uq.edu.au/news/article/2015/09/world%E2%80%99s-turtles-face-plastic-deluge-danger
                        Console.WriteLine("\nHis kids ate plastic because they mistook it for a jellyfish!");
                        Console.WriteLine("It's, a problem that's spreading, approximately 52% of turtles worldwide, have eaten plastic!");
                        Console.WriteLine("\n1. Oh no!");
                        GetPlayerChoice(1);
                    }

                    else if (choice == 3)
                    {
                        Console.WriteLine("\nOh... Ok, bye!");
                        break;
                    }

                }
                else
                {
                    Console.WriteLine("\nMy friend Tauri the Turtle mentioned that he needs something from the reef,");
                    Console.WriteLine("but I don't remember what it was, please find him and talk with him!");
                    Console.WriteLine("\n1. Why does he need something from the reef?");
                    Console.WriteLine("2. Goodbye.");
                    choice = GetPlayerChoice(2);

                    if (choice == 1)
                    {
                        Console.WriteLine("\nHis kids ate plastic because they mistook it for a jellyfish!");
                        Console.WriteLine("It's, a problem that's spreading, approximately 52% of turtles worldwide, have eaten plastic!");
                        Console.WriteLine("\n1. Oh no!");
                        GetPlayerChoice(1);
                    }

                    else if (choice == 2)
                    {
                        Console.WriteLine("\nOh... Ok, bye!");
                        break;
                    }

                }

                
            }

            else if (choice == 2)
            {
                // source = https://www.epa.gov/coral-reefs/basic-information-about-coral-reefs
                Console.WriteLine("\nWell, around 25% of all aquatic life is dependant on them at some point in their life!");
                Console.WriteLine("\nThey provide habitat, spawning and nursery grounds for over 1 million species!");
                Console.WriteLine("1. Wow thank You for this information!");
                GetPlayerChoice(1);
            }

            else if (choice == 3)
            {
                Console.WriteLine("\nOh... Goodbye...");
                break;
            }
        }
        else
        {
            Console.WriteLine("\n Noo, please stay, we all could use Your help!");
            break;
        }

        ConsoleUtils.ClearConsole();
        game.screen.Display();
    }
}



private int GetPlayerChoice(int maxChoices)
{
    //Doesnt accept anything other than an integer in the range
    int choice;
    do
    {
        Console.Write("Choose an option: ");
        string? input = Console.ReadLine();
        int.TryParse(input, out choice);
    } while (choice < 1 || choice > maxChoices);
    return choice;
        }
    }
}

