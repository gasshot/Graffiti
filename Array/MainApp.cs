using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{

    class MainApp
    {
        static void Print(int value)
        {
            Console.Write($"{value}, ");
        }

        static void Main(string[] args)
        {

            int[] arr = new int[] { 88, 74, 62, 90, 14, 55 };
            //arr[0] = 88;
            //arr[1] = 74;
            //arr[2] = 62;
            //arr[3] = 90;
            //arr[4] = 14;
            //arr[5] = 55;

            int sum = 0;
            sum = arr.Sum();
            Console.WriteLine(sum);
            sum = 0;
            foreach (int a in arr)
            {
                sum += a;
            }
            Console.WriteLine(sum);


            foreach (int a in arr)
            {
                Console.Write($"{a}, ");
            }
            Console.WriteLine();

            Array.Sort(arr);
            Array.ForEach<int>(arr, new Action<int>(Print));
            Console.WriteLine();
            int index = Array.IndexOf<int>(arr, arr[0]);
            int value = arr[0];
            if (index > -1)
            {
                Console.WriteLine("{0} found in the array at index {1}", value, index);
            }
            else
            {
                Console.WriteLine("Value not found");
            }
            int newSize = 10;
            Array.Resize<int>(ref arr, newSize);
            foreach (int a in arr)
            {
                Console.Write($"{a}, ");
            }
        }
    }
}
