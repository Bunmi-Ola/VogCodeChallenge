using System;

namespace VogCodeChallenge.QuestionClass
{
    class Program
    {
        static void Main(string[] args)
        {
            //run codes for Q7
            QuestionClass.DisplayName();
            Console.WriteLine();

            //run codes for Q8
            Console.WriteLine("Welcome to the TESTModule program, enter end to stop");
            Console.WriteLine("now Enter an input: ");
            object input = Console.ReadLine();
            while(input.ToString() != "end")
            {
                object value = QuestionClass.TESTModule(input);
                Console.WriteLine(value);
                Console.WriteLine("Enter another input: ");
                input = Console.ReadLine();
            }
        }
    }
}
