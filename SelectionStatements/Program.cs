using System;

namespace SelectionStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            var r = new Random();
            var favNumber = r.Next(1, 4000);

            Console.WriteLine("Guess my Favorite Number!");


            var userInput = int.Parse(Console.ReadLine());

            if (userInput < favNumber)
            {
                Console.WriteLine($"too low");
            }
            else if (userInput > favNumber)
            {
                Console.WriteLine($"too high");

            }
            else
            {
                Console.WriteLine($"Nevermind");
            }

            Console.WriteLine($"What is your favorite school subject?");

            var subject = Console.ReadLine().ToLower();



            switch (subject)
            {
                case "math":
                    Console.WriteLine($"love math problems!");
                    break;
                case "world history":
                    Console.WriteLine($"Love World History!");
                    break;
                case "Hummanites":
                    Console.WriteLine($"Hummanites is fun!");
                    break;
                case "biology":
                    Console.WriteLine($"Biology is stressful");
                    break;
                case "english":
                    Console.WriteLine($"English is ok");
                    break;
                default:
                    Console.WriteLine($"Havent heard about that {subject}, that is amazing that you enjoy it!");
                    break;


            }


        }
    }
}
