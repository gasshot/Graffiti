using System;

namespace Diamond
{
    class MainApp
    {
        static void Main(string[] args)
        {
            for (int x = 0; x < 5; x++)
            {
                for (int y = 0; y < 4 - x; y++)
                {
                    Console.Write("^");
                }
                for (int z = 0; z < x; z++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();

            }
        }
    }
}