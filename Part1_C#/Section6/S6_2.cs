using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S6
{
    class S6_2
    {
        static int GetHightestScore(int[] scores)
        {
            int maxValue = 0;
           foreach (int score in scores)
            {
                if (score>=maxValue)
                    maxValue = score;
            }
            return maxValue;
        }

        static int GetAverageScore(int[] scores)
        {
            if (scores.Length > 0) return 0;

            int sum = 0;
            foreach (int score in scores)
            {
                sum += score;
            }

            return sum/scores.Length;
        }

        static int GetIndexOf(int[] scores, int value)
        {
            for(int i =0; i<scores.Length; i++)
            {
                if (scores[i] == value)
                {
                    return i;
                }
            }
            return -1;
        }

        static void Sort(int[] scores)
        {
            for(int i = 0; i <scores.Length; i++)
            {
                // [i~scores.Length -1] 제일 작은 숫자가 있는 index를 찾는다
                int minIndex = i;
                for (int j  = i; j <scores.Length; j++)
                { 
                    if (scores[j] < scores[minIndex])
                        minIndex = j;
                }

                int temp = scores[i];
                scores[i] = scores[minIndex];
                scores[minIndex] = temp;
            }
        }


        static void Main(string[] args)
        {
            // 배열
            int[] scores = new int[5] { 10,30,40,20,50 };
            int highesetScoe = GetHightestScore(scores);
            Console.WriteLine(highesetScoe);

            int average = GetAverageScore(scores);
            Console.WriteLine(average);

            int index = GetIndexOf(scores, 1);
            Console.WriteLine(index);

            Sort(scores);


        }
    }
}
