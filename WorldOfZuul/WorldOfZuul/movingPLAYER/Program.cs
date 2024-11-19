namespace Testing

{
    class Testing
    {
        static void Main()
        {
            Console.Clear();
            Canvas canvas = new Canvas();
            canvas.Draw();

            PollutionBar pollutionBar = new PollutionBar(0);

            Player player = new Player(40, 2, pollutionBar);
            Console.CursorVisible = false;
            bool continueGame = true;
            player.Draw();
            while (continueGame)
            {
                ConsoleKeyInfo keyInfo = Console.ReadKey();
                if (keyInfo.Key == ConsoleKey.Escape)
                {
                    continueGame = false;
                    Console.CursorVisible = true;
                    Console.Clear();
                    Console.ResetColor();
                    Console.WriteLine("Thank you for playing!");
                } else
                {
                    pollutionBar.Update();
                    player.Move(keyInfo, canvas);
                }
            }
        }
    }
}