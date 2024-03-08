using System;
using System.Collections.Generic;


namespace S6
{
    internal class S6_4
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            arr[0] = 1;

            // List <- 동적 배열 [ 0 1 999 2 3 4 ]
            List<int> list = new List<int>();
            for (int i = 0; i<5;  i++)
            {
                list.Add(i);
            }

            // 삽입 삭제
            //  list.Insert(2, 999);
            // bool success = list.Remove(3); // 3이 여러개면 처음 만난애만 삭제
            list.RemoveAt(0); // 0번째 숫자 삭제
            list.Clear(); // 전체삭제

            for(int i =0; i<list.Count; i++)
                Console.WriteLine(list[i]);

            foreach(int num in list)
            {
                Console.WriteLine(num);
            }
        }
    }
}
