using System;

namespace DivisionAndDivisionModule
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(x / y);
            Console.WriteLine(x % y);
            Console.ReadLine();
        }
    }
}
