using System;

namespace SelectionStatementsExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var r = new Random();
            var faveNumber = r.Next(1, 100);
            int userGuess;
            do
            {
                Console.WriteLine("Can you guess my favorite number?");
                userGuess = int.Parse(Console.ReadLine());
                if (userGuess > faveNumber)
                { 
                    Console.WriteLine("You guessed too high. :(");
                }
                else if (userGuess < faveNumber)
                { 
                    Console.WriteLine("You guessed too low. :(");
                }
                else
                {Console.WriteLine("You guessed it! Lets be friends!"); }
                Console.WriteLine(); 
            }
            while(userGuess != faveNumber);

            Console.WriteLine("Which of the following is your favorite subject?");
            Console.WriteLine("English, Science, Math, History, or PE");
            string UserAnswer = Console.ReadLine();
            switch (UserAnswer.ToLower())
            {
                case "english":
                    Console.WriteLine("Reading nerd!");
                    break;
                case "science":
                    Console.WriteLine("Science nerd!");
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
