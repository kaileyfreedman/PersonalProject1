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
            testQuestion.answers.Add("He was chasing a tiger.");
            testQuestion.answers.Add("There was a bbq restaurant across the street.");


            Console.WriteLine("Expected: the output to contain 3 options");
            Console.WriteLine("First type 4. This should be an invalid option. It will ask again");
            Console.WriteLine("Next type 1. This should be a valid option. By selecting 1, the method should return 1.");

            int result = Program.AskQuestion(testQuestion);

            // Feedback(jcollard 2022-02-07): Next, assume the person testing
            // follows the instructions exactly as stated. In that case, you
            // would be able to write the following check:

            int expected = 1; // We are expecting the result to be 1 if everything is working

            if (result != expected)
            {
                // If the result does not match what we expect, we display an
                // error message and return false.
                Console.Error.WriteLine($"Expected the result to be {expected} but it was {result}.");
                return false;
            }

            testQuestion = new Question();
            testQuestion.question = "How much wood could a woodchuck chuck if a woodchuck could chuck wood?";
            testQuestion.answers.Add("As much wood as a woodchuck could chuck."); 
            testQuestion.answers.Add("A small log.");
            testQuestion.answers.Add("A whole forest.");
            
            Console.WriteLine("Expected: the output to contain 3 options");

            // TODO(jcollard 2022-02-07): Try testing a new invalid input.
            Console.WriteLine("First type 4. This should be an invalid option. It will ask again");

            // TODO(jcollard 2022-02-07): Try testing a new valid input.
            Console.WriteLine("Next type 1. This should be a valid option. By selecting 1, the method should return 1.");

            result = Program.AskQuestion(testQuestion);

            // TODO(jcollard 2022-02-07): What is the expected result? Write a check.



            testQuestion = new Question();
            testQuestion.question = "Will Brooklin win the lottery?";
            testQuestion.answers.Add("Yes she will!");
            testQuestion.answers.Add("Not this time.");
            testQuestion.answers.Add("She does not like the lottery.");
            
            Console.WriteLine("Expected: the output to contain 3 options");
            Console.WriteLine("First type 4. This should be an invalid option. It will ask again");
            Console.WriteLine("Next type 1. This should be a valid option. By selecting 1, the method should return 1.");

            result = Program.AskQuestion(testQuestion);

            // TODO(jcollard 2022-02-07): What is the expected result? Write a check.


            // Feedback(jcollard 2022-02-07): I'm not entirely sure what you're trying to check here
            // are you expecting an error to happen?
            try
            {
                testQuestion = new Question();
                testQuestion.question = "WIll it rain tomorrow?";
                testQuestion.answers.Add("no");
                Console.WriteLine("Expected: the output to contain 3 options");
                return false;
            }

            catch (Exception e)
            {

            }
            
            return true;           
        }
    }
}