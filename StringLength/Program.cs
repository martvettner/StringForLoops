using System;

namespace StringLength
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter you name");
            string userinput = Console.ReadLine();
            int counter = 0;

            foreach (char letter in userinput)
            {
                Console.WriteLine(letter);
                counter++;
                Console.WriteLine($"letter {letter} is at {counter}");
            }

            Console.WriteLine($"your name is {counter} characters long");



        }
    }
}
