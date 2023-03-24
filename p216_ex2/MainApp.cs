using System;

namespace p216_ex2
{
    class MainApp
    {
        public static void Mean(double a, double b, double c, double d, double e, ref double mean) // ref
        {
            mean = (a + b + c + d + e) / 5;
        }


        static void Main(string[] args)
        {
            double mean = 0;
            Mean(1, 2, 3, 4, 5, ref mean);  // ref

            Console.WriteLine("평균 : {0}", mean);
        }
    }
}
