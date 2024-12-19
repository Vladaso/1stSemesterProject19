using System;
using System.Collections.Generic;
using System.Text;

namespace WorldOfZuul {
    public class Quizer {
        readonly List<Question> questions;
        readonly Random random;

        private Game game;

        public Quizer(Game game) {
            questions = new List<Question>();
            random = new Random();
            this.game = game;
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
            
            questions.Add(new Question(
                "What is considered point-source pollution", // text
                new List<string> {"Pollution from a factory or sewage treatment plant", "Pollution from agricultural runoff across multiple farms", "Air pollution from vehicles on highways", "Trash and debris washed into rivers during storms"}, // choices
                "Pollution from a factory or sewage treatment plant", // answer
                "https://www.eea.europa.eu/en/about/contact-us/faqs/what-are-the-main-sources-of-water-pollution" // source
            ));

            questions.Add(new Question(
                "Which of the following is a method to reduce water pollution?",
                new List<string> { "Dumping waste in rivers", "Using pesticides", "Recycling and proper waste disposal", "Deforestation" },
                "Recycling and proper waste disposal",
                "https://raleighnc.gov/stormwater/services/spot-report-and-stop-water-pollution/6-ways-prevent-water-pollution"
            ));

            questions.Add(new Question(
                "Which of the following is a biological indicator of water pollution?",
                new List<string> { "Sand", "Algae", "Birds", "Trees" },
                "Algae",
                "https://en.wikipedia.org/wiki/Bioindicator#Microalgae_in_water_quality"
            ));
            
            questions.Add(new Question(
                "What is eutrophication?",
                new List<string> { "A process of water purification", "A type of waterborne disease", "Excessive nutrients in water bodies", "A method of water conservation" },
                "Excessive nutrients in water bodies",
                "https://en.wikipedia.org/wiki/Eutrophication"
            ));


            questions.Add(new Question(
                "What is the main consequence of nutrient pollution in water bodies?", // text
                new List<string> {"Algal blooms", "Temperature increase", "Oil contamination", "Heavy metal buildup"}, // choices
                "Algal blooms", // answer
                "https://healingwaters.org/different-types-of-water-pollution/" // source
            ));

            questions.Add(new Question(
                "What type of pollution occurs when non-biodegradable materials like plastic enter water bodies?", // text
                new List<string> {"Microbiological pollution", "Plastic pollution", "Chemical pollution", "Nutrient pollution"}, // choices
                "Plastic pollution", // answer
                "https://healingwaters.org/different-types-of-water-pollution/" // source
            ));

            questions.Add(new Question(
                "What type of water pollution is caused by the addition of harmful chemicals such as pesticides, heavy metals, and industrial waste?", // text
                new List<string> {"Thermal pollution", "Chemical pollution", "Microbiological pollution", "Plastic pollution"}, // choices
                "Chemical pollution", // answer
                "https://healingwaters.org/different-types-of-water-pollution/" // source
            ));

            questions.Add(new Question(
                "What is the primary cause of water pollution in rivers and lakes?", // text
                new List<string> {"Industrial waste", "Agricultural runoff", "Oil spills", "Sewage and wastewater"}, // choices
                "Agricultural runoff", // answer
                "https://www.nrdc.org/stories/water-pollution-everything-you-need-know#causes" // source
            ));

            
            questions.Add(new Question(
                "Why is stormwater runoff a major source of water pollution?", // text
                new List<string> {"It carries pollutants from streets and sidewalks into water bodies", "It increases groundwater levels", "It helps clean contaminants naturally", "It raises water temperatures"}, // choices
                "It carries pollutants from streets and sidewalks into water bodies", // answer
                "https://www.nrdc.org/stories/water-pollution-everything-you-need-know#causes" // source
            ));

            questions.Add(new Question(
                "Which of the following is a significant consequence of nutrient pollution in coastal waters?", // text
                new List<string> { "Coral bleaching", "Hypoxia (low oxygen levels)", "Increased fish populations", "Oil spills" }, // choices
                "Hypoxia (low oxygen levels)", // answer
                "https://www.epa.gov/nutrientpollution/effects-environment" // source
            ));

            questions.Add(new Question(
                "Approximately what percentage of marine pollution originates on land?", // text
                new List<string> { "20%", "40%", "60%", "80%" }, // choices
                "80%", // answer
                "https://www.unep.org/explore-topics/oceans-seas/what-we-do/addressing-land-based-pollution" // source
            ));

            questions.Add(new Question(
                "What is the term for zones in the ocean with very low oxygen concentration caused by excessive nutrient pollution?", // text
                new List<string> { "Dead zones", "Coral reefs", "Upwelling zones", "Estuaries" }, // choices
                "Dead zones", // answer
                "https://oceanservice.noaa.gov/facts/deadzone.html" // source
            ));

            questions.Add(new Question(
                "What is the primary source of marine debris found in oceans?", // text
                new List<string> { "Natural disasters", "Fishing activities", "Land-based sources", "Oil spills" }, // choices
                "Land-based sources", // answer
                "https://oceanservice.noaa.gov/facts/marinedebris.html" // source
            ));

            questions.Add(new Question(
                "What percentage of marine debris is estimated to be plastic?", // text
                new List<string> { "50%", "60%", "70%", "80%" }, // choices
                "80%", // answer
                "https://oceanliteracy.unesco.org/plastic-pollution-ocean/" // source
            ));

            questions.Add(new Question(
                "How many pieces of plastic pollution are estimated to enter the ocean every day?", // text
                new List<string> { "1 million", "5 million", "8 million", "10 million" }, // choices
                "8 million", // answer
                "https://www.sas.org.uk/plastic-pollution/plastic-pollution-facts-figures/" // source
            ));

            questions.Add(new Question(
                "What is the estimated weight of plastic waste currently in our oceans?", // text
                new List<string> { "50 million tons", "100 million tons", "150 million tons", "200 million tons" }, // choices
                "75 to 199 million tons", // answer
                "https://www.condorferries.co.uk/marine-ocean-pollution-statistics-facts" // source
            ));

            questions.Add(new Question(
                "Which of the following is a significant effect of ocean pollution on marine life?", // text
                new List<string> { "Increased biodiversity", "Enhanced growth of coral reefs", "Habitat destruction", "Improved water quality" }, // choices
                "Habitat destruction", // answer
                "https://www.nrdc.org/stories/ocean-pollution-dirty-facts" // source
            ));

            questions.Add(new Question(
                "How many pieces of plastic are estimated to be in the ocean?", // text
                new List<string> { "1 trillion", "5 trillion", "10 trillion", "50 trillion" }, // choices
                "5.25 trillion", // answer
                "https://www.condorferries.co.uk/marine-ocean-pollution-statistics-facts" // source
            ));

            questions.Add(new Question(
                "Approximately how many marine animals die each year due to plastic pollution?", // text
                new List<string> { "100,000", "500,000", "1 million", "2 million" }, // choices
                "100,000", // answer
                "https://www.condorferries.co.uk/marine-ocean-pollution-statistics-facts" // source
            ));

            questions.Add(new Question(
                "How many marine species are harmed by plastic pollution?", // text
                new List<string> { "Over 100", "Over 500", "Over 700", "Almost 1000" }, // choices
                "Almost 1000", // answer
                "https://www.condorferries.co.uk/marine-ocean-pollution-statistics-facts" // source
            ));

            questions.Add(new Question(
                "What percentage of plastic waste is recycled globally?", // text
                new List<string> { "5%", "9%", "15%", "20%" }, // choices
                "9%", // answer
                "https://www.oecd.org/en/about/news/press-releases/2022/02/plastic-pollution-is-growing-relentlessly-as-waste-management-and-recycling-fall-short.html" // source
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
            Console.WriteLine(@"
                          .
                          A       ;
                |   ,--,-/ \---,-/|  ,
               _|\,'. /|      /|   `/|-.
           \`.'    /|      ,            `;.
          ,'\   A     A         A   A _ /| `.;
        ,/  _              A       _  / _   /|  ;
       /\  / \   ,  ,           A  /    /     `/|
      /_| | _ \         ,     ,             ,/  \
     // | |/ `.\  ,-      ,       ,   ,/ ,/      \/
     / @| |@  / /'   \  \      ,              >  /|    ,--.
    |\_/   \_/ /      |  |           ,  ,/        \  ./' __:..
    |  __ __  |       |  | .--.  ,         >  >   |-'   /     `
  ,/| /  '  \ |       |  |     \      ,           |    /
 /  |<--.__,->|       |  | .    `.        >  >    /   (
/_,' \\  ^  /  \     /  /   `.    >--            /^\   |
      \\___/    \   /  /      \__'     \   \   \/   \  |
       `.   |/          ,  ,                  /`\    \  )
         \  '  |/    ,       V    \          /        `-\
          `|/  '  V      V           \    \.'            \_
           '`-.       V       V        \./'\
               `|/-.      \ /   \ /,---`\         
                /   `._____V__katV'
            ");
            Console.WriteLine("Hello sir, sorry to interrupt but we are calibrating the filtration system and need some help.\n");
            Console.WriteLine("Please answer the following question to help us calibrate the system:\n");
            Question question = GetRandomQuestion();
            Console.WriteLine(question.DisplayQuestion());
            Console.Write("Enter your answer (number): ");
            string? answer = Console.ReadLine();
            game.questionsAsked++;
            if (question.CheckAnswer(answer)) {
                game.questionsCorrect++;
                Console.WriteLine("Something has changed...");
                game.pollutionMeter.IncreaseAmount *= 0.95;
                Console.WriteLine("Press Enter to continue");
                Console.ReadLine();
                return true;
            } else {
                Console.WriteLine("Something has changed...");
                game.pollutionMeter.IncreaseAmount *= 1.05;
                game.question_sources.Add(question.Source);
                Console.WriteLine("Press Enter to continue");
                Console.ReadLine();
                return false;
            }
        }
    }
}