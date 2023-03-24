using System;

namespace _20230310
{
    class Calculator
    {
        public void Divider(int a, int b, ref int quotient, ref int reminder)
        {
            quotient = a / b;
            reminder = a % b;
        }
    }

    class MainApp
    {

        static void Main(string[] args)
        {
            Console.Write("첫번째 정수 :");
            string input = Console.ReadLine();
            Console.Write("두번째 정수 :");
            string byin = Console.ReadLine();

            int output = Convert.ToInt32(input);
            int byout = Convert.ToInt32(byin);
            int x = output;
            int y = byout;
            int q = 0;
            int r = 0;

            Calculator cal = new Calculator();
            cal.Divider(x, y, ref q, ref r);

            Console.WriteLine($"{x}/{y}의 몫 : {q}, 나머지 : {r}");
        }
    }
}

