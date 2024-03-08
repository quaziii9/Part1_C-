using System;

namespace Part1_C_.Section4
{
    class Player
    {
        protected int hp;
        protected int attack;
    }
    class Knight : Player
    {

    }

    class Mage : Player
    {
        public int mp;
    }

    class S4_8
    {
        // null 응용
        static Player FindPlayeById(int id)
        {
            // id에 해당하는 플레이어를 탐색
            // 못찾으면
            return null;


        }

        static void EnterGame(Player player)
        {


            //1. 
            //bool isMage = (player is Mage);
            //if (isMage)
            //{
            //    Mage mage = (Mage)player;
            //    mage.mp = 10;
            //}

            // 2. 보통 as문법 
            // mage로 형변환이 가능한지 체크해서 가능하면 일반주소가 들어가고 , 체크가 불가능 하면 null이 들어가서 판단
            //Mage mage = (player as Mage);
            //if (mage != null)   // null : '없음' , 참조하고 있는 타입이 아무것도 없음
            //{
            //    mage.mp = 10;
            //}

            // Enter 기사일때 mage를 받으면 뻗음
            Mage mage = (Mage)player;
            mage.mp = 10; // -> crash
        }


        static void Main(string[] args)
        {
            Knight knight = new Knight();
            Mage mage = new Mage();

            // Mage 타입  -> Player 타입
            // Player 타입 -> Mage 타입 ? 
            // Player magePlayer = mage; // mage를 player로
            //Mage mage2 = (Mage)magePlayer; // player를 다시 mage 타입으로

            // 자식 -> 부모 로 변환
            // 부모 -> 자식 로 변환은 케이스 바이 케이스(크로스체크)
            // ex) entergame에 knight이 들어갓는데 entergame에서 mage를 받으면 ? 실행했을시 carsh
            // 

            EnterGame(knight);  // 
                                //EnterGame(mage);
        }
    }
}
