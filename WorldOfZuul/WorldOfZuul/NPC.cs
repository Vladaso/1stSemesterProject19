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
            else if (game.player.Position == 6)
            {

                SeaLionDialogue(game);
            }
            
            else{
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
            if(this.MissionStatus==0){
                game.items.Add(new Item(name:"Purple Pearl", description:"Fintastic Pearl", x: 21, y: 6, roomNumber: 7, symbol: "🟣"));
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
                    if(this.MissionStatus==0){
                    Console.WriteLine("Hmph. You're right... It is 40:1. Terrible, isn't it?");
                    Console.WriteLine("Well, since you actually know something, I'll tell you a secret: The orange Fintastic pearl has a special power.");
                    Console.WriteLine("And here it is btw, it's all yours.");
                    game.items.Add(new Item(name:"Orange Pearl", description:"Fintastic Pearl", x: 15, y: 15, roomNumber: this.RoomNumber, symbol: "🟠"));
                    Console.WriteLine("Now go away, I'm tired.");
                        this.MissionStatus = 1;
                    }
                    else{
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


    private void SeaLionDialogue(Game game)
{
    while (true)
    {
        Console.WriteLine("\nHello, I am a Sealion, you probably don't know me.. How may i help you?");
        Console.WriteLine("1. Do you know anything about the orange fintastic pearl?");
        Console.WriteLine("2. Eh, I don't feel like talking to you right now, i'll come back later!");
        int choice = GetPlayerChoice(2);

        if (choice == 1)
        {
            Console.WriteLine("\nOrange pearl eh? I happen to have heard of one, however my baby is in danger and I can't waste any time. You think you could help me?");
            Console.WriteLine("\n1. How did it happen?");
            Console.WriteLine("2. I'll help you..?");
            Console.WriteLine("3. This is a waste of time, I'll try to figure this out on my own");
            choice = GetPlayerChoice(3);

            if (choice == 1)
            {
                Console.WriteLine("\nAs I was looking for food, my baby saw something and went exploring on its own. I haven't seen him in 2 days, please help me! I'm Desperate.");
                Console.WriteLine("\n1. Thank you for sharing this heartfelt story.");
                GetPlayerChoice(1);
            }
            else if (choice == 2)
            {
                Console.WriteLine("\nThere is still hope. With enough effort, I'm sure you'll be able to rescue my baby!");
                Console.WriteLine("\n1. I am already on my way!");
                GetPlayerChoice(1);
            }
            else
            {
                Console.WriteLine("\nI've lost all hope, Goodbye!");
                break;
            }
        }
        else if (choice == 2)
        {
             Console.WriteLine("\n Goodbye then!");

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
