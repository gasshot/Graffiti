using System;

namespace Diamond2
{
    class MainApp
    {

        static void Main(string[] args)
        {
            Console.Write("원하는 짝수를 입력하세요. : ");
            string input = Console.ReadLine();
            bool chk = int.TryParse(input, out int o);
            if ((o % 2) != 0 || chk != true)
            {
                Console.WriteLine("짝수를 입력하세요.");
                return;
            }
            for (int c = 0; c < o + 1; c++) // 01234
            {
                if (c < (o / 2))
                {
                    for (int b = 0; b < o / 2 - c; b++)
                    {
                        Console.Write("o");
                    }
                    for (int s = 0; s < 2 * c + 1; s++)
                    {
                        Console.Write("*");
                    }
                    for (int f = 0; f < o / 2 - c; f++)
                    {
                        Console.Write("o");
                    }
                    Console.WriteLine($" - {c + 1}");
                }
                else if (c == (o / 2))
                {
                    for (int s = 0; s < o + 1; s++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine($" - {c + 1}");
                }  // 3
                else if (c > (o / 2) && c <= o)
                {
                    for (int b = 0; b < c - (o / 2); b++)
                    {
                        Console.Write("o");
                    }
                    for (int s = 0; s < 2 * (o - c) + 1; s++)
                    {
                        Console.Write("*");
                    }
                    for (int f = 0; f < c - (o / 2); f++)
                    {
                        Console.Write("o");
                    }
                    Console.WriteLine($" - {c + 1}");
                }
            }
            Console.WriteLine($"\n{o + 1} * {o + 1} 2차원 모래시계.");
            Console.WriteLine($"{(o / 2) + 1}번 라인은 모래시계 중심.");
        }
    }
}
