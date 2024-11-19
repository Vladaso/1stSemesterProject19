namespace WorldOfZuul
{
    public class Action
    {
        //public bool Available { get; private set; };
        //public string CommandWord { get; private set; };
        private List<Edge> _edges;
        private Player _player;

        public Action(List<Edge> edges, Player player)
        {
            _edges = edges;
            _player = player;
        }

        public void MovePlayer(string direction) //move the action from game.cs
        {
            foreach (Edge edge in _edges){
                if(edge.con1start == _player.Position&& edge.direction1 == direction){
                    _player.Position = edge.con1end;
                    return;
                }
                else if(edge.con2start == _player.Position && edge.direction2 == direction){
                    _player.Position = edge.con2end;
                    return;
                }
            }
        }
    }
}

// pass down everything as reference using & propably
// this will later have every action, but for now its just the move action