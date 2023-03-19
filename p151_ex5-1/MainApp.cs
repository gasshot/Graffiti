using System;

namespace p151_ex5_1
{
    class MainApp
    {
        static void Main(string[] args)
        {
            Console.Write("세개의 정수 중 첫번째 정수를 입력해주세요. : ");
            string a = Console.ReadLine();
            Console.Write("세개의 정수 중 두번째 정수를 입력해주세요. : ");
            string b = Console.ReadLine();
            Console.Write("세개의 정수 중 세번째 정수를 입력해주세요. : ");
            string c = Console.ReadLine();

            int x = int.Parse(a);
            int y = int.Parse(b);
            int z = int.Parse(c);
            int max = 0;
            int min = 0;

            if (x >= y)
            {
                if (y >= z)
                {
                    max = x;
                    min = z;
                }
                else if (z >= x)
                {
                    max = z;
                    min = y;
                }
                else if (x >= z && z >= y)
                {
                    max = x;
                    min = y;
                }
            }

            if (y >= x)
            {
                if (x >= z)
                {
                    max = y;
                    min = z;
                }
                else if (z >= y)
                {
                    max = z;
                    min = x;
                }
                else if (y >= z && z >= x)
                {
                    max = y;
                    min = x;
                }
            }

            Console.WriteLine($"입력하신 {x},{y},{z}중 최대값은 {max}이며, 최소값은 {min}입니다.");
            Console.WriteLine($"입력하신 {x},{y},{z}의 합계는 {x + y + z}이며, 평균값은 {(x + y + z) / 3}입니다.");
        }

    }
}
