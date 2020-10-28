using System;
using System.Collections.Generic;
using System.Collections;

namespace stackrevese
{
    class Program
    {
        static void Main(string[] args)
        {

            var text = "Learning Csharp";
            
            Console.WriteLine("Regular :  " + text);
            

            var stack = new Stack ();

            foreach (char c in text)
                stack.Push(c);

            text = string.Empty;
          

            while (stack.Count > 0)
                text += stack.Pop();

            Console.WriteLine("Backwards :  " + text);
            Console.ReadLine();



        }
    }
}
