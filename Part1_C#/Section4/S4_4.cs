namespace Part1_C_.Section4
{
    class Knight
    {
        // 필드 
        public int hp;
        public int attack;

        public Knight()
        {
            hp = 100;
            attack = 10;
            Console.WriteLine("생성자 호출!");
        }

        public Knight(int hp) : this() // : Knight()
        {
            this.hp = hp;
            Console.WriteLine("int생성자 호출!");
        }

        public Knight(int hp, int attack) // : this(hp) 
        {
            this.hp = hp;
            this.attack = attack;
            Console.WriteLine("int, int 생성자 호출!");
        }

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

    class Program
    {
        static void Main(string[] args)
        {
            Knight knight = new Knight(50, 5);
        }
    }
}