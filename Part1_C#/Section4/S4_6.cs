namespace Part1_C_.Section4
{
    // OOP(상속성)

    class Player    // 부모 / 기반 클래스
    {
        static public int counter = 1;
        public int id;
        public int hp;
        public int attack;

        public void Move()
        {
            Console.WriteLine("player Move");
        }

        public void Attack()
        {
            Console.WriteLine("player Attack");
        }

        public Player()
        {
            Console.WriteLine("player 생성자 호출!");
        }

        public Player(int hp)
        {
            this.hp = hp;
            Console.WriteLine("player hp 생성자 호출!");
        }

    }

    class Mage : Player
    {


    }

    class Archer : Player
    {

    }


    class Knight : Player   // 자식 / 파생 클래스
    {
        int c;
        public Knight() : base(100) //Player(100)
        {
            c = 10;
            base.hp = 100; // base : 부모의
            Console.WriteLine("Knight 생성자 호출!");
        }


    }

    class S4_6
    {
        static void Main(string[] args)
        {
            Knight knight = new Knight();
            knight.Move();
            knight.Attack();

        }
    }

}
