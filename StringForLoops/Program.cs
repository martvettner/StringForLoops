using System;

namespace StringForLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string helloworld = "hello world!";
            Console.WriteLine(helloworld[0]);
            Console.WriteLine(helloworld[6]);

            int stringLength = helloworld.Length;
            Console.WriteLine($"your text is {stringLength} symbols long");

            char searchCriteria = 'o';
            int counter = 0;


            foreach(char letter in helloworld)
            {


                if(letter == searchCriteria)
                {
                    counter++;
                }
            }

            Console.WriteLine($"there are {counter} Os in your text");

        }
    }
}
