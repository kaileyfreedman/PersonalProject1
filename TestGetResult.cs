using System;
using System.Collections.Generic;

namespace PersonalProject1
{
    class TestGetResult
    {
        public static bool TestGetResult()
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

            List<string> testResults = new List<string>();
            testResults = new List<string>();
            testResults.Add("Chicken");
            testResults.Add("Cow");

            string result = Program.GetResult(testScores, testResults);

            if (result != "Chicken")
            {
                Console.Error.WriteLine($"Expected Chicken but result was {result}.");
                return false;
            }

            //  return false;
            //  testInput = "2";
            //  testResult = Program.IsValidAnswer(testInput);
            //  expected = true;
            //  if (testResult != expected)
            //  {
            //      Console.Error.WriteLine($"Failure: Expected true but was actually {testResult}");
            //      return false;
            //  }

            //  testInput = "-2";
            //  testResult = Program.IsValidAnswer(testInput);
            //  expected = false;
            //  if (testResult != expected)
            //  {
            //      Console.Error.WriteLine($"Failure: Expected false but was actually {testResult2}");
            //      return false;
            //  }

            //  testInput = "3.5";
            //  testResult = Program.IsValidAnswer(testInput);
            //  expected = false;

            //  if (testResult != expected)
            //  {
            //      Console.Error.WriteLine($"Failure: Expected true but was actually {testResult}");
            //      return false;
            //  }

            //  try
            //  {
            //      testResult = Program.IsValidAnswer(null);

            //      Console.Error.WriteLine("Failure: Expected the program to crash. But it did not.");
            //      return false;
            //  }
            //  catch
            //  {

            //  }

            // Our method seems to be working
            return true;
        }
    }
}