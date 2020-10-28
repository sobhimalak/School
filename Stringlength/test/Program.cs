using System;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            // Pad left example  
            string frase = "c#";
            
            // Make string size 20. All right side will be spaces  
            string strSize = frase.PadRight(20);
            Console.WriteLine(strSize);



            // Pad right with a star  
            string star = frase.PadRight(20, '*');
           Console.WriteLine(star);
           

        }

    }
}


