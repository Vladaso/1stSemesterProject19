namespace WorldOfZuul
{
    public class WelcomeArt
    {
        public static readonly string room_art_ascii = @"                                                                                        
┌────────────────────────────────────────────────────────────────────────────────────┐
│     o                                                                              │
│  o                o   _    _      _                           o                    │
│   /_|                | |  | |    | |                                               │
│  ('_)<|              | |  | | ___| | ___ ___  _ __ ___   ___       /_|             │
│   \_|     mmm        | |/\| |/ _ \ |/ __/ _ \| '_ ` _ \ / _ \     ('_)<|   mmm     │
│           )-(        \  /\  /  __/ | (_| (_) | | | | | |  __/      \_|     )-(     │
│          (   )        \/  \/ \___|_|\___\___/|_| |_| |_|\___|             (   )    │
│          |   |                                                            |   |    │
│          |   |                    o                 o                     |   |    │
│          |___|                               o                  o         |___|    │
│                  o                  o   ______      o                              │
│                                       _/  (   \_               /_|   o             │
│                             _       _/  (       \_  O         ('_)<|               │
│                            | \_   _/  (   (    0  \            \_|                 │
│                     o      |== \_/  (   (          |                               │
│                 o          |=== _ (   (   (        |                   mmm         │
│   mmm             /_|      |==_/ \_ (   (          |                   )-(         │
│   )-(            ('_)<|    |_/     \_ (   (    \__/                   (   )        │
│  (   )  o         \_|                \_ (      _/                     |   |    o   │
│  |   |                                 |  |___/                       |   |        │
│  |   |                                /__/                        o   |___|        │
│  |___|                                                                             │
└────────────────────────────────────────────────────────────────────────────────────┘
";

        public static void ShowTutorial()
        {
            Console.Clear();
            Console.WriteLine("\x1b[J");
            Console.Clear();
            
            _displayAscii();

            Console.WriteLine("Welcome to the game! Here’s a quick guide on how to navigate and interact within the game world.");
            continue_tutorial();

            Console.WriteLine(@"Move through different rooms using the W, A, S, D keys:
            \n W - Move up
            \n A - Move left
            \n S - Move down
            \n D - Move right
            \n Each time you press one of these keys, you’ll move in that direction, and a description of the new room will appear.");
            
            continue_tutorial();
            Console.WriteLine("In each room, you’ll see a list of possible actions or items you can interact with.");
            Console.WriteLine("The game will display any items or exits available, and you’ll have the option to interact with them.");

            continue_tutorial();
            Console.WriteLine("If a room contains items, the game will show you interaction options.");
            Console.WriteLine("To interact with an item, type the command displayed next to it (for example, “inspect,” “take,” “use,” etc.).");

            continue_tutorial();
            Console.WriteLine("Any item you collect will be added to your inventory.");
            Console.WriteLine("To check your inventory at any time, type inventory. You’ll see a list of items you’re carrying.");

            continue_tutorial();
            Console.WriteLine("Enjoy exploring, and good luck on your adventure!");
            Console.WriteLine("Press Enter to start the game!");
            Console.ReadLine();

            Console.Clear();
            Console.WriteLine("\x1b[J");
            Console.Clear();

            Game game = new();
            game.Play();


        }

        private static void continue_tutorial()
        {
            Console.WriteLine("\n Press Enter to continue...");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("\x1b[J");
            Console.Clear();
            _displayAscii();
        }

        private static void _displayAscii()
        {
            Console.WriteLine(room_art_ascii);
        }
    }

    class WelcomeArt2
    {
        public static void ShowTutorial2()
        {
            Console.Clear();
            Console.WriteLine(@"                                                                                        
┌────────────────────────────────────────────────────────────────────────────────────┐
│     o                                                                              │
│  o                o   _    _      _                           o                    │
│   /_|                | |  | |    | |                                               │
│  ('_)<|              | |  | | ___| | ___ ___  _ __ ___   ___       /_|             │
│   \_|     mmm        | |/\| |/ _ \ |/ __/ _ \| '_ ` _ \ / _ \     ('_)<|   mmm     │
│           )-(        \  /\  /  __/ | (_| (_) | | | | | |  __/      \_|     )-(     │
│          (   )        \/  \/ \___|_|\___\___/|_| |_| |_|\___|             (   )    │
│          |   |                 o        ______      o                     |   |    │
│          |   |                     o  _/  (   \_       o                  |   |    │
│          |___|              _       _/  (       \_  O           o         |___|    │
│                  o         | \_   _/  (   (    0  \                                │
│                            |== \_/  (   (          |           /_|   o             │
│                            |=== _ (   (   (        |          ('_)<|               │
│                            |==_/ \_ (   (          |           \_|                 │
│                     o      |_/     \_ (   (    \__/                                │
│                 o                    \_ (      _/                      mmm         │
│   mmm             /_|                  |  |___/                        )-(         │
│   )-(            ('_)<|               /__/                            (   )        │
│  (   )  o         \_|                                                 |   |    o   │
│  |   |                     [PRESS ENTER TO CONTINUE]                  |   |        │
│  |   |                                                            o   |___|        │
│  |___|                                                                             │
└────────────────────────────────────────────────────────────────────────────────────┘
            ");
            
            WipeOut();

            Console.WriteLine(@"                                                                                       
┌────────────────────────────────────────────────────────────────────────────────────┐
│     o                  _____     _             _       _                           │
│  o                o   |_   _|   | |           (_)     | |     o                    │
│   /_|                   | |_   _| |_ ___  _ __ _  __ _| |                          │
│  ('_)<|                 | | | | | __/ _ \| '__| |/ _` | |          /_|             │
│   \_|     mmm           | | |_| | || (_) | |  | | (_| | |         ('_)<|   mmm     │
│           )-(           \_/\__,_|\__\___/|_|  |_|\__,_|_|          \_|     )-(     │
│          (   )                                                            (   )    │
│          |   |                                                            |   |    │
│          |   |         ┌────────────────────────────────┐                 |   |    │
│          |___|         │                                │       o         |___|    │
│                  o     │            Navigation:         │                          │
│                        │Use the W, A, S, D keys to move:│      /_|   o             │
│                        │                                │     ('_)<|               │
│                        │         W - Move Up            │      \_|                 │
│                     o  │         A - Move Left          │                          │
│                 o      │         S - Move Down          │              mmm         │
│   mmm             /_|  │         D - Move Right         │              )-(         │
│   )-(            ('_)<|│                                │             (   )        │
│  (   )  o         \_|  └────────────────────────────────┘             |   |    o   │
│  |   |                     [PRESS ENTER TO CONTINUE]                  |   |        │
│  |   |                                                            o   |___|        │
│  |___|                                                                             │
└────────────────────────────────────────────────────────────────────────────────────┘
            ");
            WipeOut();

            Console.WriteLine(@"                                                                                            
┌────────────────────────────────────────────────────────────────────────────────────┐
│     o                  _____     _             _       _                           │
│  o                o   |_   _|   | |           (_)     | |     o                    │
│   /_|                   | |_   _| |_ ___  _ __ _  __ _| |                          │
│  ('_)<|                 | | | | | __/ _ \| '__| |/ _` | |          /_|             │
│   \_|     mmm           | | |_| | || (_) | |  | | (_| | |         ('_)<|   mmm     │
│           )-(           \_/\__,_|\__\___/|_|  |_|\__,_|_|          \_|     )-(     │
│          (   )                                                            (   )    │
│          |   |                                                            |   |    │
│          |   |         ┌────────────────────────────────┐                 |   |    │
│          |___|         │          Interacting:          │       o         |___|    │
│                  o     │                                │                          │
│                        │    In each room,you'll see     │      /_|   o             │
│                        │  available actions and items.  │     ('_)<|               │
│                        │                                │      \_|                 │
│                     o  │  Type commands like:           │                          │
│                 o      │  inspect to look at items      │              mmm         │
│   mmm             /_|  │  take to collect items         │              )-(         │
│   )-(            ('_)<|│  use to use items              │             (   )        │
│  (   )  o         \_|  └────────────────────────────────┘             |   |    o   │
│  |   |                     [PRESS ENTER TO CONTINUE]                  |   |        │
│  |   |                                                            o   |___|        │
│  |___|                                                                             │
└────────────────────────────────────────────────────────────────────────────────────┘
            ");
            WipeOut();


            Console.WriteLine(@"                                                                                           
┌────────────────────────────────────────────────────────────────────────────────────┐
│     o                  _____     _             _       _                           │
│  o                o   |_   _|   | |           (_)     | |     o                    │
│   /_|                   | |_   _| |_ ___  _ __ _  __ _| |                          │
│  ('_)<|                 | | | | | __/ _ \| '__| |/ _` | |          /_|             │
│   \_|     mmm           | | |_| | || (_) | |  | | (_| | |         ('_)<|   mmm     │
│           )-(           \_/\__,_|\__\___/|_|  |_|\__,_|_|          \_|     )-(     │
│          (   )                                                            (   )    │
│          |   |                                                            |   |    │
│          |   |         ┌────────────────────────────────┐                 |   |    │
│          |___|         │          Inventory:            │       o         |___|    │
│                  o     │                                │                          │
│                        │Check your inventory anytime by │      /_|   o             │
│                        │ typing inventory to see what   │     ('_)<|               │
│                        │        you're carrying.        │      \_|                 │
│                     o  │                                │                          │
│                 o      │  Good luck on your adventure!  │              mmm         │
│   mmm             /_|  │                                │              )-(         │
│   )-(            ('_)<|│                                │             (   )        │
│  (   )  o         \_|  └────────────────────────────────┘             |   |    o   │
│  |   |                       [PRESS ENTER TO START]                   |   |        │
│  |   |                                                            o   |___|        │
│  |___|                                                                             │
└────────────────────────────────────────────────────────────────────────────────────┘
            ");
            WipeOut();

            Game game = new Game();

        }

        private static void WipeOut()
        {
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("\x1b[J");
            Console.Clear();
        }
    }
}