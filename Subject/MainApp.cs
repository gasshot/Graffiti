using System;
using System.Collections.Generic;

namespace Subject
{

    class MainApp
    {
        public static void CardMaker(int a)
        {
            int cardnumber = 13;
            int[] card = new int[cardnumber];
            for (int i = 0; i < cardnumber; i++)
            {
                card[i] = i + 1;
                //Console.WriteLine(card[i]);
            }
            List<int[]> deck = new List<int[]> { };
            int[] cards = new int[13];
            Console.WriteLine(deck);
        }

        static void Main(string[] args)
        {
            int x = 0;
            int round = 7;
            int[] playercard = new int[round];
            int[] computercard = new int[round];

            CardMaker(x);

        }
    }
}
