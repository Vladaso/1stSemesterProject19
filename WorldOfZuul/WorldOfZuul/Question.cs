namespace WorldOfZuul {
    public class Question {
        public string Text { get; set; }
        public List<string> Choices { get; set; }
        public string CorrectAnswer { get; set; }

        public Question(string text, List<string> choices, string correctAnswer) {
            Text = text;
            Choices = choices;
            CorrectAnswer = correctAnswer;
        }

        public bool CheckAnswer(string? answer) {
            int choiceIndex;
            if (int.TryParse(answer, out choiceIndex) && choiceIndex > 0 && choiceIndex <= Choices.Count) {
                return Choices[choiceIndex - 1].Equals(CorrectAnswer, StringComparison.OrdinalIgnoreCase);
            }
            return false;
        }

        public string DisplayQuestion() {
            string result = Text + "\n";
            for (int i = 0; i < Choices.Count; i++) {
                result += (i + 1) + ". " + Choices[i] + "\n";
            }
            return result;
        }
    }
}