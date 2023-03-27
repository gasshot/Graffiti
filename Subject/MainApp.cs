using System;
using System.Collections.Generic;
using System.Linq;

namespace Subject
{

    class MainApp
    {
        static int[] CardNumber(int a)
        {
            int min = 1;
            int max = 13;
            int count = a;
            int[] cNArray = new int[count];
            Random cardnumber = new Random();

            for (int loop = 0; loop < count; loop++)
            {
                // 랜덤 값 생성
                int randNumber = cardnumber.Next(min, max);

                // 랜덤 값이 배열에 존재하면 loop를 1 감소
                if (cNArray.Contains(randNumber))
                {
                    loop--;
                }
                // 랜덤 값이 배열에 없으면 배열에 추가
                else
                {
                    cNArray[loop] = randNumber;
                }
            }
            return cNArray;
        }

        static int[] FigureNumber(int a)
        {
            int min = 1;
            int max = 4;
            int count = a;
            int[] fArray = new int[count];
            Random figurenum = new Random();
            for (int loop = 0; loop < count; loop++)
            {
                // 랜덤 값 생성
                int randNumber = figurenum.Next(min, max);
                fArray[loop] = randNumber;             
            }
            return fArray;
        }

        public string Merge(int a, int b)
        {
            string Majesty = "";
            List<string> figure = new List<string> { "Diamond", "Spade", "Clover", "Heart" };


            if (a > 10 || a == 1)
            {
                switch (a)
                {
                    case 1:
                        Majesty = "A";
                        break;
                    case 11:
                        Majesty = "J";
                        break;
                    case 12:
                        Majesty = "Q";
                        break;
                    case 13:
                        Majesty = "K";
                        break;
                }
            }
            else
            {
                Majesty = Convert.ToString(a);
            }

            string x = Majesty + " " + figure[b];
            return x;
        }

        static void Main(string[] args)
        {
            int y = 5;
            int z = 5;
            int[] k = CardNumber(z);
            int[] f = FigureNumber(y);
            
            for (int i = 0; i < z; i++)
            {
                Console.WriteLine(k[i]);
            }
            for (int i = 0; i < y; i++)
            {
                Console.WriteLine(f[i]);
            }

        }
    }
}
