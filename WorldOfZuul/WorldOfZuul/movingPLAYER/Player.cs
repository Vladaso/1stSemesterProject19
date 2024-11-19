namespace Testing
{
    public class Player
    {
        public int X { get; set; }
        public int Y { get; set; }
        public char Icon { get; set; } = '▄';
        private PollutionBar pollutionBar;

        public Player(int x, int y, PollutionBar pollutionBar)
        {
            X = x;
            Y = y;
            this.pollutionBar = pollutionBar;
        }

        public void Draw()
        {
            Clear();
            Console.SetCursorPosition(X, Y);
            Console.Write(Icon);
        }

        public void Clear()
        {
            Console.SetCursorPosition(X, Y);
            Console.WriteLine(" ");
        }


        public void Move(ConsoleKeyInfo keyInfo, Canvas canvas)
        {
            int dx = 0;
            int dy = 0;

            switch (keyInfo.Key)
                {
                    case ConsoleKey.LeftArrow:
                        dx = -1;
                        break;
                    case ConsoleKey.RightArrow:
                        dx = 1;
                        break;
                    case ConsoleKey.UpArrow:
                        dy = -1;
                        break;
                    case ConsoleKey.DownArrow:
                        dy = 1;
                        break;            
                }

            int newX = X + dx;
            int newY = Y + dy;
            // Check for collision
            if (canvas.IsCollision(newX, newY))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Draw();
                pollutionBar.IncreasePollution(4);
                Console.ResetColor();
            } else {
                // Console.ResetColor();
                Clear();
                X += dx;
                Y += dy;
                Draw();
            }
        }
    }
}
