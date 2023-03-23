using System;

namespace Static
{

    //class AddPlus
    //{

    //    public void Add()
    //    {
    //        static int add = 0;
    //        Console.WriteLine(add++);
    //    }
    //}

    class MainApp
    {
        static int x;   //몬스터체력

        static void Add()
        {
            int a = 0;
            Console.WriteLine(a++);
        }

        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                //AddPlus add = new AddPlus();
                // Add();
                Console.WriteLine(i);
            }
        }
    }
}
