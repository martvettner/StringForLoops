using System;

namespace NameLengthComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter name 1:");
            string userNameOne = Console.ReadLine();

            Console.WriteLine("Enter name 2:");
            string userNameTwo = Console.ReadLine();

            int userNameOneLength = userNameOne.Length;
            int userNameTwoLength = userNameTwo.Length;

            if (userNameOneLength > userNameTwoLength)
            {
                Console.WriteLine($"{userNameOne} is longer than {userNameTwo}.");
            }
            else
            {
                Console.WriteLine($"{userNameTwo} is longer than {userNameOne}.");
            }
        }
    }
}