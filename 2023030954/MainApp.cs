using System;

namespace _2023030954
{
    class SwapFun
    {
        public void Swap(ref int a, ref int b)
        {
            int temp = b;
            b = a;
            a = temp;
            Console.WriteLine($"{a}, {b}");
        }

    }

    class MainApp
    {
        static void Swaps(int t, int k)
        {
            int temp = k;
            k = t;
            t = temp;
            Console.WriteLine($"{t}, {k}");
        }

        static void Main(string[] args)
        {
            int x = 3;
            int y = 4;

            SwapFun swapFun = new SwapFun();
            swapFun.Swap(ref x, ref y);

            Swaps(x, y);
        }
    }

}
