using System;


namespace WorldOfZuul
{
    public class Parser
    {
        private ActionBar actionBar;
        public char ReadAction(char[] possibleMoves)
        {

            ConsoleKeyInfo key = Console.ReadKey(intercept: true);
            char return_key = key.KeyChar;
            return_key = char.ToLower(return_key);
            // A very nice way to check if a key is in an array
            while(!Array.Exists(possibleMoves, element => element == return_key))
            {
                actionBar = new ActionBar();
                actionBar.PrintMessage("| Invalid Action |", [35, 24]);
                // Console.WriteLine("Invalid Action"); //Redudntant this action is performed thought the ActionBar.
                key = Console.ReadKey(intercept: true);
                return_key = key.KeyChar;
                return_key = char.ToLower(return_key);
            }
            return return_key;
        }
    }

}
