using System;


namespace _20230314
{
    class MainApp
    {
        static void Main(string[] args)
        {
            Console.Write("숫자를 입력하세요. : ");
            string input = Console.ReadLine();
            int output = Convert.ToInt32(input);
            string a;

            a = output >= 50 ? "이상의" : "미만의";


            Console.WriteLine($"입력하신 숫자 {output}는(은) 50{a} 수 입니다.");
        }
    }
}
