using System;

namespace AInUserInput
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name:");
            string userInput = Console.ReadLine().ToLower();
            char searchCriteria = 'a';
            int i = 0;

            foreach (char letter in userInput)
            {
                if (letter == searchCriteria)
                {
                    i++;
                }
            }
            if (i == 0)
            {
                Console.WriteLine("Your name has no As.");
            }
            else
            {
                Console.WriteLine($"Your name has {i} A(s).");
            }

        }
    }
}