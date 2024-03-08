namespace Part1_C_.Section4
{

    class Player
    {
        protected int hp;
        protected int attack;

        public virtual void Move()
        {
            Console.WriteLine("Player 이동!");
        }
    }
    class Knight : Player
    {
        public override void Move()
        {
            base.Move();
            Console.WriteLine("Knight 이동!");
        }
    }

    class SuperKnight : Knight
    {

    }



    class Mage : Player
    {
        public int mp;

        public override void Move()
        {
            Console.WriteLine("Mage 이동!");
        }
    }




    internal class S4_9
    {
        static void EnterGame(Player player)
        {
            player.Move();
            Mage mage = player as Mage;
            if (mage != null)
            {
                mage.mp = 10;

            }

        }

        static void Main(string[] args)
        {
            Knight knight = new Knight();
            Mage mage = new Mage();



            EnterGame(mage);
        }
    }
}
