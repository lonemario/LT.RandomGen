using System;

namespace LT.RandomGen.TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(RandomGenerator.GenerateParagraphs(Data.Kinds.Animals,5));
            Console.ReadKey();
        }
    }
}
