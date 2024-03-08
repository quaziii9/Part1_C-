using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S7
{
    internal class S7_9
    {
        class Monster
        {
            public int Id { get; set; }
        }

        static Monster FindMonster(int id)
        {
            // for()
            // return monster;
            return null;
        }

        static int Find() {  return 0; }


        static void Main(string[] args)
        {
            // Nullable -> Null + able

            //Monster monster = FindMonster(101);
            //if(monster != null)
            //{

            //}

            // int? number = null;
            int? number = 5;


            int b = number ?? 0; // 아래 주석 처리한거를 이 한줄로
            Console.WriteLine(b);


            //if (number != null) 
            //{
            //    int a = number.Value;
            //    Console.WriteLine(a);
            //}

            //if (number.HasValue)
            //{
            //    int a = number.Value;
            //    Console.WriteLine(a);
            //}
            // int a = number; -> 에러
            //int a = number.Value;
            //Console.WriteLine(a);

            Monster monster = null;

            if (monster != null)
            {
                int monsterId = monster.Id;
            }

            // Nullable -> 형식에다가 ? 붙임
            // null 이라는 타입을 가질수도 있음
            // ?? 
            // ?. 
            int? id = monster?.Id; 

            //if (monster == null) id = null;
            //else id = monster.Id;
        }
    }
}
