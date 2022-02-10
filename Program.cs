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

            List<int> scores = new List<int>();
            scores.Add(0);
            scores.Add(0);
            scores.Add(0);
            scores.Add(0);
            scores.Add(0);

            Question location = new Question();

            location.question = "Where would you like to go?";
            location.answers.Add("Italy");
            location.answers.Add("your bedroom");
            location.answers.Add("Japan");
            location.answers.Add("Texas");
            location.answers.Add("Mexico");

            int result = Program.AskQuestion(location);
            scores[result] = scores[result] + 1;

            Question freetime = new Question();

            freetime.question = "What do you like to to do in your free time?";
            freetime.answers.Add("paint");
            freetime.answers.Add("sleep");
            freetime.answers.Add("go to the mall");
            freetime.answers.Add("go bull riding");
            freetime.answers.Add("dance");

            result = Program.AskQuestion(freetime);
            scores[result] = scores[result] + 1;


            Question color = new Question();

            color.question = "What is your favorite color?";
            color.answers.Add("yellow");
            color.answers.Add("white");
            color.answers.Add("red");
            color.answers.Add("green");
            color.answers.Add("orange");

            result = Program.AskQuestion(color);
            scores[result] = scores[result] + 1;


            Question movie = new Question();

            movie.question = "What is your favorite movie?";
            movie.answers.Add("Lady and the Tramp");
            movie.answers.Add("Shreck");
            movie.answers.Add("Toy Story");
            movie.answers.Add("Kung Fu Panda");
            movie.answers.Add("Coco");

            result = Program.AskQuestion(movie);
            scores[result] = scores[result] + 1;

            List<string> results = new List<string>();
            results.Add("bob1");
            results.Add("bob2");
            results.Add("bob3");
            results.Add("bob4");
            results.Add("bob5");



            GetResult(scores, results);

        }

        public static int AskQuestion(Question question)
        {
            // Display the question
            // Loop through each answer and display it
            // Use the GetValidAnswer method to get the user's response
            // Return the user's response

            if (question == null) throw new ArgumentNullException("List of question may not be null.");
            if (question.answers.Count == 0) throw new ArgumentException("The list of question must contain at least 1 option.");
            Console.WriteLine(question.question);
            int ix = 1;
            foreach (string answer in question.answers)
            {
                Console.WriteLine($"{ix}. {answer}");
                ix = ix + 1;
            }
            return GetValidAnswer(question.answers);
        }

        public static int GetValidAnswer(List<string> answers)
        {
            // Validate that there is at least 1 possible answer.
            // If the list of answers is empty, throw an exception
            // Otherwise, Display a message asking the user to select an option.
            // Store the user's response in a variable name choice
            // Validate that choice is one of the possible answers
            // If it is not a valid answer
            // Display an error message
            // Go to 3
            // Otherwise, return the user's choice.

            int userChoice;
            do
            {
                Console.WriteLine("Enter a valid option:");
                string input = Console.ReadLine();
                bool isANumber = int.TryParse(input, out userChoice);
                if (isANumber == false)
                {
                    Console.Error.WriteLine("You did not enter a number.");
                }
                else if (userChoice <= 0 || userChoice > answers.Count)
                {
                    Console.WriteLine($"That number is not greater than 0 and less than {answers.Count + 1}.");
                }
            }
            while (userChoice <= 0 || userChoice > answers.Count);

            return userChoice - 1;
        }

        public static string GetResult(List<int> scores, List<string> results)
        {
            // Initialize highest to 0. This variable represents the highest score we have seen so far.
            // Initialize highestIx to 0. This variable represents the index of the highest score we have seen so far.
            // Loop through each score in scores, tracking the index in a variable currentIx
            // If the score is greater than the highest score
            // Update highest to store the score (this is the highest score we have seen so far)
            // Update highestIx to store the currentIx (this is the index of the highest score we have seen so far)
            // After we have checked each score, highestIx should be the index of the highest score.
            // return results[highestIx];

            if (scores == null || results == null) throw new Exception("Scores and Results Lists must be non-null.");
            if (scores.Count == 0) throw new Exception("Cannot process an empty list.");
            if (results.Count != scores.Count) throw new Exception("Scores and Results Lists were not the same length.");
            int largestScore = scores[0];
            string associatedResult = results[0];
            int index = 0;
            foreach (int score in scores)
            {
                if (score > largestScore)
                {
                    associatedResult = results[index];
                    largestScore = scores[index];
                }
                index = index + 1;
            }
            Console.WriteLine($"You are {associatedResult}");
            return associatedResult;
        }
    }
}

class Question
{
    public string question;
    public List<string> answers = new List<string>();
}
