using System;

namespace VogCodeChallenge.QuestionClass
{
    class Program
    {
        static void Main(string[] args)
        {            

           QuestionClass.DisplayName();
            Console.WriteLine();
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
