using System;
using System.Collections.Generic;

namespace WorldOfZuul
{
    /// <summary>
    /// Represents an action bar that contains a list of actions and the UI implementation.
    /// </summary>
    public class ActionBar
    {
        public string[] PossibleMoves { get; private set; }

        private readonly string ActionBarArt = @"
    ┌                                                                                    ┐
    │ > Where do you want to go?                                                 [map]   │
    │                                                                                    │
    │                                                                                    │
    │                                                                                    │
    └────────────────────────────────────────────────────────────────────────────────────┘
    ";

        /// <summary>
        /// Initializes a new instance of the <see cref="ActionBar"/> class with possible moves.
        /// </summary>
        /// <param name="possibleMoves">The list of possible moves.</param>
        public ActionBar(string[] possibleMoves)
        {
            PossibleMoves = possibleMoves ?? throw new ArgumentNullException(nameof(possibleMoves));
        }

        /// <summary>
        /// Builds the full action bar display as a string.
        /// </summary>
private string BuildDisplay()
{
    var display = new List<string>(ActionBarArt.Split('\n'));
    const int barWidth = 88;
    const int padding = 4;
    int contentWidth = barWidth - (padding); // there is padding only on one side

    string movesLine = new string("");
    if (PossibleMoves.Length > 0)
    {
        int spaceBetween = PossibleMoves.Length > 1
            ? (contentWidth - PossibleMoves.Length * 10) / (PossibleMoves.Length - 1)
            : 0;

        for (int i = 0; i < PossibleMoves.Length; i++)
        {
            movesLine += PossibleMoves[i].PadRight(10);
            if (i < PossibleMoves.Length - 1)
            {
                movesLine += new string(' ', spaceBetween);
            }
        }
    }
    movesLine = movesLine.PadRight(barWidth-padding);

    int movesRowIndex = 3;
    if (movesRowIndex < display.Count - 2)
    {
        display[movesRowIndex] = $"{new string(' ', padding)}│{movesLine}│";
    }
    return string.Join(Environment.NewLine, display);
}



        /// <summary>
        /// Returns the string representation of the action bar.
        /// </summary>
        /// <returns>The action bar as a formatted string.</returns>
        public override string ToString()
        {
            return BuildDisplay();
        }
    }
}
