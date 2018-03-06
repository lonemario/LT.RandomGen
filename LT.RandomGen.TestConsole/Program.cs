using System;

namespace LT.RandomGen.TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(RandomGenerator.GenerateParagraphs(Data.Kinds.Things,100,Data.Languages.Italian));
            Console.ReadKey();
        }
    }
}
