
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
            else if(game.player.Position == 0){
                FrogDialogue(game);
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
            else if (game.player.Position == 8)
            {
                CrabDialogue(game);
            }
            else if (game.player.Position == 7)
            {
                ScorpionDialogue(game);
            }
            else if (game.player.Position == 6)
            {
                SeaHorseDialogue(game);
            }
            else if(game.player.Position == 10){
                PrincessDialogue(game);
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
            while (true)
            {
                Console.WriteLine("\nHello, I am the elder sea lion. How may I help you?");
                Console.WriteLine("1. Do you know anything about the Fintastic pearls?");
                Console.WriteLine("2. Eh, I don't feel like talking to you right now.");
                int choice = GetPlayerChoice(2);

                if (choice == 1)
                {
                    if (this.MissionStatus == 0) // Mission not started
                    {
                            Console.WriteLine("\nWhy of course I do, I own the Yellow Fintastic pearl.");
                            Console.WriteLine("\nI will give it to you I just need a small favor from you.");
                        Console.WriteLine("\nMy friend, the sea horse, is stuck in some nets! Please help rescue them.");
                        Console.WriteLine("1. I will help.");
                        Console.WriteLine("2. Sorry, I can't help right now.");
                        choice = GetPlayerChoice(2);

                        if (choice == 1)
                        {
                            Console.WriteLine("\nThank you! You can find my friend nearby. Please rescue them!");
                            Console.WriteLine("1. OK");
                            GetPlayerChoice(1);
                            this.MissionStatus = 1; // Mark mission as started
                            break;
                        }
                        else
                        {
                            Console.WriteLine("\nI understand. Please come back if you change your mind.");
                        }
                    }
                    else if(this.MissionStatus==1){
                        Console.WriteLine("\nHave you saved my friend yet?");
                        Console.WriteLine("1. Not yet.");
                        GetPlayerChoice(1);
                    }
                    else if (this.MissionStatus == 2) // Mission complete
                    {
                        Console.WriteLine("\nThank you for saving my friend! As a reward, here is the yellow Fintastic pearl.");
                        game.items.Add(new Item("Yellow Pearl", "Fintastic Pearl", 15, 15, this.RoomNumber, "🟡"));
                        this.MissionStatus = 3;
                        Console.WriteLine("\n1. Thank you!");
                        GetPlayerChoice(1);
                        break;
                    }
                }
                else if (choice == 2)
                {
                    Console.WriteLine("\nGoodbye then!");
                    break;
                }
                ConsoleUtils.ClearConsole();
                game.screen.Display();
            }
        }

        private void SeaHorseDialogue(Game game)
        {
            var seaLion = game.npcs.First(npc => npc.name == "Sealion");
            if(seaLion.MissionStatus == 0){
                Console.WriteLine("\n*You see a SeaHorse struggling in a net, but you have more urgent business right now.*");
                Console.WriteLine("1 I'll come back later.");
                int choice = GetPlayerChoice(1);
                ConsoleUtils.ClearConsole();
                game.screen.Display();
            }
            else if(seaLion.MissionStatus >=2){
                Console.WriteLine("\nThanks for the help again!");
                Console.WriteLine("1 No problem!");
                int choice = GetPlayerChoice(1);
                ConsoleUtils.ClearConsole();
                game.screen.Display();
            }
            else{
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
                            Console.WriteLine("\nYou use the scissors to cut the nets and free the sea horse!");
                            Console.WriteLine("The sea horse swims away happily.");
                            game.npcs.First(npc => npc.name == "Sealion").MissionStatus = 2;
                            Console.WriteLine("You should return to the elder sea lion.");
                            Console.WriteLine("1. OK");
                            GetPlayerChoice(1);
                            break;
                        }
                        else
                        {
                            Console.WriteLine("\nYou don't have the scissors needed to free the sea horse.");
                            Console.WriteLine("1. Oh");
                            GetPlayerChoice(1);
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
                ConsoleUtils.ClearConsole();
                game.screen.Display();
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
                        else if(this.MissionStatus == 1){
                            Console.WriteLine("\nYou found them! Bubble-tastic work! These berries saved our family. I can’t thank you enough—you’ve saved the day!");
                            Console.WriteLine("1. I am happy to help!");
                            GetPlayerChoice(1);
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
        if (this.MissionStatus == 0)
        {
            Console.WriteLine("\n*crying* oh hey... I'm the dolphin... *sob*");
            Console.WriteLine("\n1. What happened? Why are you crying?");
            Console.WriteLine("2. oh... Sorry, bye");
            int choice = GetPlayerChoice(2);

            if (choice == 1)
            {
                Console.WriteLine("\n*sob* The coral reef is dying... I need help from Tauri the Turtle... *sob*");
                Console.WriteLine("\n1. I'll go talk to Tauri the Turtle.");
                Console.WriteLine("2. Sorry, I can't help right now.");
                choice = GetPlayerChoice(2);

                if (choice == 1)
                {
                    Console.WriteLine("\nThank you... *sob* Please hurry!");
                    this.MissionStatus = 1;
                    Console.WriteLine("\n1. You're welcome! Bye!");
                    GetPlayerChoice(1);
                    break;
                }
                else if (choice == 2)
                {
                    Console.WriteLine("\nOh... Ok, bye!");
                    break;
                }
            }
            else
            {
                Console.WriteLine("\n Noo, please stay, we all could use Your help!");
                break;
            }
        }
        else if (this.MissionStatus == 1 && game.inventory.HasItem("Green Pearl"))
        {
            Console.WriteLine("\nYou have the Green Pearl! Thank you so much! I can use it to cure the coral reef.");
            Console.WriteLine("\nThe dolphin uses the Green Pearl to cure the coral reef. The reef is now healthy again.");
            this.MissionStatus = 2;
            Console.WriteLine("\nThank you so much can I help you with something?");
            Console.WriteLine("\n1. Can you use your sonar to call for help?");
            Console.WriteLine("2. Goodbye.");
            int choice = GetPlayerChoice(2);

            if (choice == 1)
            {
                Console.WriteLine("\nWho should I call?");
                Console.WriteLine("\n1. Call humans for help.");
                Console.WriteLine("2. Call the mantis shrimp for help.");
                choice = GetPlayerChoice(2);

                if (choice == 1)
                {
                    Console.WriteLine("\nYou call for humans. You wait for a bit.");
                    Console.WriteLine("\n.");
                    Console.WriteLine("\n..");
                    Console.WriteLine("\n...");
                    Console.WriteLine("\nThere is no response.");
                    for (int i = 0; i < 10; i++)
                    {
                        game.pollutionMeter.IncreasePollution();
                    }
                    Console.WriteLine("\n1. Try calling someone else.");
                    GetPlayerChoice(1);
                }
                else if (choice == 2)
                {
                    Console.WriteLine("\nYou call the mantis shrimp using the dolphin's sonar. The mantis shrimp brings you the blue pearl.");
                    game.items.Add(new Item(name: "Blue Pearl", description: "Fintastic Pearl", x: 76, y: 18, roomNumber: this.RoomNumber, symbol: "🔵"));
                    this.MissionStatus = 3;
                    Console.WriteLine("\n1. Thank you!");
                    GetPlayerChoice(1);
                    break;
                }
            }
            else if (choice == 2)
            {
                Console.WriteLine("\nGoodbye!");
                break;
            }
        }
        else if (this.MissionStatus == 2 || this.MissionStatus == 3)
        {
            Console.WriteLine("\nHey, it's you again! Thank you for helping me earlier.");
            Console.WriteLine("\n1. Can you use your sonar to call for help?");
            Console.WriteLine("2. Goodbye.");
            int choice = GetPlayerChoice(2);

            if (choice == 1)
            {
                Console.WriteLine("\nWho should I call?");
                Console.WriteLine("\n1. Call humans for help.");
                Console.WriteLine("2. Call the mantis shrimp for help.");
                choice = GetPlayerChoice(2);

                if (choice == 1)
                {
                    Console.WriteLine("\nYou call for humans. You wait for a bit.");
                    Console.WriteLine("\n.");
                    Console.WriteLine("\n..");
                    Console.WriteLine("\n...");
                    Console.WriteLine("\nThere is no response.");
                    for (int i = 0; i < 10; i++)
                    {
                        game.pollutionMeter.IncreasePollution();
                    }
                    Console.WriteLine("\n1. Try calling someone else.");
                    GetPlayerChoice(1);
                }
                else if (choice == 2)
                {
                    Console.WriteLine("\nYou call the mantis shrimp using the dolphin's sonar. The mantis shrimp brings you the blue pearl.");
                    if (this.MissionStatus == 2)
                    {
                        game.items.Add(new Item(name: "Blue Pearl", description: "Fintastic Pearl", x: 76, y: 18, roomNumber: this.RoomNumber, symbol: "🔵"));
                        this.MissionStatus = 3;
                    }
                    else
                    {
                        Console.WriteLine("\nYou already have the blue pearl.");
                    }
                    Console.WriteLine("\n1. Thank you!");
                    GetPlayerChoice(1);
                    break;
                }
            }
            else if (choice == 2)
            {
                Console.WriteLine("\nGoodbye!");
                break;
            }
        }

        ConsoleUtils.ClearConsole();
        game.screen.Display();
    }
}
private void CrabDialogue(Game game)
{
    while (true)
    {
        if (MissionStatus == 0)
        {
            Console.WriteLine("\nHi, it's me, Crab. I need help, and it's urgent!");
            Console.WriteLine("\n1. What happened?");
            Console.WriteLine("2. How can I help?");
            Console.WriteLine("3. Goodbye.");
            int choice = GetPlayerChoice(3);

            if (choice == 1)
            {
                Console.WriteLine("\nIt's this horrible plastic bag! Humans left it floating around, and now I'm stuck in it.");
                Console.WriteLine("I can't move, and it's suffocating me. This ocean used to be our home, not a trash bin!");
                Console.WriteLine("\n1. That's terrible! How can I help?");
                Console.WriteLine("2. Oh no, good luck with that.");
                choice = GetPlayerChoice(2);

                if (choice == 1)
                {
                    Console.WriteLine("\nThank you! There's a Scorpion nearby. Its claws are strong enough to cut me free.");
                    Console.WriteLine("Please find it and bring it here before it's too late!");
                    Console.WriteLine("1. Okay, I will try to find him!");
                    MissionStatus = 1;
                    GetPlayerChoice(1);
                    break;
                }
                else
                {
                    Console.WriteLine("\nFine! I guess I'll just sit here and watch my home turn into a dump. Thanks for nothing!");
                    break;
                }
            }
            else if (choice == 2)
            {
                Console.WriteLine("\nYou can help by finding the Scorpion! Its claws are sharp enough to cut me free. Please hurry!");
                Console.WriteLine("1. Okay, I will try to find him!");
                MissionStatus = 1;
                GetPlayerChoice(1);
                break;
            }
            else
            {
                Console.WriteLine("\nYou're leaving me like this? Really? Just remember, the ocean's fate affects everyone, even you. Goodbye...");
                break;
            }
        }
        else if (MissionStatus == 2)
        {
            Console.WriteLine("\nOh, thank you, thank you! I can finally move and breathe again!");
            Console.WriteLine("\n1. I'm glad you're okay. It must have been terrifying.");
            Console.WriteLine("2. No problem, just trying to help.");
            int choice = GetPlayerChoice(2);

            if (choice == 1)
            {
                Console.WriteLine("\nIt was terrifying! Imagine being trapped, unable to move, while your home is slowly turned into a landfill.");
                Console.WriteLine("But you saved me, and for that, I owe you everything!");
            }
            else if (choice == 2)
            {
                Console.WriteLine("\nWell, your help means more than you can imagine. Not many would care about a little crab like me.");
            }

            Console.WriteLine("\nI don't have much, but I found this Red Pearl while digging in the sand. It has a special power—take it as my thanks.");
            game.items.Add(new Item(name: "Red Pearl", description: "Fintastic Pearl", x: 15, y: 15, roomNumber: this.RoomNumber, symbol: "🔴"));
            MissionStatus = 3;
            Console.WriteLine("\nYou've received the **Red Pearl**! Its power reveals hidden map in your journey.");

            Console.WriteLine("\nPlease, remember to protect our ocean. If more people cared like you, maybe we wouldn't be drowning in human waste.");
            Console.WriteLine("\n1. I'll do my best.");
            Console.WriteLine("2. Goodbye, and take care.");
            choice = GetPlayerChoice(2);

            if (choice == 1)
            {
                Console.WriteLine("\nThank you! Every little effort makes a difference. Safe travels, my friend!");
                break;
            }
            else if (choice == 2)
            {
                Console.WriteLine("\nGoodbye! And thank you again for giving me a second chance.");
                break;
            }
        }
        else
        {
            Console.WriteLine("Hi again. Do you need anything?");
            Console.WriteLine("1. Hi. No, I am just passing by.");
            GetPlayerChoice(1);
            break;
        }
        ConsoleUtils.ClearConsole();
        game.screen.Display();
    }
}

private void ScorpionDialogue(Game game)
{
    while (true)
    {
        if (MissionStatus == 0 && game.npcs.First(npc => npc.name == "Crab").MissionStatus == 1)
        {
            Console.WriteLine("\nAh, a visitor! What brings you to me?");
            Console.WriteLine("\n1. A crab is trapped in a plastic bag. Can you help?");
            Console.WriteLine("2. Just passing by, never mind.");
            int choice = GetPlayerChoice(2);

            if (choice == 1)
            {
                Console.WriteLine("\nA crab in trouble? Of course, I can help! Show me where it is.");
                Console.WriteLine("\nThe Scorpion scuttles away to free the Crab...");
                MissionStatus = 1; 
                game.npcs.First(npc => npc.name == "Crab").MissionStatus = 2;
                Console.WriteLine("1. Nice!");
                GetPlayerChoice(1);
                break;
            }
            else if (choice == 2)
            {
                Console.WriteLine("\nHmm, okay then. But if you need me, you know where to find me.");
                break;
            }
        }
        else
        {
            Console.WriteLine("Hi again! Do you need something?");
            Console.WriteLine("1. Hi! I am just passing by.");
            GetPlayerChoice(1);
            break;
        }
        ConsoleUtils.ClearConsole();
        game.screen.Display();
    }
}
private void FrogDialogue(Game game)
{
    while (true)
    {
        Console.WriteLine("\nRibbit! I'm the Frog, guarding the tower with the princess. I'm really hungry. Can you get me a hamburger?");
        Console.WriteLine("\n1. Sure, I'll get you a hamburger.");
        Console.WriteLine("2. Sorry, I can't help right now.");
        int choice = GetPlayerChoice(2);

        if (choice == 1)
        {
            if (game.inventory.HasItem("Hamburger"))
            {
                Console.WriteLine("\nThank you so much! This hamburger is delicious!");
                game.inventory.items.RemoveAll(item => item.Name == "Hamburger");
                MissionStatus = 1;

                Console.WriteLine("\nFine you can see the princess now.");
                game.edges.Add(new Edge(0, 10, "west"));

                Console.WriteLine("\n1. You're welcome!");
                GetPlayerChoice(1);
                break;
            }
            else
            {
                Console.WriteLine("\nYou don't have a hamburger. Please come back when you have one.");
                Console.WriteLine("\n1. Okay, I'll be back.");
                GetPlayerChoice(1);
                break;
            }
        }
        else if (choice == 2)
        {
            Console.WriteLine("\nOh, that's too bad. I'm really hungry. Please come back if you change your mind.");
            break;
        }
        ConsoleUtils.ClearConsole();
        game.screen.Display();
    }
}
private void PrincessDialogue(Game game)
{
    while (true)
    {
        Console.WriteLine("\nOh my! How did you get here? I'm the Princess of Finlandia.");
        Console.WriteLine("\n1. I found my way here. Can you tell me about the troubles of fish living in Finlandia?");
        Console.WriteLine("2. Can you fix the filtration system?");
        Console.WriteLine("3. Goodbye.");
        int choice = GetPlayerChoice(3);

        if (choice == 1)
        {
            Console.WriteLine("\nThe fish in Finlandia are struggling to survive. The pollution has made it difficult for them to find clean water and food.");
            Console.WriteLine("Many species are on the brink of extinction. We need to restore the balance to save them.");
            Console.WriteLine("\n1. That's terrible. Can you fix the filtration system?");
            Console.WriteLine("2. Goodbye.");
            choice = GetPlayerChoice(2);

            if (choice == 1)
            {
                choice = 2; // Redirect to the second option
            }
            else
            {
                Console.WriteLine("\nGoodbye!");
                break;
            }
        }

        if (choice == 2)
        {
            Console.WriteLine("\nYes, I can fix the filtration system, but my wand is missing power.");
            Console.WriteLine("I need the 6 Fintastic Pearls to restore its power: Green, Red, Blue, Purple, Orange, and Yellow.");
            Console.WriteLine("\n1. I have all the pearls you need.");
            Console.WriteLine("2. I don't have all the pearls yet.");
            choice = GetPlayerChoice(2);

            if (choice == 1)
            {
                if (game.inventory.HasItem("Green Pearl") &&
                    game.inventory.HasItem("Red Pearl") &&
                    game.inventory.HasItem("Blue Pearl") &&
                    game.inventory.HasItem("Purple Pearl") &&
                    game.inventory.HasItem("Orange Pearl") &&
                    game.inventory.HasItem("Yellow Pearl"))
                {
                    Console.WriteLine("\nThank you so much! With these pearls, I can restore the power to my wand and fix the filtration system.");
                    // Remove the pearls from the inventory
                    game.inventory.items.RemoveAll(item => item.Name == "Green Pearl");
                    game.inventory.items.RemoveAll(item => item.Name == "Red Pearl");
                    game.inventory.items.RemoveAll(item => item.Name == "Blue Pearl");
                    game.inventory.items.RemoveAll(item => item.Name == "Purple Pearl");
                    game.inventory.items.RemoveAll(item => item.Name == "Orange Pearl");
                    game.inventory.items.RemoveAll(item => item.Name == "Yellow Pearl");

                    Console.WriteLine("\n*The Princess uses the pearls to restore the power to her wand and fixes the filtration system.*");
                    Console.WriteLine("\nFinlandia is saved! Thank you for your help!");
                    Console.WriteLine("\n1. You're welcome!");
                    GetPlayerChoice(1);
                    break;
                }
                else
                {
                    Console.WriteLine("\nYou don't have all the pearls yet. Please come back when you have all six.");
                    Console.WriteLine("\n1. Okay, I'll be back.");
                    GetPlayerChoice(1);
                    break;
                }
            }
            else if (choice == 2)
            {
                Console.WriteLine("\nPlease come back when you have all six pearls. The future of Finlandia depends on it.");
                Console.WriteLine("\n1. Okay, I'll be back.");
                GetPlayerChoice(1);
                break;
            }
        }
        else if (choice == 3)
        {
            Console.WriteLine("\nGoodbye!");
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

