using System;

namespace LetterLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a set of characters and hit enter");
            var result = "";
            var cloner = 0;
            var charInput = Console.ReadLine();
            
            foreach (char c in charInput)
                {
                    cloner++;
                    result += new string(c, cloner) + ", ";
                }
            
            Console.WriteLine(result);

            Console.ReadKey();
        }
    }
}
