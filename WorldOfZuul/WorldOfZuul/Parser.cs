using System;


namespace WorldOfZuul
{
    public class Parser
    {
        public char ReadAction(char[] possibleMoves)
        {

            ConsoleKeyInfo key = Console.ReadKey(intercept: true);
            char return_key = key.KeyChar;
            return_key = char.ToLower(return_key);
            // A very nice way to check if a key is in an array
            while(!Array.Exists(possibleMoves, element => element == return_key))
            {
                if (key.Key == ConsoleKey.Escape)
                {
                    return 'q';
                }
                // Console.WriteLine("Invalid Action"); //Redudntant this action is performed thought the ActionBar.
                key = Console.ReadKey(intercept: true);
                return_key = key.KeyChar;
                return_key = char.ToLower(return_key);
            }
            return return_key;
        }
    }

}
