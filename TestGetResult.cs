using System;
using System.Collections.Generic;

namespace PersonalProject1
{
    class TestGetResult
    {
        public static bool RunTest()
        {
            List<int> testScores1 = new List<int>();
            testScores1.Add(3);
            testScores1.Add(7);

            List<string> testResults1 = new List<string>();
            testResults1 = new List<string>();
            testResults1.Add("Frank Zappa");
            testResults1.Add("Metallica");

            string result = Program.GetResult(testScores1, testResults1);

            if (result != "Metallica")
            {
                Console.Error.WriteLine($"Expected Metallica but result was {result}.");
                return false;
            }

            List<int> testScores2 = new List<int>();
            testScores2 = new List<int>();
            testScores2.Add(5);
            testScores2.Add(2);

            List<string> testResults2 = new List<string>();
            testResults2 = new List<string>();
            testResults2 = new List<string>();
            testResults2.Add("Chicken");
            testResults2.Add("Cow");

            string result2 = Program.GetResult(testScores2, testResults2);

            if (result2 != "Chicken")
            {
                Console.Error.WriteLine($"Expected Chicken but result was {result}.");
                return false;
            }

            // TODO(jcollard 2022-02-05): Try adding a test which uses 4 scores and 4 responses
            List<int> testScores3 = new List<int>();
            testScores3.Add(3);
            testScores3.Add(2);
            testScores3.Add(6);
            testScores3.Add(1);

            List<string> testResults3 = new List<string>();
            testResults3 = new List<string>();
            testResults3.Add("Winter");
            testResults3.Add("Spring");
            testResults3.Add("Summer");
            testResults3.Add("Fall");
            
            string result3 = Program.GetResult(testScores3, testResults3);

            if (result3 != "Summer")
            {
                Console.Error.WriteLine($"Expected Summer but result was {result}.");
                return false;
            }
            return true;
        }
    }
}