using System;
using System.Collections.Generic;
using System.Text;

namespace VogCodeChallenge.QuestionClass
{
    public static class QuestionClass
    {
      static List<string> NamesList = new List<string>()
        {
            "Jimmy",
            "Jeffrey",
            "John",
        };

        public static void DisplayName()
        {
            int i = 0;
            do
            {
                Console.WriteLine(NamesList[i]);
                i++;
            } while (i < NamesList.Count); ;
        }

    }

}
