using System;
using System.Linq;

namespace palindrom
{
    public class PalindromChecker
    {
        // Create method
        // << input: string
        // >> result: bool
        public bool IsPalindrom(string input)
        {
            var reversedInput = string.Join("", input.Reverse());


            if (input == reversedInput)
            {

                return true;
            }

            else
            {
                return false;
            };





        }
    }
}