
using System.Security.Cryptography.X509Certificates;

namespace S7
{
   
    internal class S7_2
    {
        abstract class Monster
        {
            public abstract void Shout();
        }

        interface IFlyable
        {
            void Fly();
        }

        class FlyableOrc : Orc, IFlyable
        {
            public void Fly()
            { }


        }

        class Orc : Monster
        {
            public override void Shout()
            {
                Console.WriteLine("록타르 오가르!");
            }
        }

        static void DoFly(IFlyable flyable)
        {
            flyable.Fly();
        }

        //class Skeleton : Monster
        //{
        //    public override void Shout()
        //    {
        //        Console.WriteLine("!!!");

        //    }
        //}

        static void Main(string[] args) 
        
        {
            IFlyable flyable = new FlyableOrc();
            DoFly(flyable);
            IFlyable orc = new FlyableOrc();
            DoFly(orc);


        }
        
    }
}
