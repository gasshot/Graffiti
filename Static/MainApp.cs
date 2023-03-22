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
        static int x;

        public void Add()
        {
            static int a = 0;
            Console.WriteLine(a++);
        }

        public void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                //AddPlus add = new AddPlus();
                Add();
            }
        }
    }
}
