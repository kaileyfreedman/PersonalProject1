using System;
using System.Collections.Generic;

namespace PersonalProject1
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length > 0 && args[0] == "test")
            {
                TestAll();
                return;
            }

            static void TestAll()
            {
                bool testAskQuestion = TestAskQuestion.RunTest();
                Console.WriteLine($"Test AskQuetsion(fileman): {testAskQuestion}");

                bool testGetResult = TestGetResult.RunTest();
                Console.WriteLine($"Test GetReuslt (options): {testGetResult}");

                bool testGetValidAnswer = TestGetValidAnswer.RunTest();
                Console.WriteLine($"Test testGetValidAnswer (options): {testGetValidAnswer}");

            }

            int result = Program.AskQuestion(testQuestion);

            Question location = new Question();

            location.question = "Where would you like to go?";
            location.answers.Add("Italy");
            location.answers.Add("your bedroom");
            location.answers.Add("Japan");
            location.answers.Add("Texas");
            location.answers.Add("Mexico");

            Console.WriteLine(location.question);
            Console.WriteLine($"1. {location.answers[0]}");
            Console.WriteLine($"2. {location.answers[1]}");
            Console.WriteLine($"3. {location.answers[2]}");
            Console.WriteLine($"4. {location.answers[3]}");
            Console.WriteLine($"5. {location.answers[4]}");

            Question freetime = new Question();

            freetime.question = "What do you like to to do in your free time?";
            freetime.answers.Add("paint");
            freetime.answers.Add("sleep");
            freetime.answers.Add("go to the mall");
            freetime.answers.Add("go bull riding");
            freetime.answers.Add("dance");

            Console.WriteLine(freetime.question);
            Console.WriteLine($"1. {freetime.answers[0]}");
            Console.WriteLine($"2. {freetime.answers[1]}");
            Console.WriteLine($"3. {freetime.answers[2]}");
            Console.WriteLine($"4. {freetime.answers[3]}");
            Console.WriteLine($"5. {freetime.answers[4]}");

            Question color = new Question();

            color.question = "What is your favorite color?";
            color.answers.Add("yellow");
            color.answers.Add("white");
            color.answers.Add("red");
            color.answers.Add("green");
            color.answers.Add("orange");

            Console.WriteLine(color.question);
            Console.WriteLine($"1. {color.answers[0]}");
            Console.WriteLine($"2. {color.answers[1]}");
            Console.WriteLine($"3. {color.answers[2]}");
            Console.WriteLine($"4. {color.answers[3]}");
            Console.WriteLine($"5. {color.answers[4]}");

            Question movie = new Question();

            movie.question = "What is your favorite movie?";
            movie.answers.Add("Lady and the Tramp");
            movie.answers.Add("Shreck");
            movie.answers.Add("Toy Story");
            movie.answers.Add("Kung Fu Panda");
            movie.answers.Add("Coco");

            Console.WriteLine(movie.question);
            Console.WriteLine($"1. {movie.answers[0]}");
            Console.WriteLine($"2. {movie.answers[1]}");
            Console.WriteLine($"3. {movie.answers[2]}");
            Console.WriteLine($"4. {movie.answers[3]}");
            Console.WriteLine($"5. {movie.answers[4]}");
        }

        public static int AskQuestion(Question question)
        {
            return -1;
        }

        // Display the question
        // Loop through each answer and display it
        // Use the GetValidAnswer method to get the user's response
        // Return the user's response

        // Second

        public static int GetValidAnswer(List<string> answers)
        {
            int userChoice;

            do
            {
                Console.WriteLine("Enter a number greater than 0:");
                string input = Console.ReadLine();
                bool isANumber = int.TryParse(input, out userChoice);
                if (isANumber == false)
                {
                    Console.Error.WriteLine("You did not enter a number.");
                }
                else if (userChoice <= 0 || userChoice >= answers.Count)
                {
                    Console.WriteLine($"That number is not greater than 0 or less than {answers.Count}.");
                }
            }
            while (userChoice <= 0 || userChoice >= answers.Count);

            return userChoice - 1;
        }

        // Validate that there is at least 1 possible answer.
        // If the list of answers is empty, throw an exception
        // Otherwise, Display a message asking the user to select an option.
        // Store the user's response in a variable name choice
        // Validate that choice is one of the possible answers
        // If it is not a valid answer
        // Display an error message
        // Go to 3
        // Otherwise, return the user's choice.

        // First


        public static string GetResult(List<int> scores, List<string> results)
        {
            if (results == null) throw new ArgumentNullException("List of results may not be null.");
            if (results.Count == 0) throw new ArgumentException("The list of results must contain at least 1 option.");

            int ix = 1;
            foreach (string result in results)
            {
                Console.WriteLine($"{ix}. {results}");
                ix = ix + 1;
            }
        }
        public static void Main()
        {
            List<string> results = new List<string>();
            results.Add("First Choice");
            results.Add("Second Choice");
            results.Add("Third Choice");
            DisplayResults(results);
        }



        // Initialize highest to 0. This variable represents the highest score we have seen so far.
        // Initialize highestIx to 0. This variable represents the index of the highest score we have seen so far.
        // Loop through each score in scores, tracking the index in a variable currentIx
        // If the score is greater than the highest score
        // Update highest to store the score (this is the highest score we have seen so far)
        // Update highestIx to store the currentIx (this is the index of the highest score we have seen so far)
        // After we have checked each score, highestIx should be the index of the highest score.
        // return results[highestIx];

        // Third
        return null;
    }
}

class Question
{
    public string question;
    public List<string> answers = new List<string>();
}
