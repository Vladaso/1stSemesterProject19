using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldOfZuul
{
    public class Parser
    {
        private readonly CommandWords commandWords = new();

        public Command? GetCommand(string inputLine)
        {
            string[] words = inputLine.Split();

            if (words.Length == 0 || !commandWords.IsValidCommand(words[0]))
            {
                return null;
            }

            if (words.Length > 1)
            {
                return new Command(words[0], words[1]);
            }

            return new Command(words[0]);
        }
    }

}
