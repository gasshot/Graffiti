using System;


namespace ForFor
{
    class MainApp
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*");
            Console.WriteLine("**");
            Console.WriteLine("***");
            Console.WriteLine("****");
            Console.WriteLine("*****");
            Console.WriteLine("");

            for (int x = 0; x < 5; x++)
            {
                for (int y = 0; y <= x; y++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }
    }
}
