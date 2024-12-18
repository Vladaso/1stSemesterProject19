﻿using System.Data.Common;
using System.Linq;

namespace WorldOfZuul
{

    public class Game
    {
        public List<Room> rooms {get; private set;}
        public List<Edge> edges { get; private set; }
        public List<Item> items { get; private set; }
        private RoomArt roomArt;
        private Parser parser = new Parser();
        public Player player { get; private set; } = new Player();
        private Action action;
        public List<NPC> npcs;
        public Inventory inventory = new Inventory();
        //One time screen initialization
        public Screen screen = new Screen(37, 90); //Height, Width

        public Boolean continuePlaying = true;
        public PollutionMeter pollutionMeter = new PollutionMeter();

        public Game()
        {
            roomArt = new RoomArt();
            rooms = new List<Room>();
            edges = new List<Edge>();
            items = new List<Item>();
            npcs = new List<NPC>();
            action = new Action(game: this); // So Action can encapsulate the game logic
            CreateRooms();
            CreateEdges();
            CreateItems();
            InitializeNPCs();
        }

        private void CreateRooms()
        {
            rooms.Add(new Room(0, "Frog Room", "Placeholder"));
            rooms.Add(new Room(1, "Sealion Room", "Placeholder"));
            rooms.Add(new Room(2, "Whale Room", "Placeholder"));
            rooms.Add(new Room(3, "Cave Room", "Placeholder"));
            rooms.Add(new Room(4, "Reef Room", "Placeholder"));
            rooms.Add(new Room(5, "Broom Room", "Placeholder"));
            rooms.Add(new Room(6, "Diamond Room", "Placeholder"));
            rooms.Add(new Room(7, "Pyramid room", "Placeholder"));
            rooms.Add(new Room(8, "Bag Room", "Placeholder"));
            rooms.Add(new Room(9, "Maze room", "Placeholder"));
            rooms.Add(new Room(10, "Tower", "Placeholder"));

        
        }

        private void CreateEdges(){
            edges.Add(new Edge(0, 1, "north"));
            edges.Add(new Edge(1, 2, "west"));
            edges.Add(new Edge(2, 8, "west"));
            edges.Add(new Edge(8, 9, "south"));
            edges.Add(new Edge(1, 3, "east"));
            edges.Add(new Edge(3, 4, "south"));
            edges.Add(new Edge(4, 5, "south"));
            edges.Add(new Edge(5, 6, "west"));
            edges.Add(new Edge(5, 7, "east"));

        }

        private void CreateItems(){
            items.Add(new Item(name:"Hamburger", description:"Mhmm burger.", x: 15, y: 15, roomNumber: 9, symbol: "🍔"));
            items.Add(new Item(name:"Scissors", description:"Might be useful.", x: 22, y: 20, roomNumber: 3, symbol: "✁"));       }

        private void InitializeNPCs()
        {
            npcs.Add(new NPC("Frog", 0));
            npcs.Add(new NPC("Whale", 2));
            npcs.Add(new NPC("Octopus", 3));
            npcs.Add(new NPC("Sealion", 1));
            npcs.Add(new NPC("SeaHorse", 6));
            npcs.Add(new NPC("Turtle", 4));
            npcs.Add(new NPC("Dolphin", 5));
            npcs.Add(new NPC("Crab", 8));
            npcs.Add(new NPC("Scorpion", 7));
            npcs.Add(new NPC("Princess", 10));
        }

        private char[] GetPossibleMoves(){
            List<char> possibleMoves = new List<char>();
            foreach (Edge edge in edges)
            {
                if(edge.con1start == player.Position){
                    possibleMoves.Add(Utils.DirectionToChar(edge.direction1));
                }
                else if(edge.con2start == player.Position){
                    possibleMoves.Add(Utils.DirectionToChar(edge.direction2));
                }
            }
            possibleMoves.Add('q');
            possibleMoves.Add('m');
            if(items.Where(item => item.RoomNumber == player.Position).ToList().FirstOrDefault() != null){
                possibleMoves.Add('p');
            }
            if(npcs.Where(npc => npc.RoomNumber == player.Position).ToList().FirstOrDefault() != null){
                possibleMoves.Add('t');
            }
            return possibleMoves.ToArray();
        }

        public void Play()
        {
            Quizer quizer = new Quizer();

            while (continuePlaying)
            {
                ConsoleUtils.ClearConsole();

                char[] possibleMoves = GetPossibleMoves();

                ActionBar actionBar = new ActionBar(possibleMoves);

                pollutionMeter.Draw();

                screen.SetScreenContent(rooms[player.Position].RoomName,
                inventory.ShowInventory(), 
                roomArt.Rooms[player.Position],
                actionBar.ToString(), 
                items.Where(item => item.RoomNumber == player.Position).ToList());

                screen.Display();

                char input = parser.ReadAction(possibleMoves);

                action.Execute(input);
                if(pollutionMeter.IncreasePollution()){
                    continuePlaying = quizer.AskQuestion();
                    if(continuePlaying)
                    {
                        pollutionMeter.PollutionLevel = 0;
                    }
                }
            }
            action.Execute('q');
        }

    }
}
