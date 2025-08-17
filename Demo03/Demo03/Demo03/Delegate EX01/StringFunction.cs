using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo03.Delegate_EX01
{
    internal static class StringFunction
    {
        // Method to calculate the Count of Upper Case Characters in a String:
        public static int CountUpperCase(string input)
        {
            int Counter = 0;
            if (!string.IsNullOrEmpty(input))
            {
                foreach (char character in input)
                {
                    if (char.IsUpper(character))
                    {
                        Counter++;
                    }
                }
            }
            return Counter;
        }

        // Method to calculate the Count of Lower Case Characters in a String:
        public static int CountLowerCase(string input)
        {
            int Counter = 0;
            if (!string.IsNullOrEmpty(input))
            {
                foreach (char character in input)
                {
                    if (char.IsLower(character))
                    {
                        Counter++;
                    }
                }
            }
            return Counter;
        }
    }
}
