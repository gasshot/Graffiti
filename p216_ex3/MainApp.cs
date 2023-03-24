using System;

namespace p216_ex3
{
    class MainApp
    {
        static int Plus(int a, int b)
        {
            return a + b;
        }
        static double Plus(double a, double b)
        {
            return a + b;
        }

        static void Main(string[] args)
        {
            int x = 3;
            int y = 4;
            double i = 2.4;
            double j = 3.1;
      
            Console.WriteLine($"{x}+{y} = {Plus(x,y)}");
            Console.WriteLine($"{i}+{j} = {Plus(i,j)}");
        }
    }
}
