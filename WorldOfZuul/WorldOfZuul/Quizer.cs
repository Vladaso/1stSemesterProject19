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
                "What percentage of Turtles have eaten plastic debris?", // text
                new List<string> {"15%", "31%", "52%", "78%"}, // choices
                "52%", // answer
                "https://www.uq.edu.au/news/article/2015/09/world%E2%80%99s-turtles-face-plastic-deluge-danger" // source
            ));
            
            questions.Add(new Question(
                "Why are coral reefs important?", // text
                new List<string> {"They produce most of the oxygen in Earth's atmosphere.", "They provide habitat, feeding, spawning, and nursery grounds for over 1 million aquatic species", "They are a major source of freshwater for nearby islands.", "They are the only habitat suitable for the Blue Whale."}, // choices
                "They provide habitat, feeding, spawning, and nursery grounds for over 1 million aquatic species", // answer
                "https://www.epa.gov/coral-reefs/basic-information-about-coral-reefs" // source
            ));
            
            questions.Add(new Question(
                "How much plastic waste gets into aquatic ecosystems every year?", // text
                new List<string> {"1-2 million tonnes", "19-23 million tonnes", "5-10 million tonnes", "30-35 million tonnes"}, // choices
                "19-23 million tonnes", // answer
                "https://www.unep.org/plastic-pollution" // source
            ));
            
            // questions.Add(new Question(
            //     "", // text
            //     new List<string> {}, // choices
            //     "", // answer
            //     "" // source
            // ));

            // OLD QUESIONS
            /*
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
            */
        }

        public Question GetRandomQuestion() {
            int index = random.Next(questions.Count);
            return questions[index];
        }

        public bool AskQuestion() {
            Question question = GetRandomQuestion();
            Console.WriteLine(question.DisplayQuestion());
            Console.Write("Enter your answer (number): ");
            string? answer = Console.ReadLine();

            if (question.CheckAnswer(answer)) {
                Console.WriteLine("Correct!");
                Console.WriteLine("source: " + question.Source); // source is displayed when the player guesses the question correctly
                Console.WriteLine("Press Enter to continue");
                Console.ReadLine();
                return true;
            } else {
                Console.WriteLine("Incorrect!");
                Console.WriteLine("Press Enter to continue");
                Console.ReadLine();
                return false;
            }
        }
    }
}