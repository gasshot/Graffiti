using System;

namespace _202303291953
{
    class Human
    {
        public int age;
        public float height;

        public Human(int a, float b) // 생성자
        {
            age = a;
            height = b;
        }
        public void GlowUp()
        {
            Console.WriteLine("8 years later~");
            age = this.age + 8;
            height = this.height +0.5f;
        }
      
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            int k = 10;
            float h = 1.3f; 
            Human clark = new Human(k,h);
            Console.WriteLine($"이름: clark, 나이: {clark.age}, 키: {clark.height}m");
            clark.GlowUp();
            Console.WriteLine($"이름: clark, 나이: {clark.age}, 키: {clark.height}m");
        }
    }
}
