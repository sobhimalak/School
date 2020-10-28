using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace File_Example
{
    class Program
    {
        public void WriteOperation()
        {
            FileStream fs = new FileStream("d:\\test.txt", FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter w = new StreamWriter(fs);
            w.WriteLine(Console.ReadLine());
            w.Close();
            fs.Close();
        }
        public void ReadOperation()
        {
            FileStream fs = new FileStream("d:\\test.txt", FileMode.Open, FileAccess.Read);
            StreamReader r = new StreamReader(fs);
            int counter = 0;
            while (!r.EndOfStream)
            {
                Console.WriteLine(r.ReadLine());
                counter++;
            }
            Console.WriteLine(counter);
            r.Close();
            fs.Close();
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            p.WriteOperation();
            p.ReadOperation();
        }
    }
}
