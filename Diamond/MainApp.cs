using System;

namespace Diamond
{
    class MainApp
    {
        static void Main(string[] args)
        {
            //int c : Circle
            //int b : Blank
            //int s : Star

            for (int c = 0; c < 11 ; c++)
            {
                if (c < 6)
                {
                    for (int b = -2; b < 5 - c; b++)
                {
                    Console.Write(" ");
                }

                    for (int s = 0; s < 1 + (2 * c); s++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
                if (6 <= c)
                {
                    for (int b = -2; b < c - 5; b++)
                    {
                        Console.Write(" ");
                    }

                    for (int s = 0; s < 2*(10-c)+1; s++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }

            }
        }

    }
}

