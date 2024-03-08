using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part1_C_.Section4
{
    // 객체(OOP Object Oriented Programming)

    // Knight
    // 속성 : hp, attack, pos
    // 기능 : Move, Attack, Die

    // Ref 참조
    class Knight
    {
        public int hp;
        public int attack;

        public Knight Clone()
        {
            Knight knight = new Knight();
            knight.hp = hp;
            knight.attack = attack;
            return knight;
        }

        public void Move()
        {
            Console.WriteLine("Knight Move");
        }

        public void Attack()
        {
            Console.WriteLine("Knight Attack");
        }
    }

    // Copy 복사
    struct Mage
    {
        public int hp;
        public int attack;
    }

    class OOP
    {
        static void KillMage(Mage mage)
        {
            mage.hp = 0;
        }

        static void KillKnight(Knight knight)
        {
            knight.hp = 0;
        }


        static void Main(string[] args)
        {
            Mage mage;
            mage.hp = 100;
            mage.attack = 50;
            // KillMage(mage);

            Mage mage2 = mage;
            mage2.hp = 0;

            Knight knight = new Knight(); // 클래스를 만들면 실제로 생성
            // Knight knight = null -> 존재하지 않는 객체 , 크래쉬
            knight.hp = 100;
            knight.attack = 10;

            //  Knight knighg2 = new Knight();
            Knight knight2 = knight.Clone(); // deep copy
            knight2.hp = 0;

            //knight2.hp = knight.hp;
            //knight2.attack = knight.attack;
            // knight.Move();
            // knight.Attack();

        }
    }
}
