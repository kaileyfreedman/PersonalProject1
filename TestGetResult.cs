using System;
using System.Collections.Generic;

namespace PersonalProject1
{
    class TestGetResult
    {
        public static bool RunTest()
        {
            List<int> testScores = new List<int>();
            testScores.Add(3);
            testScores.Add(7);

            List<string> testResults = new List<string>();
            testResults = new List<string>();
            testResults.Add("Frank Zappa");
            testResults.Add("Metallica");

            string result = Program.GetResult(testScores, testResults);

            if (result != "Metallica")
            {
                Console.Error.WriteLine($"Expected Metallica but result was {result}.");
                return false;
            }

            testScores = new List<int>();
            testScores.Add(5);
            testScores.Add(2);

            testResults = new List<string>();
            testResults = new List<string>();
            testResults.Add("Chicken");
            testResults.Add("Cow");

            result = Program.GetResult(testScores, testResults);

            if (result != "Chicken")
            {
                Console.Error.WriteLine($"Expected Chicken but result was {result}.");
                return false;
            }

            // TODO(jcollard 2022-02-05): Try adding a test which uses 4 scores and 4 responses

            return true;
        }
    }
}