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
    }
}
