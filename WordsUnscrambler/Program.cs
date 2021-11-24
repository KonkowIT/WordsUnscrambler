using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WordsUnscrambler
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = { "This is the first line", "This is the second line", "This is the third line" };
            File.WriteAllLines("MyFile.txt", lines);

            string[] fileContent = File.ReadAllLines("MyFile.txt");

            foreach (string line in File.ReadLines("MyFile.txt"))
            {
                Console.WriteLine(line);
            }

        }
    }
}
