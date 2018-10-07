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



        public bool IsMultiplePalindrom(int input,int input2)
        {
            
            var resultmultiple = input*input2;
            var stringresultmultiple = resultmultiple.ToString();
            
            
            var reversedInput = string.Join("", stringresultmultiple.Reverse());


            if (stringresultmultiple == reversedInput)
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