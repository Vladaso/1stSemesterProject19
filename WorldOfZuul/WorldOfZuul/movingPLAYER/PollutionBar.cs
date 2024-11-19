namespace Testing
{
    public class PollutionBar
    {
        public int PollutionLevel { get; private set; }
        private string PollutionDesign = @"     Health: [                         ] ";
        private char Symbol  = '█';


        public PollutionBar(int pollutionLevel)
        {
            PollutionLevel = pollutionLevel;
            Draw();
        }


        private void Draw()
        {
            // Update();
            Console.SetCursorPosition(0, 0);
            Console.Write(PollutionDesign);
            Console.WriteLine(PollutionLevel + "%");
        }

        public void Update()
        {
            int start = PollutionDesign.IndexOf("[") + 1;
            int end = start + PollutionLevel / 4;
            for (int i = start; i < end; i++)
            {
                PollutionDesign = PollutionDesign.Remove(i, 1);
                PollutionDesign = PollutionDesign.Insert(i, Symbol.ToString());
            }
            Draw();
        }

        public void IncreasePollution(int amount)
        {
            PollutionLevel += amount;
            if (PollutionLevel == 100)
            {
                GameOver();
            }
            Update();
        }

        private void GameOver()
        {
            Console.CursorVisible = true;
            Console.Clear();
            Console.WriteLine("Game Over!");
            Console.ResetColor();
            Environment.Exit(0);
        }
    }
}