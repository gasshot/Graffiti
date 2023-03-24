using System;

namespace p216_ex1
{
    class MainApp
    {
        static float Sqaure(float a)
        {
            return a * a;
        }


        static void Main(string[] args)
        {
            Console.Write("수를 입력하세요. : ");
            string input = Console.ReadLine();
            bool chk = float.TryParse(input, out float o);
            if (chk != true)
            {
                Console.WriteLine("수를 입력하세요. : ");
                return;
            }
            Console.WriteLine($"결과 : {Sqaure(o)}");
        }
    }
}
