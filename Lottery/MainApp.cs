using System;
using System.Linq;

namespace Lottery
{
    class MainApp
    {
        public static int[] RNumber(int a)
        {
            int min = 1;
            int max = 13;
            int count = a;
            int[] intArray = new int[count];
            Random rand = new Random();

            for (int loop = 0; loop < count; loop++)
            {
                // 랜덤 값 생성
                int randNumber = rand.Next(min, max);

                // 랜덤 값이 배열에 존재하면 loop를 1 감소
                if (intArray.Contains(randNumber))
                {
                    loop--;
                }
                // 랜덤 값이 배열에 없으면 배열에 추가
                else
                {
                    intArray[loop] = randNumber;
                }
            }
            return intArray;
        }

        static void Main(string[] args)
        {
            int z = 5;
            int[] k = RNumber(z);
            for (int i = 0; i < z; i++)
            {
                Console.WriteLine(k[i]);
            }
        }
    }
}
