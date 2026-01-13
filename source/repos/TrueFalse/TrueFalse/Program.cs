using System;

namespace TrueOrFalse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to 'True or False?'\nPress Enter to begin:");
            string entry = Console.ReadLine();
            Tools.SetUpInputStream(entry);

            string[] questions = new string[]
            {
                "An eggplant is a vegetable.",
                "Eggplants are a species of berry.",
                "The chemical element for gold is Au."
            };

            bool[] answers = new bool[] { false, true, true };
            bool[] responses = new bool[questions.Length];

            if (questions.Length != answers.Length)
            {
                Console.WriteLine("there is a mistake");
            }

            int askingIndex = 0;

            foreach (var question in questions)
            {
                string input;
                bool isBool;
                bool inputBool;

                Console.WriteLine(question);
                Console.WriteLine("True or false?");
                input = Console.ReadLine().ToLower();

                // Check if the input is a valid boolean using Boolean.TryParse
                // formatting: Boolean.TryParse(stringToConvert, out resultVariable)
                isBool = Boolean.TryParse(input, out inputBool);
                while (isBool == false)
                {
                    Console.WriteLine("Please answer 'true' or 'false'.");
                    input = Console.ReadLine().ToLower();
                    isBool = Boolean.TryParse(input, out inputBool);

                }
                responses[askingIndex] = inputBool;
                askingIndex++;
            }
            int scoringIndex = 0;
            int score = 0;
            foreach (bool answer in answers)
            {
                bool response = responses[scoringIndex];
                Console.WriteLine($"Answer: {answer}, Response: {response}");
                if (answer == response)
                {
                    score++;
                }
                scoringIndex++;
            }
            Console.WriteLine($"Your final score is {score} out of {questions.Length}.");

        }
    }
}