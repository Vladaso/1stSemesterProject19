using System;

namespace WorldOfZuul
{
    public static class Utils
    {

//A little outdated name :D
public static string CharToDirection(char direction){
            if (direction == 'w'){
                return "north";
            }
            else if (direction == 's'){
                return "south";
            }
            else if (direction == 'd'){
                return "east";
            }
            else if (direction == 'a'){
                return "west";
            }
            else if(direction == 't'){
                return "talk";
            }
            else if(direction == 'p'){
                return "pick up";
            }
            else{
                return new string(direction, 1);
            }
        }
        public static char DirectionToChar(string direction){
            if (direction == "north"){
                return 'w';
            }
            else if (direction == "south"){
                return 's';
            }
            else if (direction == "east"){
                return 'd';
            }
            else if (direction == "west"){
                return 'a';
            }
            else{
                throw new Exception("Invalid direction");
            }
        }

    }
}