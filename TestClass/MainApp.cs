using System;

namespace TestClass
{
    public class TestClass
    {
        public void Divider(int a, int b, out int quotient, out int reminder)
        {
            quotient = a / b;
            reminder = a % b;
        }
        public int Fibonacci(int c)
        {
            if (c < 2)
            {
                return c;
            }
            int a = c;
            return Fibonacci(a - 1) + Fibonacci(a - 2);
        }
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            int x = 5;
            int y = 3;
            int z = 10;

            TestClass show = new TestClass();
            show.Divider(x, y, out int i, out int f);

            Console.WriteLine(i);
            Console.WriteLine(f);
            Console.WriteLine(i + f);

            TestClass fibo = new TestClass();
            Console.WriteLine(fibo.Fibonacci(z));
        }
    }
}
