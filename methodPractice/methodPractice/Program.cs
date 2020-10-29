using System;

namespace methodPractice
{
    class Program
    {
       static void Main(string[] args)
        {
            Console.WriteLine("What is the name of the Band ?");
            string name = Console.ReadLine();
        }
            void AnnounceBand(string bandName)
        {
            Console.WriteLine("Welcome" + bandName + "  to the stage.");
        }
    }
}
