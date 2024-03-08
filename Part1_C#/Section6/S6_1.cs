using System;

namespace S6
{
     class S6_1
    {
        static void Main(string[] args)
        {
            // 배열
            int a;
            int[] scores = new int[5] { 10, 20, 30, 40, 50};
            int[] scores2 = scores;

            scores2[0] = 9999;
            // 0 1 2 3 4
            //scores[0] = 10;
            //scores[1] = 20;
            //scores[2] = 30;
            //scores[3] = 40;
            //scores[4] = 50;

            for (int i =0; i < 5; i++)
            {
                Console.WriteLine(scores[i]);
            }

            foreach (int score in scores)
            { Console.WriteLine(score); }
        }
    }
}
