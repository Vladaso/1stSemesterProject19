namespace WorldOfZuul
{
    public class PollutionMeter
    {
        public double PollutionLevel;
        private const int MaxPollutionLevel = 100;
        private const int BarLength = 25;
        private string PollutionArt = "     Pollution: [                         ] ";
        private char Symbol = '█';
        public double IncreaseAmount = 1;

        public PollutionMeter()
        {
            PollutionLevel = 0;
            Draw();
        }

        public void Draw()
        {
            Update();
            Console.Write(PollutionArt);
            Console.WriteLine((int)PollutionLevel + "%");
        }

        private void Update()
        {
            int filledLength =(int) (PollutionLevel * BarLength) / MaxPollutionLevel;
            string bar = new string(Symbol, filledLength).PadRight(BarLength, ' ');
            PollutionArt = $"     Pollution: [{bar}] ";
        }

        public bool IncreasePollution()
        {
            PollutionLevel = Math.Min(PollutionLevel + IncreaseAmount, MaxPollutionLevel);
            Draw();
            return PollutionLevel == MaxPollutionLevel;
        }
    }
}