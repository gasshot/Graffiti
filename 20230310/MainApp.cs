using System;

namespace _20230310
{
    class MainApp
    {
        
        static void Main(string[] args)
        {

            string input1 = Console.ReadLine();
            string input2 = Console.ReadLine();

            int a = int.Parse(input1);
            int b = int.Parse(input2); ;

            Console.WriteLine($"a > 0 && b < 0 : {a > 0 && b < 0}");
            Console.WriteLine($"\na > 0 || b < 0 : {a > 0 || b < 0}");


        }
    }
}
