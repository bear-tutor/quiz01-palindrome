using System;

namespace palindrom
{
    class Program
    {
        static void Main(string[] args)
        {
        // string input = (Console.ReadLine());
        //   var sut = new PalindromChecker();
        //   var result = sut.IsPalindrom(input);
        //   Console.WriteLine(result);



          int input = int.Parse(Console.ReadLine());
          int input2 = int.Parse(Console.ReadLine());
          var sut = new PalindromChecker();
          var result = sut.IsMultiplePalindrom(input,input2);
          Console.WriteLine(result);
        }
    }
}
