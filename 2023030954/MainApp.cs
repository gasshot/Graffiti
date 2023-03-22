using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2023030954
{
    class SwapFun
    {
         public void Swap(ref int a, ref int b)
        {
            int temp = a;
            b = a;
            a = temp;
        }

    }

    class MainApp
    {
        static void Swap(ref int t, ref int k)
        {
            int temp = t;
            k = t;
            t = temp;
        }

        static void Main(string[] args)
        {
            int x = 3;
            int y = 4;

            //SwapFun swapFun = new SwapFun();
            //swapFun.Swap(ref x,ref y);
            
            MainApp.Swap(ref x, ref y);
        }
    }

}
