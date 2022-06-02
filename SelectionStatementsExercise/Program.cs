using System;

namespace SelectionStatementsExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Can you guess my favorite number?");
            var faveNumber = 14;
            var userGuess = int.Parse(Console.ReadLine());
            if (userGuess == 14)
            { Console.WriteLine("You guessed correct! Lets be friends!"); }
            else if (userGuess < 14)
            { Console.WriteLine("You guessed too low. :("); }
            else
            { Console.WriteLine("You guessed too high. :("); }
            Console.WriteLine();

            Console.WriteLine("Which of the following is your favorite subject?");
            Console.WriteLine("English, Science, Math, History, or PE");
            string UserAnswer = Console.ReadLine();
            switch (UserAnswer.ToLower())
            {
                case "english":
                    Console.WriteLine("Reading nerd!");
                    break;
                case "science":
                    Console.WriteLine("Science nerd");
                    break;
                case "math":
                    Console.WriteLine("Math nerd!");
                    break;
                case "history":
                    Console.WriteLine("History buff!!");
                    break;
                case "pe":
                    Console.WriteLine("We should hang out!");
                    break;
                    default:
                    Console.WriteLine("What are you talking about???");
                    break;
            }
        }
    }
}
