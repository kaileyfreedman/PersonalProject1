using System;

namespace PersonalProject1
{
    class TestAskQuestion
    {
        public static bool RunTest()
        {
            Question testQuestion = new Question();
            testQuestion.question = "Why did the chicken cross the road?";
            testQuestion.answers.Add("To get to the other side.");
            testQuestion.answers.Add("Because it was free-range.");
            testQuestion.answers.Add("He was hungry.");

            Console.WriteLine("Expected: the output to contain 3 options");
            Console.WriteLine("First type 4. This should be an invalid option. It will ask again");
            Console.WriteLine("Next type 1. This should be a valid option. By selecting 1, the method should return 1.");

            int result = Program.AskQuestion(testQuestion.question);

            Question testQuestion = new Question();
            testQuestion.question = "How much wood could a woodchuck chuck if a woodchuck could chuck wood?";
            testQuestion.answers.Add("As much wood as a woodchuck could chuck.")
            testQuestion.answers.Add("A small log.");
            testQuestion.answers.Add("A whole forest.");
            
            Console.WriteLine("Expected: the output to contain 3 options");
            Console.WriteLine("First type 4. This should be an invalid option. It will ask again");
            Console.WriteLine("Next type 1. This should be a valid option. By selecting 1, the method should return 1.");

            int result = Program.AskQuestion(testQuestion.question);

            Question testQuestion = new Question();
            testQuestion.question = "WIll Brooklin win the lottery?");
            testQuestion.answers.Add("Yes she will!";
            testQuestion.answers.Add("Not this time.");
            testQuestion.answers.Add("She does not like the lottery.");
            
            Console.WriteLine("Expected: the output to contain 3 options");
            Console.WriteLine("First type 4. This should be an invalid option. It will ask again");
            Console.WriteLine("Next type 1. This should be a valid option. By selecting 1, the method should return 1.");

            int result = Program.AskQuestion(testQuestion.question);

            return false;

            try
            {
                Program.AskQuestion("NotAnAnswer.txt");
                Console.Error.WriteLine("Expected an exception from loading \"NotAnAnswer.txt\");
                return false
            }

            catch (Exception e)
            {

            }
            return true           
        }
    }
}