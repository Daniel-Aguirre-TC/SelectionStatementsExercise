using System;

namespace SelectionStatementsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            // create a new Random var
            var r = new Random();
            var favNumber = r.Next(1, 1000);
            var userInput = int.Parse(Console.ReadLine());
            if (userInput < favNumber)
            {
                Console.WriteLine("Too Low!");
            }
            else if (userInput > favNumber)
            {
                Console.WriteLine("Too High!");
            }
            else Console.WriteLine("Nevermind, Lucky guess....");

            Console.WriteLine("Now tell me, what is your favorite subject in class?");
            string input = Console.ReadLine();
            switch(input)
            {
                case "math":
                case "Math":
                    Console.WriteLine("That's crazy, I like math too!");
                    break;
                case "reading":
                case "Reading":
                    Console.WriteLine("I'm not a big reader, unless it's code!");
                    break;
                case "coding":
                case "Coding":
                    Console.WriteLine("Coding is my passion!");
                    break;
                case "science":
                case "Science":
                    Console.WriteLine("Oooooh Mr Scientist!");
                    break;
                default:
                    Console.WriteLine("I dont know that subject, I'm sorry.");
                    break;
            }
        }
    }
}
