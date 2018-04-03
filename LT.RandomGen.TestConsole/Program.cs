using System;

namespace LT.RandomGen.TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(RandomGenerator.GenerateText(Data.Kinds.Things, 10,Data.Languages.Italian));
            }
            Console.ReadKey();
        }
    }
}
