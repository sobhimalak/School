using System;

namespace getMax
{
    class Program
    {
          static int number;

            static void GetMax(int first, int second)
            {
                if (first > second) number = first;
                else number = second;
            }

            static void Main(string[] args)
            {
                Console.Write("Enter first number: ");
                number = int.Parse(Console.ReadLine());
                Console.Write("Enter second number: ");
                int number2 = int.Parse(Console.ReadLine());

                GetMax(number, number2);
            {
                Console.WriteLine("The largets number is {0}", number);
            }
            }
    }
}
