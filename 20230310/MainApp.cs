using System;

namespace _20230310
{
    class MainApp
    {

        static void Main(string[] args)
        {
            Console.Write("원하는 짝수를 입력하세요. : ");
            string input = Console.ReadLine();
            bool chk = int.TryParse(input, out int o);

            for (int c = 0; c < o + 1; c++) // 01234
            {
                for (int b = 0; b <= o - c; b++)
                {
                    Console.Write("o");
                }
                
                for (int s = 0; s < 2*c + 1; s++)
                {
                    Console.Write("*");
                }

                for (int b = 0; b <= o - c; b++)
                {
                    Console.Write("o");
                }

                Console.WriteLine();
            }
        }
    }
}

