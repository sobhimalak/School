using System;
using System.IO;
public class SearchLinesInFile
{
    public static void Main(string[] args)
    {
        string fileName = "input.txt";
        string[] lines = File.ReadAllLines(fileName);

        bool exit = false;
        do
        {
            string line = Console.ReadLine();

            if (line != "")
            {
                for (int i = 0; i < lines.Length; i++)
                {
                    if (lines[i].Contains(line))
                    {
                        Console.WriteLine(lines[i]);
                    }
                }
            }
            else
            {
                exit = true;
            }
        }
        while (!exit);
    }
}