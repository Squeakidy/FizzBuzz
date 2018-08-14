using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            UserInput userInput = new UserInput();
            int lowerRange, upperRange;

            Console.WriteLine("Give a starting value.");
            lowerRange = userInput.GetInput();
            Console.WriteLine("Give an end value.");
            upperRange = userInput.GetInput();
            GetOutput(lowerRange, upperRange);
        }


        static void GetOutput(int lowerRange, int upperRange)
        {
            FizzBuzzer fizzBuzzer = new FizzBuzzer();
            for(int i = lowerRange; i <= upperRange; i++)
            {
                Console.WriteLine(fizzBuzzer.GetString(i));
            }
        }
    }
}
