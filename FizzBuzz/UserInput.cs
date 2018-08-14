using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzz
{
    class UserInput
    {
        public int GetInput()
        {
            string inStr = "";
            int range = 0;
            bool valid = false;

            while (!valid)
            {
                Console.Write("Enter an integer: ");
                inStr = Console.ReadLine();
                try
                {
                    range = Convert.ToInt32(inStr);
                    valid = true;
                }
                catch
                {
                    Console.WriteLine("Invalid value - must be a whole number.");
                }
            }
            return range;
        }
    }
}
