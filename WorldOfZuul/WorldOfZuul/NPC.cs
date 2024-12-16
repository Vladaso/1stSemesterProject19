using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;

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

        public int crabVisited = 0;
        public int scorpionVisited = 0;


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
            else if (game.player.Position == 8)
            {
                CrabDialogue(game);
            }
            else if (game.player.Position == 7)
            {
                ScorpionDialogue(game);
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
                                Console.WriteLine("Hmph. You're right... It is 40:1. Terrible, isn't it?");
                                Console.WriteLine("Well, since you actually know something, I'll tell you a secret: The orange Fintastic pearl has a special power.");
                                Console.WriteLine("And here it is btw, it's all yours.");
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
                            Console.WriteLine("\nHmph. You're right... It is 40:1. Terrible, isn't it?");
                            Console.WriteLine("Well, since you actually know something, I'll tell you a secret: The orange Fintastic pearl has a special power.");
                            Console.WriteLine("\n1. Thank you for the secret.");
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

        private void CrabDialogue(Game game)
        {
            while (true)
            {
                if (MissionStatus == 0)
                {
                    if (scorpionVisited == 0)
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
                                crabVisited = 1;
                                // MISION STATUS + + ????
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
                            crabVisited = 1;
                            GetPlayerChoice(1);
                            break;
                        }
                        else
                        {
                            Console.WriteLine("\nYou're leaving me like this? Really? Just remember, the ocean's fate affects everyone, even you. Goodbye...");
                            break;
                        }
                    }


                    else if (scorpionVisited == 1)
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
                        MissionStatus = 1;
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
                        Console.WriteLine("1. Hi. No, Iam just passing by.");
                        GetPlayerChoice(1);
                        break;
                    }
                    ConsoleUtils.ClearConsole();
                    game.screen.Display();

                }


            }
        }

        private void CrabRescueDialogue(Game game)
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

            Console.WriteLine("\nYou've received the **Red Pearl**! Its power reveals hidden map in your journey.");

            Console.WriteLine("\nPlease, remember to protect our ocean. If more people cared like you, maybe we wouldn't be drowning in human waste.");
            Console.WriteLine("\n1. I'll do my best.");
            Console.WriteLine("2. Goodbye, and take care.");
            choice = GetPlayerChoice(2);

            if (choice == 1)
            {
                Console.WriteLine("\nThank you! Every little effort makes a difference. Safe travels, my friend!");
            }
            else if (choice == 2)
            {
                Console.WriteLine("\nGoodbye! And thank you again for giving me a second chance.");
            }

            ConsoleUtils.ClearConsole();
            game.screen.Display();
        }


        private void ScorpionDialogue(Game game)
        {
            while (true)
            {
                if (this.MissionStatus == 0)
                {
                    if (crabVisited == 1)
                    {
                        Console.WriteLine("\nAh, a visitor! What brings you to me again?");
                        Console.WriteLine("\n1. A crab is trapped in a plastic bag. Can you help?");
                        Console.WriteLine("2. Just passing by, never mind.");
                        int choice = GetPlayerChoice(2);

                        if (choice == 1)
                        {
                            Console.WriteLine("\nA crab in trouble? Of course, I can help! Show me where it is.");
                            Console.WriteLine("\nThe Scorpion scuttles away to free the Crab...");
                            this.MissionStatus = 1;
                            scorpionVisited = 1;

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
                        Console.WriteLine("Hi, do you need something?");
                        Console.WriteLine("1. Hi. No, Iam jsut passing by.");
                        GetPlayerChoice(1);
                        break;
                    }
                    ConsoleUtils.ClearConsole();
                    game.screen.Display();
                }
                else
                {
                    Console.WriteLine("Hi again! Do you need something?");
                    Console.WriteLine("1. Hi! Iam just passing by.");
                    GetPlayerChoice(1);
                    break;
                }
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
