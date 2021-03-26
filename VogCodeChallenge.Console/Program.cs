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
            Console.WriteLine("================================");
            Console.WriteLine(QuestionClass.TESTModule(1));
            Console.WriteLine(QuestionClass.TESTModule(5));
            Console.WriteLine(QuestionClass.TESTModule(1.4));
            Console.WriteLine(QuestionClass.TESTModule(7.2));
            Console.WriteLine(QuestionClass.TESTModule("john"));
            try
            {
                Console.WriteLine(QuestionClass.TESTModule(0));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
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
        public static int TESTModule(int value) => value switch
        {
            int n when n > 1 && n < 2 => 3,
            int n when n >= 1 && n <= 4 => value * 2,
            int n when n > 4 => value * 3,
            int n when n < 1 => throw new ArgumentException("Argument cannot be less than 1", "value"),
            _ => value,
        };
        public static double TESTModule(double value) => value switch
        {
            double n when n > 1 && n < 2 => 3,
            double n when n < 1 => throw new ArgumentException("Argument cannot be less than 1", "value"),
            _ => value,
        };
        public static string TESTModule(string value) => value.ToUpper();
    }
}
