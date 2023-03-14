using System;
using System.Collections.Generic;
using System.Linq;

namespace p151_ex5
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
            

            var list = new List<int> { x, y, z };






            //Console.WriteLine($"입력하신 {x},{y},{z}중 최대값은 {}이며, 최소값은 {}입니다.");

            Console.WriteLine($"입력하신 {x},{y},{z}중 최대값은 {list.Max()}이며, 최소값은 {list.Min()}입니다.");

            //int max = Math.Max(x,y,z);

        }
    }
}
