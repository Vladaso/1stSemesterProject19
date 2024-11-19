namespace WorldOfZuul
{
    public class PollutionMeter
    {
        private int PollutionLevel;
        private string PollutionArt = @"     Pollution: [                         ] ";
        private char Symbol =  '█';
        private int IncreaseAmount = 4;
        
        public PollutionMeter()
        {
            PollutionLevel = 0;
            Draw();
        } 

        public void Draw()
        {
            Update();
            Console.Write(PollutionArt);
            Console.WriteLine(PollutionLevel + "%");
        }

        private void Update()
        {
            int start = PollutionArt.IndexOf("[") + 1;
            int end = start + PollutionLevel / 4;
            for (int i = start; i < end; i++)
            {
                PollutionArt = PollutionArt.Remove(i, 1);
                PollutionArt = PollutionArt.Insert(i, Symbol.ToString());

            }
        }

        public void IncreasePollution()
        {
            PollutionLevel += IncreaseAmount;
            if (PollutionLevel == 100)
            {
                // GameOver();
            }
            Draw();
        }

    }
}