using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subject02
{
    class MainApp
    {
        //public static string[] CardMaster()
        //{
        //    string[] card = new string[52];        //1~13/14~26/27~39/40~52
        //    string figure = "";
        //    var number = 0;
        //    string[] cardmaster = card;
        //    for (int i = 0; i < 52; i++)
        //    {
        //        if (i < 13)
        //        {
        //            figure = "Clover";
        //            number = i+1;

        //            card [i]=(Convert.ToString(number)+" "+figure); 
        //        }
        //        else if (13 <= i && i < 26)
        //        {
        //            figure = "Heart";
        //            number = i + 1 - 13;
        //            card[i] = (Convert.ToString(number) + " " + figure);
        //        }
        //        else if (26 <= i && i < 39)
        //        {
        //            figure = "Spade";
        //            number = i + 1 - 26;
        //            card[i] = (Convert.ToString(number) + " " + figure);
        //        }
        //        else
        //        {
        //            figure = "Diamond";
        //            number = i + 1 - 39;
        //            card[i] = (Convert.ToString(number) + " " + figure);
        //        }
        //    }

        //    return cardmaster;
        //}

        static void Main(string[] args)
        {
            int[] cardn = new int[52];        //1~13/14~26/27~39/40~52
            string figure = "";
            int number = 0;
            string[] cardf = new string[52];
            for (int i = 0; i < 52; i++)
            {
                //if (i < 13)
                //{
                    figure = "Clover";
                    number = i + 1;

                    //card[i] = (Convert.ToString(number) + " " + figure);
                //}
                if (13 <= i && i < 26)
                {
                    figure = "Heart";
                    number = i + 1 - 13;
                    //card[i] = (Convert.ToString(number) + " " + figure);
                }
                else if (26 <= i && i < 39)
                {
                    figure = "Spade";
                    number = i + 1 - 26;
                    //card[i] = (Convert.ToString(number) + " " + figure);
                }
                else if(39<=i&&i<52)
                {
                    figure = "Diamond";
                    number = i + 1 - 39;
                    //card[i] = (Convert.ToString(number) + " " + figure);
                }
                cardn[i] = number;
                cardf[i] = figure;
                //Console.WriteLine(card[i]+$"-{i+1}");
            }

            Random cardnumber = new Random();
            int[] cNArray = new int[5];

            for (int loop = 0; loop < 5; loop++)
            {
                // 랜덤 값 생성
                int randNumber = cardnumber.Next(0, 51);

                // 랜덤 값이 배열에 존재하면 loop를 1 감소
                if (cNArray.Contains(randNumber))
                {
                    loop--;
                    continue;
                }
                // 랜덤 값이 배열에 없으면 배열에 추가
                else
                {
                    cNArray[loop] = randNumber;
                }

                Console.WriteLine(cardn[randNumber] +" "+ cardf[randNumber]);
            }
        }
    }
}
