using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldOfZuul
{
    public class Command
    {
        public string Name { get; }
        public string? SecondWord { get; } // this might be used for future expansions, such as "take apple".

        public Command(string name, string? secondWord = null)
        {
            Name = name;
            SecondWord = secondWord;
        }
    }
}
