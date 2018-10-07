using System;

namespace palindrom
{
    class Program
    {
        static void Main(string[] args)
        {
          string input = Console.ReadLine();
          var sut = new PalindromChecker();
          var result = sut.IsPalindrom(input);
          Console.WriteLine(result);
        }
    }
}
