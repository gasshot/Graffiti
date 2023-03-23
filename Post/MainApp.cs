using System;

namespace Post
{
    class MainApp
    {
        static int x = 100;
        static int y = 223;
        static int z = 564;
        int e =1253;

        //변수를 선언하고 처음으로 값을 저장하는 것을 '변수의 초기화'라고 한다.
        //멤버변수는 초기화를 하지 않아도 자동적으로 변수의 자료형에 맞는 기본값으로 초기화가 이루어지지만 지역변수는 사용하기 전에 반드시 초기화해야 한다.

        //정적(Static) 속성 및 필드는 위의 static 메서드와 같이[클래스명.속성명]과 같이 사용하며, 다음 예와 같이 static을 앞에 붙여 정의한다.
        //클래스 내의 Non-static 필드들은 클래스 인스턴트를 생성할 때마다 메모리에 매번 새로 생성되게 되는 반면, static 필드는 프로그램 
        //실행 후 해당 클래스가 처음으로 사용될 때 한번 초기화되어 계속 동일한 메모리를 사용하게 된다.
        //정적(Static) 변수는 프로그램이 시작될 때 생성 및 초기화 되고 프로그램이 끝날 때 사라진다. 
        public int Star()
        {
            int a=356;
            return a+e;
        }
      
        static void Main(string[] args)
        {
            MainApp q = new MainApp();

            int a = x;
            int b = 30;
            int c = a + b;

            Console.WriteLine(c); // 130

            x = y + z;
            Console.WriteLine(x); //787
            MainApp k = new MainApp();

            Console.WriteLine(k.Star());
        }
    }
}
