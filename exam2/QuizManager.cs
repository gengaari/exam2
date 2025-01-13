using System;
using System.Collections.Generic;

namespace QuizApp
{
    public class QuizManager
    {
        public List<Question> GeographyQuestions { get; set; }
        public List<Question> MathQuestions { get; set; }
        public List<Question> MixedQuestions { get; set; }

        public QuizManager()
        {
            // Geography Questions
            GeographyQuestions = new List<Question>
            {
                new Question("What is the capital of France?",
                    new List<string> { "Paris", "Rome", "Berlin" },
                    new List<string> { "Paris" }),

                new Question("What is the capital of Spain?",
                    new List<string> { "Madrid", "Lisbon", "Barcelona" },
                    new List<string> { "Madrid" }),

                new Question("What is the capital of Italy?",
                    new List<string> { "Rome", "Milan", "Naples" },
                    new List<string> { "Rome" }),

                new Question("What is the capital of Japan?",
                    new List<string> { "Tokyo", "Osaka", "Kyoto" },
                    new List<string> { "Tokyo" }),

                new Question("What is the capital of Canada?",
                    new List<string> { "Ottawa", "Toronto", "Vancouver" },
                    new List<string> { "Ottawa" }),

                new Question("What is the capital of Germany?",
                    new List<string> { "Berlin", "Munich", "Frankfurt" },
                    new List<string> { "Berlin" }),

                new Question("What is the capital of Russia?",
                    new List<string> { "Moscow", "Saint Petersburg", "Novosibirsk" },
                    new List<string> { "Moscow" }),

                new Question("What is the capital of the USA?",
                    new List<string> { "Washington, D.C.", "New York", "Los Angeles" },
                    new List<string> { "Washington, D.C." }),

                new Question("What is the capital of Brazil?",
                    new List<string> { "Brasilia", "Rio de Janeiro", "Sao Paulo" },
                    new List<string> { "Brasilia" }),

                new Question("What is the capital of Egypt?",
                    new List<string> { "Cairo", "Alexandria", "Luxor" },
                    new List<string> { "Cairo" }),

                new Question("What is the capital of Mexico?",
                    new List<string> { "Mexico City", "Cancun", "Guadalajara" },
                    new List<string> { "Mexico City" }),

                new Question("What is the capital of Australia?",
                    new List<string> { "Canberra", "Sydney", "Melbourne" },
                    new List<string> { "Canberra" }),

                new Question("What is the capital of South Africa?",
                    new List<string> { "Pretoria", "Cape Town", "Johannesburg" },
                    new List<string> { "Pretoria" }),

                new Question("What is the capital of India?",
                    new List<string> { "New Delhi", "Mumbai", "Kolkata" },
                    new List<string> { "New Delhi" }),

                new Question("What is the capital of China?",
                    new List<string> { "Beijing", "Shanghai", "Hong Kong" },
                    new List<string> { "Beijing" }),

                new Question("What is the capital of United Kingdom?",
                    new List<string> { "London", "Edinburgh", "Cardiff" },
                    new List<string> { "London" }),

                new Question("What is the capital of Argentina?",
                    new List<string> { "Buenos Aires", "Rio de Janeiro", "Lima" },
                    new List<string> { "Buenos Aires" }),

                new Question("What is the capital of Thailand?",
                    new List<string> { "Bangkok", "Chiang Mai", "Phuket" },
                    new List<string> { "Bangkok" }),

                new Question("What is the capital of Saudi Arabia?",
                    new List<string> { "Riyadh", "Mecca", "Jeddah" },
                    new List<string> { "Riyadh" }),

                new Question("What is the capital of Sweden?",
                    new List<string> { "Stockholm", "Gothenburg", "Malmo" },
                    new List<string> { "Stockholm" })
            };

            // Math Questions
            MathQuestions = new List<Question>
            {
                new Question("What is 2 + 2?",
                    new List<string> { "4", "5", "6" },
                    new List<string> { "4" }),

                new Question("What is 5 * 3?",
                    new List<string> { "10", "12", "15" },
                    new List<string> { "15" }),

                new Question("What is 9 - 4?",
                    new List<string> { "5", "6", "7" },
                    new List<string> { "5" }),

                new Question("What is 6 / 2?",
                    new List<string> { "2", "3", "4" },
                    new List<string> { "3" }),

                new Question("What is 7 + 8?",
                    new List<string> { "13", "14", "15" },
                    new List<string> { "15" }),

                new Question("What is 10 * 2?",
                    new List<string> { "18", "20", "22" },
                    new List<string> { "20" }),

                new Question("What is 15 - 7?",
                    new List<string> { "6", "7", "8" },
                    new List<string> { "8" }),

                new Question("What is 25 / 5?",
                    new List<string> { "4", "5", "6" },
                    new List<string> { "5" }),

                new Question("What is 3 + 5?",
                    new List<string> { "7", "8", "9" },
                    new List<string> { "8" }),

                new Question("What is 12 - 6?",
                    new List<string> { "4", "5", "6" },
                    new List<string> { "6" }),

                new Question("What is 14 + 2?",
                    new List<string> { "15", "16", "17" },
                    new List<string> { "16" }),

                new Question("What is 8 * 3?",
                    new List<string> { "22", "24", "26" },
                    new List<string> { "24" }),

                new Question("What is 18 / 3?",
                    new List<string> { "5", "6", "7" },
                    new List<string> { "6" }),

                new Question("What is 10 + 10?",
                    new List<string> { "20", "21", "22" },
                    new List<string> { "20" }),

                new Question("What is 4 * 5?",
                    new List<string> { "19", "20", "21" },
                    new List<string> { "20" }),

                new Question("What is 50 - 20?",
                    new List<string> { "30", "35", "40" },
                    new List<string> { "30" }),

                new Question("What is 11 + 3?",
                    new List<string> { "12", "13", "14" },
                    new List<string> { "14" }),

                new Question("What is 2 * 6?",
                    new List<string> { "12", "14", "16" },
                    new List<string> { "12" }),

                new Question("What is 20 / 4?",
                    new List<string> { "4", "5", "6" },
                    new List<string> { "5" })
            };

            // Mixed Questions
            MixedQuestions = new List<Question>
            {
                 new Question("Which color is the sky on a clear day?",
                    new List<string> { "Blue", "Red", "Green" },
                    new List<string> { "Blue" }),

                new Question("What is the boiling point of water?",
                    new List<string> { "100°C", "50°C", "200°C" },
                    new List<string> { "100°C" }),

                new Question("How many continents are there?",
                    new List<string> { "5", "6", "7" },
                    new List<string> { "7" }),

                new Question("Which planet is known as the Red Planet?",
                    new List<string> { "Mars", "Earth", "Venus" },
                    new List<string> { "Mars" }),

                new Question("Which animal is known for its long neck?",
                    new List<string> { "Giraffe", "Elephant", "Lion" },
                    new List<string> { "Giraffe" }),

                new Question("What is the longest river in the world?",
                    new List<string> { "Amazon", "Nile", "Yangtze" },
                    new List<string> { "Nile" }),

                new Question("Which country is known as the Land of the Rising Sun?",
                    new List<string> { "China", "Japan", "India" },
                    new List<string> { "Japan" }),

                new Question("What is the largest ocean in the world?",
                    new List<string> { "Atlantic", "Pacific", "Indian" },
                    new List<string> { "Pacific" }),

                new Question("How many legs does a spider have?",
                    new List<string> { "6", "8", "10" },
                    new List<string> { "8" }),

                new Question("Which element is most abundant in the Earth’s crust?",
                    new List<string> { "Oxygen", "Hydrogen", "Nitrogen" },
                    new List<string> { "Oxygen" }),

                new Question("Which country has the most population?",
                    new List<string> { "China", "India", "USA" },
                    new List<string> { "China" }),

                new Question("Which device do you use to measure temperature?",
                    new List<string> { "Thermometer", "Barometer", "Odometer" },
                    new List<string> { "Thermometer" }),

                new Question("What is the hardest natural substance?",
                    new List<string> { "Diamond", "Gold", "Iron" },
                    new List<string> { "Diamond" }),

                new Question("Which gas do plants absorb for photosynthesis?",
                    new List<string> { "Oxygen", "Nitrogen", "Carbon dioxide" },
                    new List<string> { "Carbon dioxide" }),

                new Question("What is the capital of France?",
                    new List<string> { "Paris", "Berlin", "Rome" },
                    new List<string> { "Paris" }),

                new Question("Which of these is a mammal?",
                    new List<string> { "Shark", "Eagle", "Whale" },
                    new List<string> { "Whale" }),

                new Question("What is the speed of light?",
                    new List<string> { "300,000 km/s", "400,000 km/s", "500,000 km/s" },
                    new List<string> { "300,000 km/s" }),

                new Question("Who invented the telephone?",
                    new List<string> { "Alexander Graham Bell", "Thomas Edison", "Nikola Tesla" },
                    new List<string> { "Alexander Graham Bell" }),

                new Question("Which gas do we breathe in?",
                    new List<string> { "Oxygen", "Carbon dioxide", "Nitrogen" },
                    new List<string> { "Oxygen" })
            };
        }

        public void StartQuiz(string category)
        {
            List<Question> selectedCategory = new List<Question>();

            if (category.ToLower() == "geography")
            {
                selectedCategory = GeographyQuestions;
            }
            else if (category.ToLower() == "math")
            {
                selectedCategory = MathQuestions;
            }
            else if (category.ToLower() == "mixed")
            {
                selectedCategory = MixedQuestions;
            }
            else
            {
                Console.WriteLine("Invalid category.");
                return;
            }

            int correctAnswers = 0;
            foreach (var question in selectedCategory)
            {
                Console.WriteLine(question.QuestionText);
                for (int i = 0; i < question.Options.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {question.Options[i]}");
                }

                Console.Write("Type: ");
                string userAnswer = Console.ReadLine();
                var userAnswers = userAnswer.Split(',');

                bool isCorrect = true;
                foreach (var correctAnswer in question.CorrectAnswers)
                {
                    if (!userAnswers.Contains(correctAnswer))
                    {
                        isCorrect = false;
                        break;
                    }
                }

                if (isCorrect)
                {
                    correctAnswers++;
                }
            }

            Console.WriteLine($"Quiz finished! You answered {correctAnswers} questions correctly.");
        }
    }
}