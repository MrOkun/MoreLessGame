using System;

namespace MoreLessC
{
    internal class Program
    {
        private static int attempt = 9;
        private static int number;

        static void Main(string[] args)
        {
            number = new Random().Next(0, 1000);

            while (attempt > 0)
            {
                Console.Write("Input -->");

                string input = Console.ReadLine();

                Console.WriteLine($"Attempts - {attempt}");

            question:
                if (int.TryParse(input, out int value))
                {
                    attempt--;

                    if (number == value)
                    {
                        Console.WriteLine($"You guessed the number {number}!");
                        return;
                    }
                    else
                    {
                        var result = number > value ? "greater" : "less";
                        Console.WriteLine($"You didn't guess the number. The hidden number is {result}");
                    }
                }
                else
                {
                    Console.WriteLine("Input is incorrect.");
                    goto question;
                }
            }
        }
    }
}