using System;
using System.Collections.Generic;

namespace PersonalProject1
{
    class TestGetValidAnswer
    {
        public static bool RunTest()
        {
            Console.WriteLine("Testing TestGetValidAnswer.");
            Console.WriteLine("You should expect to see the message 'Why did the chicken cross the road?'");
            Console.WriteLine("1. Enter '4'. This should display 'Invalid.' and ask again.");
            Console.WriteLine("2. Enter '0'. This should display 'Invalid' and ask again.");
            Console.WriteLine("3. Just press enter (do not enter anything). This should display 'Invalid' and ask again.");
            Console.WriteLine("4. Enter '2'. This should be successful.");

            List<string> answers = new List<string>();
            answers.Add("Strawberry");
            answers.Add("Blueberry");
            answers.Add("Bannana");
            int testResult = Program.GetValidAnswer(answers);
            int expected = 1;
            if (testResult != expected)
            {
                Console.Error.WriteLine($"Failure: Expected 1 but the result was {testResult}.");
                return false;
            }

            return true;
        }
    }
}