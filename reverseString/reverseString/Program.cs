using System;

namespace reverseString
{
     class Program
    {
        static string Mirror(string name)
        {
            string reverse = name;
            string word = "";
            for (int i = 1; i <= reverse.Length; i++)
            {
                word += reverse[reverse.Length - i];
            }
            return word;
        }
        static void Main(string[] args)
        {
           
            Console.WriteLine(Mirror("Lexicon"));
            Console.WriteLine(Mirror("Foods"));
        }
    }
}