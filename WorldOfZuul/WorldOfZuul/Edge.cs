namespace WorldOfZuul
{
    public class Edge{
        public int con1start {get; private set;}
        public int con1end {get; private set;}
        public string direction1 {get; private set;}

        public int con2start {get; private set;}
        public int con2end {get; private set;}
        public string direction2 {get; private set;}
    
        public Edge(int con1, int con2, string dir){
            con1start = con1;
            con1end = con2;
            direction1 = dir;

            direction2 = changeDirection(dir);
            con2start = con2;
            con2end = con1;
        }
        private string changeDirection(string direction){
            if (direction == "north"){
                return "south";
            }
            else if (direction == "south"){
                return "north";
            }
            else if (direction == "east"){
                return "west";
            }
            else if (direction == "west"){
                return "east";
            }
            else{
                throw new Exception("Invalid direction");
            }
        }
    }
}