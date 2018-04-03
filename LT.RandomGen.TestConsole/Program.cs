using System;

namespace LT.RandomGen.TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(i.ToString()+RandomGenerator.GenerateText(Data.Kinds.Things, 0,Data.Languages.Italian));
            }
            Console.ReadKey();
        }
    }
}
