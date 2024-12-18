namespace WorldOfZuul
{
    public class PollutionMeter
    {
        public double PollutionLevel;
        private const int MaxPollutionLevel = 100;
        private const int MinPollutionLevel = 0;
        private const int BarLength = 25;
        private string PollutionArt = "     Pollution: [                         ] ";
        private char Symbol = '■';
        private const int StepAmount = 1;

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

        public bool IncreasePollution(double increaseAmount = StepAmount) //If no parameter passed the default will be the StepAmount 
        {
            PollutionLevel = Math.Min(PollutionLevel + increaseAmount, MaxPollutionLevel);
            // Draw();
            return PollutionLevel == MaxPollutionLevel;
        }

        public bool DecreasePollution(double decreaseAmount = StepAmount)
        {
            PollutionLevel = Math.Max(PollutionLevel - decreaseAmount, MinPollutionLevel);
            // Draw();
            return false;
        }

        public new string ToString()
        {
            return PollutionArt;
        }
    }
}