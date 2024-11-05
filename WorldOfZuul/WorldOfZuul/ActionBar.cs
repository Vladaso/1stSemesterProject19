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
        public List<Action> Actions { get; private set; }
        
        /// <summary>
        /// Represents a string that contains the UI implementation of the Action Bar.
        /// </summary>
        public string ActionBarArt { get; private set; } //I think this should be a class by its so I give what info to incorporate and then display it

        /// <summary>
        /// Initialize a new instance of the <see cref="ActionBar"/> class.
        /// </summary>
        /// <param name="actions">The list of actions.</param>
        /// <param name="actionBarArt">The action bar artwork.</param>
        /// <exception cref="ArgumentNullException">Thrown when actions or actionBarArt is null.</exception>
        public ActionBar(List<Action> actions, string actionBarArt)
        {
            Actions = (actions != null) ? actions : throw new ArgumentNullException(nameof(actions));
            ActionBarArt = (actionBarArt != null) ? actionBarArt : throw new ArgumentNullException(nameof(ActionBarArt));
        }

        /// <summary>
        /// Display the action bar.
        /// </summary>
        public void Display()
        {

            Console.WriteLine(ActionBarArt);
        }

        /// <summary>
        /// Updates the state of the player object in the game.
        /// </summary>
        /// <param name="player">The player object.</param>
        private void UpdateState(Player player)
        {
            // Updates state based on player object
        }
    }

        /// <summary>
        /// Create a player object - temporary until class implemented.
        /// </summary>
        public class Player
        {
            // Player class created
        }
}
