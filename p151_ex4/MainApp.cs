using System;

namespace p151_ex4
{
    class MainApp
    {
        static void Main(string[] args)
        {
            Console.Write("정수 한개를 입력하세요. : ");
            string input = Console.ReadLine();
            //int output = int.Parse(input);
            bool chk = int.TryParse(input, out int output);
            if (!chk)
            {
                Console.WriteLine("정수를 입력하세요.");
                return;
            }

            string a;

            if (input == "0")
            {
                Console.WriteLine("0은 모든 수의 배수입니다.");
                return;
            }

            a = output % 3 == 0 ? "입" : "가 아닙";

            Console.WriteLine($"입력하신 정수 {output}는(은) 3의 배수{a}니다.");
        }
    }
}
