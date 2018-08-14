using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzz
{
    class FizzBuzzer
    {
        public string GetString(int i)
        {
            string outStr = "";
            if (i % 3 == 0)
            {
                outStr += "Fizz";
            }
            if (i % 5 == 0)
            {
                outStr += "Buzz";
            }
            if (outStr.Length == 0)
            {
                outStr = i.ToString();
            }
            return outStr;
        }        
    }
}
