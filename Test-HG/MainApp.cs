using System;

namespace Test_HG
{
    class MainApp
    {
        static void Main(string[] args)
        {
            Console.Write("짝수를 입력하세요. : ");
            string input =Console.ReadLine();
            bool chk = int.TryParse(input,out int i);
            if (chk != true || i % 2 != 0)
            {
                Console.WriteLine("짝수를 입력하세요. : ");
                return;
            }

            for (int c = 0; c < i +1; c++)
            {
                if (c < i / 2)
                {
                    for (int b = 0; b < c; b++)
                    {
                        Console.Write("o");
                    }
                    for (int s = 0; s < i + 1 - (2 * c); s++)
                    {
                        Console.Write("*");
                    }
                    for (int b = 0; b < c; b++)
                    {
                        Console.Write("o");
                    }
                    Console.WriteLine($" -{c}");    
                }
                if (c == i / 2)
                {
                    for (int b = 0; b < c; b++)
                    {
                        Console.Write("o");
                    }
                    for (int s = 0; s < i + 1 - (2 * c); s++)
                    {
                        Console.Write("*");
                    }
                    for (int b = 0; b < c; b++)
                    {
                        Console.Write("o");
                    }
                    Console.WriteLine($" -{c}");
                }
                if (c > i / 2 && c<=i) //6
                {
                    for (int b = 0; b < i-c; b++)
                    {
                        Console.Write("o");
                    }
                    for (int s = 0; s < 2*(c - i/2)+1; s++)
                    {
                        Console.Write("*");
                    }
                    for (int b = 0; b < i - c; b++)
                    {
                        Console.Write("o");
                    }
                    Console.WriteLine($" -{c}");
                }
            }
            Console.WriteLine($"{i+1}*{i+1} 2차원 모래시계");
            Console.WriteLine($"{i/2}라인은 모래시계 중심");
        }
    }
}
