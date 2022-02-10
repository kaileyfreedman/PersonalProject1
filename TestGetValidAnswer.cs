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
            answers.Add("Bananna");

            // do another with 2 or 4 answers
            int testResult = Program.GetValidAnswer(answers);
            int expected = 1;
            if (testResult != expected)
            {
                Console.Error.WriteLine($"Failure: Expected 1 but the result was {testResult}.");
                return false;
            }

            return true;

            Console.WriteLine("Testing TestGetValidAnswer.");
            Console.WriteLine("You should expect to see the message 'What is your favorite color?'");
            Console.WriteLine("1. Enter '5'. This should display 'Invalid.' and ask again.");
            Console.WriteLine("2. Enter '0'. This should display 'Invalid' and ask again.");
            Console.WriteLine("3. Just press enter (do not enter anything). This should display 'Invalid' and ask again.");
            Console.WriteLine("4. Enter '4'. This should be successful.");

            List<string> answers2 = new List<string>();
            answers2.Add("Blue");
            answers2.Add("Yellow");
            answers2.Add("Red");
            answers2.Add("Green");

            int testResult2 = Program.GetValidAnswer(answers2);
            
            int expected2 = 1;
            if (testResult != expected)
            {
                Console.Error.WriteLine($"Failure: Expected 1 but the result was {testResult}.");
                return false;
            }

            return true;
        }
    }
}