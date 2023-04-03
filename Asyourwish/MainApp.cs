using System;

namespace Asyourwish
{
    // 베이스 클래스
    public class Human
    {
        public string Name;
        public int Age;
    }

    // 파생클래스
    public class Clark : Human
    {
        public void HowOld()
        {
            // 베이스 클래스의 Age 속성 사용
            this.Name = "Clark";
            this.Age = 22;
            Console.WriteLine("{0}의 나이: {1}", this.Name, this.Age);
        }
    }

    // 파생클래스
    public class Ramda : Human
    {
        public void Fly()
        {
            this.Name = "Ramda";
            Console.WriteLine("{0}가 날다.", this.Name);
        }
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            Clark clark = new Clark();
            clark.HowOld();
            Ramda ramda = new Ramda();
            ramda.Fly();
        }

    }
}
