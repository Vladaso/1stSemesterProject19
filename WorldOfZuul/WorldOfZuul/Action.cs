using System.ComponentModel.DataAnnotations;

namespace WorldOfZuul
{
    public class Action
    {
        private Game game;
        public Action(Game game)
        {
            this.game = game;
        }
        public void Execute(char command){

            if(command == 'w' || command == 'a' || command == 's' || command == 'd'){
                MovePlayer(Utils.CharToDirection(command));
            }
            else if(command == 'q'){
                TerminateGame();
            }
            else if(command == 't'){
                game.npcs.Where(npc => npc.RoomNumber == game.player.Position).ToList().FirstOrDefault()!.StartDialogue(game);
            }
            else if(command == 'p'){
                Item p = game.items.Where(item => item.RoomNumber == game.player.Position).ToList().FirstOrDefault()!;
                game.inventory.AddItem(p);
                game.items.Remove(p);
                ExecuteHiddenEffects(p);
                Console.WriteLine("Press ENTER to continue");
                Console.ReadLine();
            }
                else if (command == 'm')
            {
                Map map = new Map(game);
                map.DisplayMap();
                Console.WriteLine("Press ENTER to return to the game.");
                Console.ReadLine();
            }
            else{
                throw new System.Exception("Invalid command");
            }
        }

        //Overloaded for easier calls
        public void Execute(string command){
            MovePlayer(command);
        }

        private void TerminateGame(){
            ConsoleUtils.ClearConsole();
            Console.WriteLine("                              . ");
            Console.WriteLine("Thank you for playing  ><(((º> ");
            Console.WriteLine();
            game.continuePlaying = false;
        }

        public void MovePlayer(string direction) //move the action from game.cs
        {
            foreach (Edge edge in game.edges){
                if(edge.con1start == game.player.Position&& edge.direction1 == direction){
                    game.player.Position = edge.con1end;
                    return;
                }
                else if(edge.con2start == game.player.Position && edge.direction2 == direction){
                    game.player.Position = edge.con2end;
                    return;
                }
            }
        }

        private void ExecuteHiddenEffects(Item p){
            if(p.Name == "Yellow Pearl"){
                game.pollutionMeter.IncreaseAmount *= 0.8;
            }
            else if(p.Name == "Purple Pearl"){
                game.pollutionMeter.IncreaseAmount *= 1.5;
            }
            else if(p.Name == "Blue Pearl"){
                game.pollutionMeter.PollutionLevel = Math.Max(game.pollutionMeter.PollutionLevel - 20, 0);
            }
        }
    }
}
