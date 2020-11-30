using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HowManySymbolsInText
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("input string:");
                string inputText = Console.ReadLine();
                Console.WriteLine(inputText.Length);
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
