using System.Drawing;
using System.Runtime.CompilerServices;
using System.Security;

namespace WorldOfZuul
{
    /// <summary>
    /// Represents an action bar that contains a list of actions and the UI implementation.
    /// </summary>
    public class ActionBar
    {
        /// <summary>
        /// Represents a list of actions.
        /// </summary>
        // public List<Action> Actions { get; private set; }
        public List<Action> Actions { get; private set; }
        public string[] PossibleMoves { get; private set; }
        
        /// <summary>
        /// Represents a string that contains the UI implementation of the Action Bar.
        /// </summary>
        public string ActionBarArt = @"
    ┌                                                              [PRESS ESC TO EXIT]   ┐
    │ > Where do you want to go?                                                 [map]   │
    │                                                                                    │
    │                                                                                  > │
    │                                                                                    │
    └────────────────────────────────────────────────────────────────────────────────────┘
    ";
        public string ActionFrame { get; private set; } = @"
┌───┐
│ ► │
└───┘
";

        public string[] ActionButtons = new string[] {
    @"
┌───┐
│ ◄ │
└───┘",
    @"
┌───┐
│ ▼ │
└───┘",
    @"
┌───┐ 
│ ► │ 
└───┘",
    @"
┌───┐
│ ▲ │
└───┘"
        };



        /// <summary>
        /// Initialize a new instance of the <see cref="ActionBar"/> class.
        /// </summary>
        /// <param name="actions">The list of actions.</param>
        /// <param name="actionBarArt">The action bar artwork.</param>
        /// <exception cref="ArgumentNullException">Thrown when actions or actionBarArt is null.</exception>
        public ActionBar(List<Action> actions)
        {
            Actions = (actions != null) ? actions : throw new ArgumentNullException(nameof(actions));
            // ActionBarArt = (actionBarArt != null) ? actionBarArt : throw new ArgumentNullException(nameof(ActionBarArt));
            Console.WriteLine("ActionBar created. Actions added.");
        }

        public ActionBar(string[] possibleMoves)
        {
            PossibleMoves = (possibleMoves != null) ? possibleMoves : throw new ArgumentNullException(nameof(possibleMoves));
            // Console.WriteLine("ActionBar created, Possible Moves added.");
        }

        public ActionBar()
        {
        }

        /// <summary>
        /// Display the action bar.
        /// </summary>
        public void Display()
        {
            int barRow = 26;
            PlaceItem(ActionBarArt, 0, barRow);
            // Console.WriteLine(ActionBarArt);
            int row = barRow + 2;
            int col = 7;

            foreach (string action in PossibleMoves)
            {
                // PLaces the possible moves with frame, issue with horizontal move
                // string actionFrame = UpdateActionFrame(9, action);
                // PlaceItem(actionFrame, col , row );

                // Places the possible moves
                PlaceItem(Convert.ToString(action), col , row + 2 );
                col += 6;
            }
        }

        /// <summary>
        /// Updates the state of the player object in the game.
        /// </summary>
        /// <param name="player">The player object.</param>
        private void UpdateState(Player player)
        {
            // Updates state based on player object
        }

        /// <summary>
        /// Print given message when in Action Bar
        /// </summary>
        public void PrintMessage( string message, int[] position)
        {
            PlaceItem(message, position[0], position[1]);
            // Prints message that Input is invalid
        }

        /// <summary>
        /// Place given item into given postion on the Terminal
        /// </summary>
        /// <param name="item">The item.</param>
        private void PlaceItem(string item, int row, int col)
        {
            // Save current position
            (int left, int top) = Console.GetCursorPosition();

            // PLace item in desired position and restore to old postion
            Console.SetCursorPosition(row, col);
            Console.Write(item);
            // (left, top) = Console.GetCursorPosition();
            Console.SetCursorPosition(left, top);

        }

        /// <summary>
        /// Update the Action frame with a given character.
        /// </summary>
        /// <param name="index">The postion where the character will be placed.</param>
        /// <param name="newChar">The character to be placed.</param>
            private string UpdateActionFrame(int index, char newChar)
            {
                if (index < 0 || index >= ActionFrame.Length)
                {
                    throw new ArgumentOutOfRangeException(nameof(index), "Index is out of range.");
                }

                char[] chars = ActionFrame.ToCharArray();
                chars[index] = newChar;

                ActionFrame = new string(chars);
                return ActionFrame;
    }

    }
}
