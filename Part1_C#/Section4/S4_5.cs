namespace Part1_C_.Section4
{
    class Knight
    {
        // 필드 
        static public int counter = 1;    // 오로지 1개만 존재

        public int id;
        public int hp;
        public int attack;

        static public void Test() // Knight 클래스에 종속되기 때문에 유일성
        {
            // hp = 1;
            counter++;
            // 각각 개개인의 고유한 정보에 접근이 불가능 , 
            // static 안에서는 static 변수만 접근 가능
        }

        static public Knight CreateKnight()
        {
            // hp나 attack에 접근하기 위해서 새로운 객체, 인스턴스를 생성
            Knight knight = new Knight();
            knight.hp = 100;
            knight.attack = 1;
            return knight;
        }

        public Knight()
        {
            id = counter;
            counter++;
            hp = 100;
            attack = 10;
            Console.WriteLine("생성자 호출!");
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

    class s4_5
    {
        static void Main(string[] args)
        {
            Knight knight = Knight.CreateKnight();  // static
            knight.Move();  // 일반 샘플 객체가 있어야함

            // Console.WriteLine();            -> static타입

            // Random rand = new Random();     -> 샘플 사용 x static이 아님
            // rand.Next(100);
        }
    }
}

// static 정적이라는 키워드를 붙이면 붕어빵 틀에 종속적인 필드 또는 함수가 되는거고 ,
// static을 뺀 상태라면 객체 자체, 인스턴스에 종속적인 필드 또는 함수가 된다
// static을 붙였다고 해서 일반 인스턴스에 접근을 못하는건 아님

