using System;

namespace _20230310
{
    class MainApp
    {

        static void Main(string[] args)
        {
            Console.Write("원하는 짝수를 입력하세요. : ");
            string input = Console.ReadLine();
            bool chk = int.TryParse(input, out int i);

            for (int c = 0; c < i + 1; c++) // 01234
            {
                if (c < i / 2)
                {
                    for (int b = 0; b < i / 2 - c; b++)
                    {
                        Console.Write("o");
                    }

                    for (int s = 0; s < 2 * c + 1; s++)
                    {
                        Console.Write("*");
                    }

                    for (int b = 0; b < i / 2 - c; b++)
                    {
                        Console.Write("o");
                    }
                    Console.WriteLine();
                }
                if (c == i / 2)
                {
                    for (int b = 0; b < i / 2 - c; b++)
                    {
                        Console.Write("o");
                    }

                    for (int s = 0; s < 2 * c + 1; s++)
                    {
                        Console.Write("*");
                    }

                    for (int b = 0; b < i / 2 - c; b++)
                    {
                        Console.Write("o");
                    }
                    Console.WriteLine();
                }
                if (c > i / 2 && c < i + 1)
                {
                    for (int b = 0; b < c - i / 2; b++)
                    {
                        Console.Write("o");
                    }

                    for (int s = 0; s < 2 * (i - c) + 1; s++)
                    {
                        Console.Write("*");
                    }

                    for (int b = 0; b < c - i / 2; b++)
                    {
                        Console.Write("o");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}

