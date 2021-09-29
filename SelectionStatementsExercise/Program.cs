using System;
using System.Collections.Generic;
using System.Text;

namespace SelectionStatementsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var r = new Random();
            var favNumber = r.Next(1, 1000);
            Console.WriteLine("Try to guess my favorite number");
            var userInput = int.Parse(Console.ReadLine());

            if (userInput < favNumber)
            {
                Console.WriteLine("too low\n");
            }
            else if (userInput > favNumber)
            {
                Console.WriteLine("too high\n");
            }
            else
            {
                Console.WriteLine("Nevermind\n");
            }

            Console.WriteLine("What is your favorite school subject");
            string subject = Console.ReadLine();

            switch (subject.ToLower())
            {
                case "math":
                    Console.WriteLine("Math is a challenging, but fun subject!");
                    break;
                case "science":
                    Console.WriteLine("Science is an interesting subject!");
                    break;
                case "biology":
                    Console.WriteLine("Biology is an subject!");
                    break;
                case "music":
                    Console.WriteLine("Music is a fun subject!");
                    break;
                case "history":
                    Console.WriteLine("History is an interesting subject!");
                    break;
                default:
                    Console.WriteLine("I dont think I know that subject.");
                    break;

            }
        }
    }
}
