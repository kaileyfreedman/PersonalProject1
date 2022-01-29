using System;

namespace PersonalProject1
{
    class TestAskQuestion
    {
        public static bool RunTest()
        {
            List<string> scores = Program.LoadFile("test_socres.txt").ToList();

            if(scores.Count != 3)
            {
                Console.Error.WriteLine("The file test_scores should have 3 lines but that was not the case.");
                return false;
            }
        }
    }
}