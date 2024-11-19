using System;
using System.Collections.Generic;
using System.Text;

namespace WorldOfZuul {
    public class Quizer {
        readonly List<Question> questions;
        readonly Random random;

        public Quizer() {
            questions = new List<Question>();
            random = new Random();
            InitializeQuestions();
        }

        private void InitializeQuestions() {
            questions.Add(new Question(
                "What is the main cause of water pollution?",
                new List<string> { "Deforestation", "Industrial waste", "Overfishing", "Air pollution" },
                "Industrial waste"
            ));
            questions.Add(new Question(
                "Which of the following is a common pollutant found in water?",
                new List<string> { "Oxygen", "Nitrogen", "Lead", "Carbon dioxide" },
                "Lead"
            ));
            questions.Add(new Question(
                "What is eutrophication?",
                new List<string> { "A process of water purification", "A type of waterborne disease", "Excessive nutrients in water bodies", "A method of water conservation" },
                "Excessive nutrients in water bodies"
            ));
            questions.Add(new Question(
                "Which of the following is a consequence of water pollution?",
                new List<string> { "Increased fish population", "Improved water quality", "Harm to aquatic life", "Enhanced biodiversity" },
                "Harm to aquatic life"
            ));
            questions.Add(new Question(
                "What is the effect of plastic waste on marine life?",
                new List<string> { "No effect", "Improves habitat", "Causes harm and death", "Increases food supply" },
                "Causes harm and death"
            ));
            questions.Add(new Question(
                "Which of the following is a source of groundwater pollution?",
                new List<string> { "Rainwater", "Agricultural runoff", "Wind erosion", "Solar radiation" },
                "Agricultural runoff"
            ));
            questions.Add(new Question(
                "What is the impact of oil spills on water bodies?",
                new List<string> { "No impact", "Beneficial for marine life", "Devastating for marine ecosystems", "Increases water clarity" },
                "Devastating for marine ecosystems"
            ));
            questions.Add(new Question(
                "Which of the following is a method to reduce water pollution?",
                new List<string> { "Dumping waste in rivers", "Using pesticides", "Recycling and proper waste disposal", "Deforestation" },
                "Recycling and proper waste disposal"
            ));
            questions.Add(new Question(
                "What is the role of wetlands in water pollution control?",
                new List<string> { "Increase pollution", "Filter and purify water", "Destroy aquatic habitats", "Reduce water availability" },
                "Filter and purify water"
            ));
            questions.Add(new Question(
                "Which of the following is a biological indicator of water pollution?",
                new List<string> { "Fish", "Algae blooms", "Birds", "Trees" },
                "Algae blooms"
            ));
            questions.Add(new Question(
                "What is the effect of heavy metals in water?",
                new List<string> { "No effect", "Beneficial for health", "Toxic and harmful", "Increase oxygen levels" },
                "Toxic and harmful"
            ));
            questions.Add(new Question(
                "Which of the following practices can help prevent water pollution?",
                new List<string> { "Littering", "Using chemical fertilizers", "Planting trees", "Dumping industrial waste" },
                "Planting trees"
            ));
            questions.Add(new Question(
                "What is the impact of untreated sewage on water bodies?",
                new List<string> { "Improves water quality", "No impact", "Causes waterborne diseases", "Increases fish population" },
                "Causes waterborne diseases"
            ));
            questions.Add(new Question(
                "Which of the following is a chemical pollutant commonly found in water?",
                new List<string> { "Oxygen", "Hydrogen", "Mercury", "Nitrogen" },
                "Mercury"
            ));
            questions.Add(new Question(
                "What is the effect of nutrient pollution on aquatic ecosystems?",
                new List<string> { "No effect", "Promotes healthy growth", "Causes algal blooms and dead zones", "Increases biodiversity" },
                "Causes algal blooms and dead zones"
            ));
        }

        public Question GetRandomQuestion() {
            int index = random.Next(questions.Count);
            return questions[index];
        }

        public bool AskQuestion() {
            Question question = GetRandomQuestion();
            Console.WriteLine(question.DisplayQuestion());
            Console.Write("Enter your answer (number): ");
            string answer = Console.ReadLine();

            if (question.CheckAnswer(answer)) {
                Console.WriteLine("Correct!");
                return true;
            } else {
                Console.WriteLine("Incorrect!");
                return false;
            }
        }
    }
}