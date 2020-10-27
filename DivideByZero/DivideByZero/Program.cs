using System;

namespace DivideByZero
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());

            try
            {
                Console.WriteLine("{0}/{1}= {2}", x, y, x / y);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Cannot be divided by Zero");
            }

        }
    }
}
