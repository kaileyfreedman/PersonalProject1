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

            // TODO(jcollard 2022-02-05): The error below says "A local variable
            // or function named 'testQuestion' is already defined in this
            // scope" This means that you have already declared `testQuestion`
            // above. To fix this, you should remove the `Question` at the
            // beginning of this line
            Question testQuestion = new Question();
            testQuestion.question = "How much wood could a woodchuck chuck if a woodchuck could chuck wood?";
            testQuestion.answers.Add("As much wood as a woodchuck could chuck.") // TODO(jcollard 2022-02-05): Missing semi-colon;
            testQuestion.answers.Add("A small log.");
            testQuestion.answers.Add("A whole forest.");
            
            Console.WriteLine("Expected: the output to contain 3 options");
            Console.WriteLine("First type 4. This should be an invalid option. It will ask again");
            Console.WriteLine("Next type 1. This should be a valid option. By selecting 1, the method should return 1.");

            // TODO(jcollard 2022-02-05): Remove `int`
            int result = Program.AskQuestion(testQuestion);

            Question testQuestion = new Question();
            testQuestion.question = "WIll Brooklin win the lottery?");
            testQuestion.answers.Add("Yes she will!";
            testQuestion.answers.Add("Not this time.");
            testQuestion.answers.Add("She does not like the lottery.");
            
            Console.WriteLine("Expected: the output to contain 3 options");
            Console.WriteLine("First type 4. This should be an invalid option. It will ask again");
            Console.WriteLine("Next type 1. This should be a valid option. By selecting 1, the method should return 1.");

            int result = Program.AskQuestion(testQuestion);

            return false;

            // TODO(jcollard: 2022-02-05): The error message here says,
            // "Argument 1: cannot convert from 'string' to
            // 'PersonalProject1.Question'" This is saying that
            // "NotAnAnswer.txt" is a string but the method AskQuestion expects
            // a Question. I love that you're following along with the examples!
            // What could you pass into this method that would not be a valid
            // input? What about null?
        
            try
            {
                Program.AskQuestion("NotAnAnswer.txt");
                Console.Error.WriteLine("Expected an exception from loading \"NotAnAnswer.txt\");
                return false
            }

            catch (Exception e)
            {

            }
            return true;           
        }
    }
}