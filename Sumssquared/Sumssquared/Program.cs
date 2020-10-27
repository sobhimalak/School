using System;

namespace Sumssquared
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("{0}+{0} = {1}", x, x * x);
        }
    }
}
