using System;

namespace Hourglass
{
    class MainApp
    {
        static void Main(string[] args)
        {
            Console.Write("원하는 짝수를 입력하세요. : ");
            string input = Console.ReadLine();
            bool chk = int.TryParse(input, out int i);

            if ((i % 2) != 0 || chk != true)
            {
                Console.WriteLine("짝수를 입력하세요.");
                return;
            }
            for (int c = 0; c <= i; c++)
            {
                if (c <= (i / 2)) // 첫라인~중심라인
                {
                    for (int t = 0; t < c; t++)
                    {
                        Console.Write("o");
                    }
                    for (int s = c; s < i - c + 1; s++)
                    {
                        Console.Write("*");
                    }
                    for (int b = i - c + 1; b < i + 1 && b <= i + 1; b++)
                    {
                        Console.Write("o");
                    }
                    Console.WriteLine($" - {c+1}");
                }
                else if (c >= (i / 2) + 1 && c <= i) // 중심라인 + 1 ~ 마지막 라인
                {
                    for (int t = 0; t < i - c; t++)
                    {
                        Console.Write("o");
                    }
                    for (int s = c; s >= i - c && s >= -1; s--)
                    {
                        Console.Write("*");
                    }
                    for (int b = i - c; b <= i - c && b > 0; b--)
                    {
                        Console.Write("o");
                    }
                    Console.WriteLine($" - {c + 1}");
                }
            }
            Console.WriteLine($"\n{i + 1} * {i + 1} 2차원 모래시계.");
            Console.WriteLine($"{(i / 2) + 1}번 라인은 모래시계 중심.");
        }
    }
}
