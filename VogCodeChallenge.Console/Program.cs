using System;
using System.Collections.Generic;
using System.Linq;

namespace VogCodeChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            while (i < QuestionClass.NamesList.Count())
            {
                Console.WriteLine(QuestionClass.NamesList[i]);
                i++;
            }
        }
    }

    public static class QuestionClass
    {
        public static List<string> NamesList = new List<string>()
        {
            "Jimmy",
            "Jeffrey",
            "John",
        };
    }
}
